using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace TryDownload
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();

            var wc = new WebClient();
            wc.OpenReadCompleted += new OpenReadCompletedEventHandler(wc_OpenReadCompleted);
            wc.OpenReadAsync(new Uri("Webdings.ttf" , UriKind.Relative));

        }

        void wc_OpenReadCompleted(object sender, OpenReadCompletedEventArgs e)
        {
            textBlock1.FontSource = new FontSource(e.Result);
        }
    }
}
