﻿using AlarmSystemManagmentService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using sconnConnector.Config;
using sconnConnector.POCO.Config.Abstract;
using sconnRem.ViewModel.Generic;
using sconnConnector.POCO.Config;
using Prism.Mvvm;
using System.ComponentModel.Composition;

namespace sconnRem.ViewModel.Alarm
{

    [Export]
    public class AlarmGsmConfigViewModel : BindableBase     // ObservableObject, IPageViewModel
    {
        public sconnGsmConfig Config { get; set; }
        private GsmConfigurationService _Provider;
        private AlarmSystemConfigManager _Manager;

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
        }

        private void SaveData()
        {

        }

        public AlarmGsmConfigViewModel()
        {
            _Name = "Gsm";
            this._Provider = new GsmConfigurationService(_Manager);
        }

        [ImportingConstructor]
        public AlarmGsmConfigViewModel(AlarmSystemConfigManager Manager)
        {
            _Manager = Manager;
            _Name = "Gsm";
            this._Provider = new GsmConfigurationService(_Manager);
        }


        public string DisplayedImagePath
        {
            get { return "pack://application:,,,/images/tel.png"; }
        }

    }
}