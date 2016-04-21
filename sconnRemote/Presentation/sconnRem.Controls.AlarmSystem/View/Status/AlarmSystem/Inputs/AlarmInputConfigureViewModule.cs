﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mef.Modularity;
using Prism.Modularity;
using Prism.Regions;
using sconnRem.Controls.AlarmSystem.View.Status.Inputs;
using sconnRem.Navigation;

namespace sconnRem.Controls.AlarmSystem.View.Status.AlarmSystem.Inputs
{


    [ModuleExport(typeof(AlarmInputConfigureViewModule))]
    public class AlarmInputConfigureViewModule : IModule
    {
        [Import]
        public IRegionManager RegionManager;

        public void Initialize()
        {
            this.RegionManager.RegisterViewWithRegion(AlarmRegionNames.MainContentRegion, typeof(AlarmInputConfigureView));
        }
    }

}