using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public void Battery()
        {
            ACStatus.Text = "電源状態不明";
            BatteryStatus.Text = "???%";
            //enum BatteryPercentage
        {
            
        };
            
            ;
            switch (BatteryPercentage)
            {
                case BatteryChargeStatus.High:
                    BatteryStatus.Text = "高い";
                    break;
                case BatteryChargeStatus.Low:
                    BatteryStatus.Text = "低い";
                    break;
                case BatteryChargeStatus.Critical:
                    BatteryStatus.Text = "非常に低い";
                    break;
                case BatteryChargeStatus.Charging:
                    BatteryStatus.Text = "充電中";
                    break;
                case BatteryChargeStatus.NoSystemBattery:
                    BatteryStatus.Text = "バッテリーは存在しない";
                    break;
                case BatteryChargeStatus.Unknown:
                    BatteryStatus.Text = "不明";
                    break;
                default:
                    BatteryStatus.Text = "不明";
                    break;
            }
        }
    }
}
