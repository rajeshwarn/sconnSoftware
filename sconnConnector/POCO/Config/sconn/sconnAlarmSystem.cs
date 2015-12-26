﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sconnConnector.POCO.Config.Abstract;
using sconnConnector.POCO.Config.Abstract.Auth;
using sconnConnector.POCO.Config.Abstract.Event;

namespace sconnConnector.POCO.Config.sconn
{
    public class sconnAlarmSystem //: AlarmSystemConfig
    {
        
        public ipcSiteConfig legacySiteConfig { get; set; }

        public sconnAuthorizedDevices AuthorizedDevices { get; set; }
        public sconnDeviceConfig DeviceConfig { get; set; }
        public sconnEventConfig EventConfig { get; set; }
        public sconnGlobalConfig GlobalConfig { get; set; }
        public sconnGsmConfig GsmConfig { get; set; }
        public sconnAlarmZoneConfig ZoneConfig { get; set; }
        public sconnUserConfig UserConfig { get; set; }

        public sconnAlarmSystem()
        {
                
        }
        
        public void ReloadConfig()
        {
            AuthorizedDevices = new sconnAuthorizedDevices(legacySiteConfig);
            DeviceConfig = new sconnDeviceConfig(legacySiteConfig);
            EventConfig = new sconnEventConfig(legacySiteConfig);
            GlobalConfig = new sconnGlobalConfig(legacySiteConfig);
            GsmConfig = new sconnGsmConfig(legacySiteConfig);
            
        }
        

    }
}
