﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using AlarmSystemManagmentService;
using AlarmSystemManagmentService.Device;
using Prism.Regions;
using sconnConnector.Config;
using sconnConnector.POCO.Config.sconn;
using sconnRem.Controls.AlarmSystem.ViewModel.Generic;
using sconnRem.Infrastructure.Navigation;
using sconnRem.Navigation;
using sconnRem.ViewModel.Generic;

namespace sconnRem.Controls.AlarmSystem.ViewModel.Alarm
{

    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class AlarmPsuStatusViewModel : GenericAlarmConfigViewModel
        {
            private ObservableCollection<sconnDevice> _config;
            private AlarmDevicesConfigService _provider;
            private IAlarmSystemNavigationService AlarmNavService { get; set; }

         public ObservableCollection<sconnDevice> Config
            {
                get { return _config; }
             set { SetProperty(ref _config, value); }
            }

            public ICommand ShowDeviceStatusCommand { get; set; }


            public override void GetData()
            {
                try
                {
                    Config = AlarmNavService.Online ? new ObservableCollection<sconnDevice>(_provider.GetAll()) : new ObservableCollection<sconnDevice>(AlarmNavService.alarmSystemConfigManager.Config.DeviceConfig.Devices);
              
                }
                catch (Exception ex)
                {
                    _nlogger.Error(ex, ex.Message);
                }
            }

            public override void SaveData()
            {

            }

            public AlarmPsuStatusViewModel()
            {
                Config = new ObservableCollection<sconnDevice>(new List<sconnDevice>());
                this._provider = new AlarmDevicesConfigService(_manager);
            }


            [ImportingConstructor]
            public AlarmPsuStatusViewModel(IRegionManager regionManager, IAlarmSystemNavigationService NavService)
            {
                AlarmNavService = NavService;
                Config = new ObservableCollection<sconnDevice>(new List<sconnDevice>());
                this._manager = AlarmNavService.alarmSystemConfigManager;
                this._provider = new AlarmDevicesConfigService(_manager);
                _regionManager = regionManager;
                this.PropertyChanged += new PropertyChangedEventHandler(OnNotifiedOfPropertyChanged);
            }

            private void OnNotifiedOfPropertyChanged(object sender, PropertyChangedEventArgs e)
            {
                if (e != null && !String.Equals(e.PropertyName, "IsChanged", StringComparison.Ordinal))
                {
                    this.IsChanged = true;
                }
            }

            public string DisplayedImagePath
            {
                get { return "pack://application:,,,/images/config2.png"; }
            }


            public override bool IsNavigationTarget(NavigationContext navigationContext)
            {
                if (navigationContext.Uri.OriginalString.Equals(AlarmRegionNames.AlarmStatus_Contract_NetworkView))
                {
                    return true;    //singleton
                }
                return false;
            }

        }



    }
