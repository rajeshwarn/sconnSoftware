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
using Prism.Regions;
using sconnRem.Navigation;

namespace sconnRem.Controls.Navigation.View.Menu.ContextToolbar.CCTV
{
    /// <summary>
    /// Interaction logic for CctvToolbarView.xaml
    /// </summary>

    [Export(GlobalViewContractNames.Global_Contract_Menu_Top_CctvContext)]
    [ViewSortHint("01")]
    [PartCreationPolicy(CreationPolicy.Any)]
    public partial class CctvToolbarView : UserControl
    {
        public CctvToolbarView()
        {
            InitializeComponent();
        }
    }
}
