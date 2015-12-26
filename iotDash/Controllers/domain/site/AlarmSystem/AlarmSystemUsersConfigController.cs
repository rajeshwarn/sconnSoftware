﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using AlarmSystemManagmentService;
using iotDash.Content.Dynamic.Status;
using iotDash.Models;
using iotDash.Session;
using iotDatabaseConnector.DAL.Repository.Connector.Entity;
using iotDbConnector.DAL;
using sconnConnector.Config;

namespace iotDash.Controllers.domain.site.AlarmSystem
{
    public class AlarmSystemUsersConfigController : Controller
    {
        private IIotContextBase Icont;
        private UsersConfigurationService _provider;

        public AlarmSystemUsersConfigController(HttpContextBase contBase)
        {
            IIotContextBase cont = (IIotContextBase)contBase.Session["iotcontext"];
            AlarmSystemConfigManager man = (AlarmSystemConfigManager)contBase.Session["alarmSysCfg"];
            if (cont != null)
            {
                this.Icont = cont;
                string domainId = DomainSession.GetContextDomain(contBase);
                iotDomain d = Icont.Domains.First(dm => dm.DomainName.Equals(domainId));
                this._provider = new UsersConfigurationService(this.Icont, man);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Add(AlarmSystemUserAddModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var res = (_provider.AddUser(model.User));
                    model.Result = StatusResponseGenerator.GetStatusResponseResultForReturnParam(res);
                }
            }
            catch (Exception e)
            {
                model.Result = StatusResponseGenerator.GetRequestResponseCriticalError();
            }
            return View(model);
        }

        public ActionResult View()
        {
            AlarmSystemUserConfigModel model = new AlarmSystemUserConfigModel(this._provider.GetUserConfig());
            return View(model);
        }

    }
}