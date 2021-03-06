﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using AlarmSystemManagmentService;
using AlarmSystemManagmentService.AlarmSystemUsers;
using Prism.Regions;
using sconnConnector.Config;
using sconnConnector.POCO.Config.Abstract.Auth;
using sconnConnector.POCO.Config.sconn.User;
using sconnRem.Infrastructure.Navigation;
using sconnRem.Navigation;
using sconnRem.ViewModel.Generic;

namespace sconnRem.Controls.AlarmSystem.ViewModel.Alarm
{
    
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class AlarmSystemUsersConfigViewModel : GenericAlarmConfigViewModel
    {
        private IAlarmSystemNavigationService AlarmNavService { get; set; }

        private ObservableCollection<sconnAlarmSystemUser> _config;
        public ObservableCollection<sconnAlarmSystemUser> Config
        {
            get { return _config; }
            set
            {
                _config = value;
                OnPropertyChanged();
            }
        }

        private int _selectedIndex;
        public int SelectedIndex
        {
            get { return _selectedIndex; }
            set
            {
                _selectedIndex = value;
                OnPropertyChanged();
                if (_selectedIndex < Config.Count)
                {
                    Application.Current.Dispatcher.Invoke(() => { OpenEntityEditContext(Config[_selectedIndex]); });
                }
            }
        }

        private AlarmSystemUsersConfigurationService _provider;
        private AlarmSystemConfigManager _manager;

        public ICommand EntitySelected;
        public ICommand ConfigureEntityCommand;

        public void OpenEntityEditContext(sconnAlarmSystemUser device)
        {
            NavigationParameters parameters = new NavigationParameters();
            if (device != null)
            {
                parameters.Add(GlobalViewContractNames.Global_Contract_Nav_Site_Context__Key_Name, siteUUID);
                parameters.Add(AlarmSystemEntityListContractNames.Alarm_Contract_Entity_SystemUser_Edit_Context_Key_Name, device.Id);
            }
            else
            {
                parameters.Add(GlobalViewContractNames.Global_Contract_Nav_Site_Context__Key_Name, siteUUID);
            }
            GlobalNavigationContext.NavigateRegionToContractWithParam(
                GlobalViewRegionNames.RNavigationRegion,
                GlobalViewContractNames.Global_Contract_Menu_RightSide_AlarmSystemUserEditListItemContext,
                parameters
                );
        }

        public override void GetData()
        {
            try
            {
                if (AlarmNavService.Online)
                {
                    Config = new ObservableCollection<sconnAlarmSystemUser>(_provider.GetAll());
                }
                else
                {
                    Config = new ObservableCollection<sconnAlarmSystemUser>(AlarmNavService.alarmSystemConfigManager.Config.AlarmUserConfig.Users);
                }
                SelectedIndex = 0; //reset on refresh
            }
            catch (Exception ex)
            {
                _nlogger.Error(ex, ex.Message);
            }
        }

        public override void SaveData()
        {
            foreach (var item in Config)
            {
                _provider.Update(item);
            }
        }

        public AlarmSystemUsersConfigViewModel()
        {
            _name = "Users";
            this._provider = new AlarmSystemUsersConfigurationService(_manager);
        }


        [ImportingConstructor]
        public AlarmSystemUsersConfigViewModel(IRegionManager regionManager, IAlarmSystemNavigationService NavService)
        {
            AlarmNavService = NavService;
            Config = new ObservableCollection<sconnAlarmSystemUser>();
            this._manager = AlarmNavService.alarmSystemConfigManager;
            this._provider = new AlarmSystemUsersConfigurationService(_manager);
            this._regionManager = regionManager;
        }

        public string DisplayedImagePath
        {
            get { return "pack://application:,,,/images/user.png"; }
        }


        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            try
            {
                siteUUID = (string)navigationContext.Parameters[GlobalViewContractNames.Global_Contract_Nav_Site_Context__Key_Name];
                this.navigationJournal = navigationContext.NavigationService.Journal;

                BackgroundWorker bgWorker = new BackgroundWorker();
                bgWorker.DoWork += (s, e) => {
                    GetData();
                };
                bgWorker.RunWorkerCompleted += (s, e) =>
                {

                    Loading = false;
                };

                Loading = true;

                bgWorker.RunWorkerAsync();

            }
            catch (Exception ex)
            {
                _nlogger.Error(ex, ex.Message);
            }


        }


        public override bool IsNavigationTarget(NavigationContext navigationContext)
        {
            if (navigationContext.Uri.OriginalString.Equals(AlarmRegionNames.AlarmConfig_Contract_SystemUsersConfigView))
            {
                return true;    //singleton
            }
            return false;
        }



    }
}
