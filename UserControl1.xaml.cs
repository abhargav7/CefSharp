using System;
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
using CefSharp;
using CefSharp.Wpf;

namespace CefSharp.MinimalExample.Wpf
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {

        #region Singleton
        private static volatile UserControl1 instance;
        private static object syncRoot = new Object();

        public static UserControl1 Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new UserControl1();
                    }
                }

                return instance;
            }
        }

        #endregion
        private UserControl1()
        {
            //  Application.Current.Dispatcher.BeginInvoke(new Action(delegate
            {
                InitializeComponent();
                Browser.Address = "http://www.google.com";
            }
            this.Loaded += UserControl1_Initialized;
            this.Unloaded += UserControl1_Unloaded;

        }

        private void UserControl1_Unloaded(object sender, RoutedEventArgs e)
        {
            // throw new NotImplementedException();
        }

        private void UserControl1_Initialized(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
            //uncommentabove issue is gone//

            ////test work
            //GridIn.Focus(); ;
            ////GridIn.Children.Clear();
            //var aq =ChromiumWebBrowser.WebBrowser;
            //if (aq != null)
            //{
            //    ChromiumWebBrowser aChromiumWebBrowser = new ChromiumWebBrowser();
            //    aChromiumWebBrowser.Address = aq.Address;
            //    GridIn.Children.Clear();
            //    if (aq.Address != null)
            //        ChromiumWebBrowser.WebBrowser = aq;

            //    GridIn.Children.Add(ChromiumWebBrowser);
        }
    }
}
