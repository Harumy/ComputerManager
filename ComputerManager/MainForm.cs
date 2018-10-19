using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace ComputerManager
{
    public partial class MainForm : Form
    {
        delegate void BattDelegate();
        public MainForm()
        {
            InitializeComponent();
            var timer = new System.Windows.Forms.Timer();
            timer.Interval = 100;
            timer.Start();
            timer.Tick += (sender, e) =>
            {
                try
                {
                    timer.Stop();
                    Battery();
                }
                finally
                {
                    timer.Start();
                }
            };
            timer.Start();
            //timer.Stop();
            //using (timer) { }
        }
        public void Battery()
        {
            ACStatus.Text = "電源状態不明";
            BatteryStatus.Text = "???%";
            DateTime dt = DateTime.Now;
            TimeLabel.Text = dt.ToString("HH:mm:ss");
            PowerLineStatus PowerLineStatus = SystemInformation.PowerStatus.PowerLineStatus;
            BatteryChargeStatus BatteryChargeStatus = SystemInformation.PowerStatus.BatteryChargeStatus;
            switch (PowerLineStatus)
            {
                case PowerLineStatus.Online:
                    switch (BatteryChargeStatus)
                    {
                        case BatteryChargeStatus.Charging:
                            ACStatus.Text = "AC電源\nバッテリー充電中";
                            break;
                        case BatteryChargeStatus.NoSystemBattery:
                            ACStatus.Text = "AC電源";
                            break;
                        case BatteryChargeStatus.Critical:
                            ACStatus.Text = "AC電源\nバッテリー僅少";
                            break;
                        case BatteryChargeStatus.High:
                            ACStatus.Text = "AC電源\nバッテリー高";
                            break;
                        case BatteryChargeStatus.Low:
                            ACStatus.Text = "AC電源\nバッテリー少";
                            break;
                        default:
                            ACStatus.Text = "AC電源\nバッテリー不明";
                            break;
                    }
                    BatteryStatus.Text = "";
                    break;
                case PowerLineStatus.Offline:
                    switch (BatteryChargeStatus)
                    {

                        case BatteryChargeStatus.Charging:
                            ACStatus.Text = "バッテリー充電中";
                            break;
                        case BatteryChargeStatus.Critical:
                            ACStatus.Text = "バッテリー僅少";
                            break;
                        case BatteryChargeStatus.High:
                            ACStatus.Text = "バッテリー高";
                            break;
                        case BatteryChargeStatus.Low:
                            ACStatus.Text = "バッテリー少";
                            break;
                        default:
                            ACStatus.Text = "バッテリー不明";
                            break;
                    }
                    float BatteryPercent = SystemInformation.PowerStatus.BatteryLifePercent;
                    BatteryStatus.Text = (BatteryPercent * 100).ToString() + "%";
                    break;
                default:
                    ACStatus.Text = "お手上げ";
                    break;

            }
        }
        public void Processor()
        {

        }

    }
}
