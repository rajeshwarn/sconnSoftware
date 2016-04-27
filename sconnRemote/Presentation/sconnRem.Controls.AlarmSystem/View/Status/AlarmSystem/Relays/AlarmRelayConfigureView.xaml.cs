﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using NLog;
using Prism.Regions;
using sconnRem.Controls.AlarmSystem.ViewModel.Alarm;
using sconnRem.Navigation;

namespace sconnRem.Controls.AlarmSystem.View.Status.AlarmSystem.Relays
{

    [Export("AlarmRelayConfigureView")]
    [ViewSortHint("02")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class AlarmRelayConfigureView : UserControl
    {
        private const string MainContentRegionName = GlobalViewRegionNames.MainGridContentRegion;
        private Logger _nlogger = LogManager.GetCurrentClassLogger();

        [Import]
        public AlarmOutputConfigViewModel ViewModel
        {
            set { this.DataContext = value; }
        }

        public AlarmRelayConfigureView()
        {
            InitializeComponent();
        }
    }

}