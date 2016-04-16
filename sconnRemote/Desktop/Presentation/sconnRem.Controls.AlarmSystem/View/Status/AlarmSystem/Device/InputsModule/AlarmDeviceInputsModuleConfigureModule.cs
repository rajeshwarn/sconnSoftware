﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mef.Modularity;
using Prism.Modularity;
using Prism.Regions;
using sconnRem.Controls.AlarmSystem.View.Status.AlarmSystem.Zones;
using sconnRem.Navigation;

namespace sconnRem.Controls.AlarmSystem.View.Status.AlarmSystem.Device.InputsModule
{
    [ModuleExport(typeof(AlarmDeviceInputsModuleConfigureModule))]
    public class AlarmDeviceInputsModuleConfigureModule : IModule
    {
        [Import]
        public IRegionManager RegionManager;

        public void Initialize()
        {
            this.RegionManager.RegisterViewWithRegion(AlarmRegionNames.MainContentRegion, typeof(AlarmDeviceInputsModuleConfigureView));
        }
    }


}