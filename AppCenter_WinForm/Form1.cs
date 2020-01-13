using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace AppCenter_WinForm
{
    public partial class Form1 : Form
    {
        private const string app_key = "bdd9dcd9-5137-4cb8-9186-3f7f7a3c756a";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //AppCenter.LogLevel = LogLevel.Verbose;
            AppCenter.Start(app_key, typeof(Analytics), typeof(Crashes));
        }

        private void btnSendEvent_Click(object sender, EventArgs e)
        {
            Analytics.TrackEvent($"DATE: {DateTime.Now.ToLongDateString()} Message: {txtSendEvent.Text.Trim()}");
        }
    }
}
