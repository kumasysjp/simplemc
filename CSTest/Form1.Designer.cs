namespace CSTest
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            this.ReadDeviceRandom2Button = new System.Windows.Forms.Button();
            this.WriteDeviceRandom2 = new System.Windows.Forms.Button();
            this.WriteDeviceRandom2ArrayBITButton = new System.Windows.Forms.Button();
            this.WriteDeviceRandom2DWordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReadDeviceRandom2Button
            // 
            this.ReadDeviceRandom2Button.Location = new System.Drawing.Point(16, 15);
            this.ReadDeviceRandom2Button.Margin = new System.Windows.Forms.Padding(4);
            this.ReadDeviceRandom2Button.Name = "ReadDeviceRandom2Button";
            this.ReadDeviceRandom2Button.Size = new System.Drawing.Size(245, 29);
            this.ReadDeviceRandom2Button.TabIndex = 0;
            this.ReadDeviceRandom2Button.Text = "ReadDeviceRandom2";
            this.ReadDeviceRandom2Button.UseVisualStyleBackColor = true;
            this.ReadDeviceRandom2Button.Click += new System.EventHandler(this.ReadDeviceRandom2_Click);
            // 
            // WriteDeviceRandom2
            // 
            this.WriteDeviceRandom2.Location = new System.Drawing.Point(16, 51);
            this.WriteDeviceRandom2.Margin = new System.Windows.Forms.Padding(4);
            this.WriteDeviceRandom2.Name = "WriteDeviceRandom2";
            this.WriteDeviceRandom2.Size = new System.Drawing.Size(245, 29);
            this.WriteDeviceRandom2.TabIndex = 2;
            this.WriteDeviceRandom2.Text = "WriteDeviceRandom2";
            this.WriteDeviceRandom2.UseVisualStyleBackColor = true;
            this.WriteDeviceRandom2.Click += new System.EventHandler(this.WriteDeviceRandom2_Click);
            // 
            // WriteDeviceRandom2ArrayBITButton
            // 
            this.WriteDeviceRandom2ArrayBITButton.Location = new System.Drawing.Point(16, 89);
            this.WriteDeviceRandom2ArrayBITButton.Margin = new System.Windows.Forms.Padding(4);
            this.WriteDeviceRandom2ArrayBITButton.Name = "WriteDeviceRandom2ArrayBITButton";
            this.WriteDeviceRandom2ArrayBITButton.Size = new System.Drawing.Size(245, 29);
            this.WriteDeviceRandom2ArrayBITButton.TabIndex = 3;
            this.WriteDeviceRandom2ArrayBITButton.Text = "WriteDeviceRandom2ArrayBIT";
            this.WriteDeviceRandom2ArrayBITButton.UseVisualStyleBackColor = true;
            this.WriteDeviceRandom2ArrayBITButton.Click += new System.EventHandler(this.WriteDeviceRandom2ArrayBIT_Click);
            // 
            // WriteDeviceRandom2DWordButton
            // 
            this.WriteDeviceRandom2DWordButton.Location = new System.Drawing.Point(17, 126);
            this.WriteDeviceRandom2DWordButton.Margin = new System.Windows.Forms.Padding(4);
            this.WriteDeviceRandom2DWordButton.Name = "WriteDeviceRandom2DWordButton";
            this.WriteDeviceRandom2DWordButton.Size = new System.Drawing.Size(244, 29);
            this.WriteDeviceRandom2DWordButton.TabIndex = 4;
            this.WriteDeviceRandom2DWordButton.Text = "WriteDeviceRandom2DWord";
            this.WriteDeviceRandom2DWordButton.UseVisualStyleBackColor = true;
            this.WriteDeviceRandom2DWordButton.Click += new System.EventHandler(this.WriteDeviceRandom2DWord_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 326);
            this.Controls.Add(this.WriteDeviceRandom2DWordButton);
            this.Controls.Add(this.WriteDeviceRandom2ArrayBITButton);
            this.Controls.Add(this.WriteDeviceRandom2);
            this.Controls.Add(this.ReadDeviceRandom2Button);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReadDeviceRandom2Button;
        private System.Windows.Forms.Button WriteDeviceRandom2;
        private System.Windows.Forms.Button WriteDeviceRandom2ArrayBITButton;
        private System.Windows.Forms.Button WriteDeviceRandom2DWordButton;
    }
}

