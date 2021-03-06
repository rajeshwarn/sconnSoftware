﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using AlarmSystemManagmentService;
using AlarmSystemManagmentService.Device;
using NLog;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using sconnConnector.Config;
using sconnConnector.POCO.Config;
using sconnRem.Controls.AlarmSystem.ViewModel.Generic;
using sconnRem.Infrastructure.Navigation;
using sconnRem.Navigation;
using sconnRem.ViewModel.Generic;

namespace sconnRem.Controls.AlarmSystem.ViewModel.Alarm
{
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class AlarmOutputConfigViewModel : GenericAlarmConfigViewModel
    {
        public sconnOutput Config { get; set; }
        private AlarmDevicesConfigService _provider;
        private AlarmSystemConfigManager _manager;
        private IAlarmSystemNavigationService AlarmNavService { get; set; }
        private IRegionNavigationJournal navigationJournal;


        public ICommand NavigateBackCommand { get; set; }
        public ICommand SaveConfigCommand { get; set; }

        public AlarmOutputConfigViewModel()
        {
            this._manager = AlarmNavService.alarmSystemConfigManager;
            _name = "Dev";
            this._provider = new AlarmDevicesConfigService(_manager);
        }

        public void NavigateBack()
        {
            try
            {
                this.navigationJournal?.GoBack();
            }
            catch (Exception ex)
            {
                _nlogger.Error(ex, ex.Message);
            }
        }

        public override void SaveData()
        {
            AlarmNavService.SaveOutput(this.Config);
        }

        [ImportingConstructor]
        public AlarmOutputConfigViewModel(IRegionManager regionManager, IAlarmSystemNavigationService NavService)
        {
            SetupCmds();
            AlarmNavService = NavService;
            this._manager = AlarmNavService.alarmSystemConfigManager; 
            this._regionManager = regionManager;
            GetData();
        }

        private void SetupCmds()
        {
            NavigateBackCommand = new DelegateCommand(NavigateBack);
            SaveConfigCommand = new DelegateCommand(SaveData);
        }

        public string DisplayedImagePath
        {
            get { return "pack://application:,,,/images/config1.png"; }
        }

        public override  void OnNavigatedTo(NavigationContext navigationContext)
        {
            string inputId = (string)navigationContext.Parameters[AlarmRegionNames.AlarmConfig_Contract_Input_Config_View_Key_Name];
            siteUUID = (string)navigationContext.Parameters[GlobalViewContractNames.Global_Contract_Nav_Site_Context__Key_Name];
            if (inputId != null)
            {
                this.Config = AlarmNavService.OutputForId(inputId);
            }

            this.navigationJournal = navigationContext.NavigationService.Journal;
        }

        public override bool IsNavigationTarget(NavigationContext navigationContext)
        {
            if (this.Config == null)
            {
                return true;
            }
            var targetsiteUuid = (string)navigationContext.Parameters[GlobalViewContractNames.Global_Contract_Nav_Site_Context__Key_Name];
            if (targetsiteUuid != siteUUID)
            {
                var inputId = navigationContext.Parameters[AlarmRegionNames.AlarmConfig_Contract_Input_Config_View_Key_Name]; 
                return inputId.Equals(Config.UUID);
            }
            return false;

        }
        
    }

}
