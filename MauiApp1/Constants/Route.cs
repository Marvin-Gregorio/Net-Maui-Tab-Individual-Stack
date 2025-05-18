using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace MauiApp1.Constants
{
    public static class Route
    {
        public static Microsoft.Maui.Controls.ShellSection? tab1 = Shell.Current.Items[0].Items[0];
        public static Microsoft.Maui.Controls.ShellSection? tab2 = Shell.Current.Items[0].Items[0];
        public static Microsoft.Maui.Controls.ShellSection? tab3 = Shell.Current.Items[0].Items[0];
    }
}
