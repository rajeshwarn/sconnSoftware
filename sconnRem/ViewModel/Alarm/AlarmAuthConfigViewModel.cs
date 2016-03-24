﻿using AlarmSystemManagmentService;
using sconnRem.ViewModel.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sconnConnector.Config;
using sconnConnector.POCO.Config.Abstract;
using System.Windows.Input;
using sconnConnector.POCO.Config.sconn;
using System.Collections.ObjectModel;
using Microsoft.Practices.Unity;
using System.ComponentModel.Composition;
using Prism.Mvvm;
using Prism.Mef.Modularity;
using Prism.Modularity;
using sconnRem.Wnd.Config;
using Prism.Regions;

namespace sconnRem.ViewModel.Alarm
{


    [Export]
    public class AlarmAuthConfigViewModel : BindableBase    // ObservableObject, IPageViewModel    //  :  ViewModelBase<IGridNavigatedView>
    {
        public ObservableCollection<sconnAuthorizedDevice> AuthorizedDevices { get; set; }
        private AuthorizedDevicesConfigurationService _Provider;

        [Dependency]
        public AlarmSystemConfigManager _Manager { get; set; }
        

        private string _Name;
        public string Name
        {
            get
            {
                return _Name;
            }
        }
        
        private ICommand _getDataCommand;
        private ICommand _saveDataCommand;

        private void GetData()
        {
            AuthorizedDevices.Clear();
            var retr = _Provider.GetAll();
            foreach (var item in retr)
            {
                AuthorizedDevices.Add(item);
            }
        }

        private void SaveData()
        {
            _Provider.SaveChanges();
        }

        public string DisplayedImagePath
        {
            get { return "pack://application:,,,/images/lista2.png"; }
        }



        public AlarmAuthConfigViewModel()
        {
            _Name = "Auth";
            AuthorizedDevices = new ObservableCollection<sconnAuthorizedDevice>();
            AuthorizedDevices.Add(new sconnAuthorizedDevice());
            AuthorizedDevices.Add(new sconnAuthorizedDevice());
            AuthorizedDevices.Add(new sconnAuthorizedDevice());
            AuthorizedDevices.Add(new sconnAuthorizedDevice());
            this._Provider = new AuthorizedDevicesConfigurationService(_Manager);
        }

        [ImportingConstructor]
        public AlarmAuthConfigViewModel(AlarmSystemConfigManager Manager)
        {
            AuthorizedDevices = new ObservableCollection<sconnAuthorizedDevice>();
            AuthorizedDevices.Add(new sconnAuthorizedDevice());
            AuthorizedDevices.Add(new sconnAuthorizedDevice());
            _Manager = Manager;
            _Name = "Auth";
            this._Provider = new AuthorizedDevicesConfigurationService(_Manager);
          //  GetData();
            

        }
        
    }

    

}
