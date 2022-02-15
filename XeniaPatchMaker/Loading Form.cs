using DevExpress.XtraSplashScreen;
using System;

namespace XeniaPatchMaker
{
    public partial class Loading_Screen : SplashScreen
    {
        public Loading_Screen()
        {
            InitializeComponent();
            labelCopyright.Text = "Copyright © 1998-" + DateTime.Now.Year.ToString();
        }
    }
}
