﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using sconnConnector.POCO.Config.Abstract;
using sconnConnector.POCO.Config.sconn;

namespace sconnConnector.POCO.Config
{
    public class sconnGsmConfig : IAlarmSystemEntityConfig, IFakeAbleConfiguration
    {
        public int RcptNo { get; set; }
        
        [MaxLength(ipcDefines.RAM_SMS_RECP_NO)]
        public List<sconnGsmRcpt> Rcpts { get; set; }

        private static Logger _logger = LogManager.GetCurrentClassLogger();

        public sconnGsmConfig()
        {
            Rcpts = new List<sconnGsmRcpt>();
            UUID = Guid.NewGuid().ToString();
        }

        public void Clear()
        {
            this.Rcpts = new List<sconnGsmRcpt>();
        }

        public int GetEntityCount()
        {
            return Rcpts.Count;
        }

        public byte[] SerializeEntityWithId(int id)
        {
            try
            {
                return Rcpts[id].Serialize();
            }
            catch (Exception e)
            {
                _logger.Error(e, e.Message);
                return null;
            }
        }
        public void DeserializeEntityWithId(byte[] buffer)
        {
            try
            {
                Rcpts.Add(new sconnGsmRcpt(buffer));
            }
            catch (Exception e)
            {
                _logger.Error(e, e.Message);
            }
        }

        public void Fake()
        {
            try
            {
                sconnGsmRcpt zone = new sconnGsmRcpt();
                zone.Fake();
                Rcpts.Add(zone);
            }
            catch (Exception e)
            {
                _logger.Error(e, e.Message);
            }

        }

        public string UUID { get; set; }
    }

}
