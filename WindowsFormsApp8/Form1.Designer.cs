namespace WindowsFormsApp8
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_ImgLoad = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Img_box = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Img_box)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_ImgLoad
            // 
            this.Btn_ImgLoad.Location = new System.Drawing.Point(487, 297);
            this.Btn_ImgLoad.Name = "Btn_ImgLoad";
            this.Btn_ImgLoad.Size = new System.Drawing.Size(159, 62);
            this.Btn_ImgLoad.TabIndex = 0;
            this.Btn_ImgLoad.Text = "Btn_ImgLoad";
            this.Btn_ImgLoad.UseVisualStyleBackColor = true;
            this.Btn_ImgLoad.Click += new System.EventHandler(this.Btn_ImgLoad_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(62, 297);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(152, 62);
            this.Btn_Save.TabIndex = 1;
            this.Btn_Save.Text = "Btn_Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Img_box
            // 
            this.Img_box.Location = new System.Drawing.Point(366, 17);
            this.Img_box.Name = "Img_box";
            this.Img_box.Size = new System.Drawing.Size(401, 245);
            this.Img_box.TabIndex = 2;
            this.Img_box.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Img_box);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Btn_ImgLoad);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Img_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_ImgLoad;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.PictureBox Img_box;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

