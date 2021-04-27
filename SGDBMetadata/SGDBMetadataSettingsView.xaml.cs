﻿using System;
using System.Collections.Generic;
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

namespace SGDBMetadata
{
    public partial class SGDBMetadataSettingsView : UserControl
    {
         public SGDBMetadataSettingsView()
        {
            InitializeComponent();
            cmbDimensions.ItemsSource = new Dictionary<string, string>
            {
                { "any", "Any" },
                { "460x215", "460x215" },
                { "920x430",  "920x430" },
                { "600x900", "600x900" },
                { "342x482", "342x482" },
                { "660x930", "660x930" },
                { "512x512", "512x512" },
                { "1024x1024", "1024x1024" }
            };
            cmbDimensions.SelectedValue = "any";

            cmbStyles.ItemsSource = new Dictionary<string, string>
            {
                { "any", "Any" },
                { "alternate", "Alternate" },
                { "blurred", "Blurred" },
                { "white_logo", "White Logo" },
                { "material", "Material" },
                { "no_logo", "No Logo" }
            };
            cmbStyles.SelectedValue = "any";

            cmbNsfw.ItemsSource = new Dictionary<string, string>
            {
                { "any", "Any" },
                { "false", "Only get assets not tagged as adult content" },
                { "true", "Only get assets tagged as adult content" },
            };
            cmbNsfw.SelectedValue = "any";

            cmbHumor.ItemsSource = new Dictionary<string, string>
            {
                { "any", "Any" },
                { "false", "Only get assets not tagged as humor" },
                { "true", "Only get assets tagged as humor" },
            };
            cmbHumor.SelectedValue = "any";
        }
    }
}
