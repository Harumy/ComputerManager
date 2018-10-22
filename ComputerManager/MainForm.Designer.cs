namespace ComputerManager
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ACStatus = new System.Windows.Forms.Label();
            this.BatteryStatus = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "電源";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ACStatus
            // 
            this.ACStatus.Location = new System.Drawing.Point(110, 50);
            this.ACStatus.Name = "ACStatus";
            this.ACStatus.Size = new System.Drawing.Size(90, 40);
            this.ACStatus.TabIndex = 2;
            this.ACStatus.Text = "???";
            this.ACStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BatteryStatus
            // 
            this.BatteryStatus.Location = new System.Drawing.Point(210, 50);
            this.BatteryStatus.Name = "BatteryStatus";
            this.BatteryStatus.Size = new System.Drawing.Size(90, 40);
            this.BatteryStatus.TabIndex = 4;
            this.BatteryStatus.Text = "???%";
            this.BatteryStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeLabel
            // 
            this.TimeLabel.Location = new System.Drawing.Point(10, 10);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(290, 40);
            this.TimeLabel.TabIndex = 6;
            this.TimeLabel.Text = "label3";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 101);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.BatteryStatus);
            this.Controls.Add(this.ACStatus);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(330, 489);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "システム監視";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ACStatus;
        private System.Windows.Forms.Label BatteryStatus;
        private System.Windows.Forms.Label TimeLabel;
    }
}

