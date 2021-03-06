﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using NLog;
using Prism.Logging;
using Prism.Mef;
using Prism.Modularity;
using Prism.Regions;
using sconnConnector;
using sconnConnector.Config;
using sconnPrismGenerics.Logging;
using sconnRem.Controls.Navigation.View.Menu.Footer.FooterSiteToolMenu;
using sconnRem.Navigation;
using sconnRem.View.Menu.GridNavSideMenu;
using sconnRem.View.Menu.SiteNavSideMenu;
using sconnRem.View.Menu.ToolTopMenu;
using sconnRem.View.Status;

namespace sconnRem.Wnd.Main
{

    public interface IVerifiableBootstraper
    {
        CompositionContainer GetContainer();
        AggregateCatalog GetAggregateCatalog();
    }


    public class GlobalWndBootstrapper : MefBootstrapper, IVerifiableBootstraper
    {


        private sconnDataSrc _configSource = new sconnDataSrc();
        private Logger _nlogger = LogManager.GetCurrentClassLogger();
        private const string ModuleCatalogUri = "/sconnRem;component/Wnd/Main/WndGlobalShell.xaml";

        //todo - inject from cfg bootstraper
        private void LoadConfigFromDataStore()
        {
            _configSource.LoadConfig(DataSourceType.xml);
        }

        public GlobalWndBootstrapper()
        {
            LoadConfigFromDataStore();
        }

        protected override ILoggerFacade CreateLogger()
        {
            return new MvvmLogger();

        }

        private void NavigateStaticViews()
        {
            GlobalNavigationContext.NavigateRegionToContract(
                GlobalViewRegionNames.FooterLeftNavigationRegion,
                GlobalViewContractNames.Global_Contract_Footer_ConnectivityModeContext
                );

        }

        protected override void ConfigureAggregateCatalog()
        {
            try
            {
                base.ConfigureAggregateCatalog();
                this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(GlobalWndBootstrapper).Assembly));
                this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(GridNavSideMenuModule).Assembly));
                this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(SiteStatusGridViewModule).Assembly));
            }
            catch (Exception ex)
            {
                _nlogger.Error(ex, ex.Message);
            }        

        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            var ncat = new ConfigurationModuleCatalog();
            ncat.AddModule(typeof(FooterConnectivityModeModule));
            return ncat;
        }
        
        protected override DependencyObject CreateShell()
        {
            return this.Container.GetExportedValue<WndGlobalShell>();
        }
        
        protected override void InitializeShell()
        {
            try
            {
                base.InitializeShell();
                Application.Current.MainWindow = (Window)this.Shell;
                Application.Current.MainWindow.Show();
            }
            catch (Exception ex)
            {
                _nlogger.Error(ex,ex.Message);
            }

        }

        public CompositionContainer GetContainer()
        {
            return this.Container;
        }

        public AggregateCatalog GetAggregateCatalog()
        {
            return this.AggregateCatalog;
        }
    }




}
