namespace 图像识别
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.begin = new System.Windows.Forms.Button();
            this.content = new System.Windows.Forms.TextBox();
            this.IMG_Path = new System.Windows.Forms.Label();
            this.IMGpath = new System.Windows.Forms.TextBox();
            this.selectImg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择图片:";
            // 
            // begin
            // 
            this.begin.Location = new System.Drawing.Point(118, 95);
            this.begin.Name = "begin";
            this.begin.Size = new System.Drawing.Size(75, 23);
            this.begin.TabIndex = 1;
            this.begin.Text = "开始识别";
            this.begin.UseVisualStyleBackColor = true;
            this.begin.Click += new System.EventHandler(this.begin_Click);
            // 
            // content
            // 
            this.content.Location = new System.Drawing.Point(61, 124);
            this.content.Multiline = true;
            this.content.Name = "content";
            this.content.ReadOnly = true;
            this.content.Size = new System.Drawing.Size(258, 114);
            this.content.TabIndex = 2;
            // 
            // IMG_Path
            // 
            this.IMG_Path.AutoSize = true;
            this.IMG_Path.Location = new System.Drawing.Point(107, 46);
            this.IMG_Path.Name = "IMG_Path";
            this.IMG_Path.Size = new System.Drawing.Size(0, 12);
            this.IMG_Path.TabIndex = 3;
            // 
            // IMGpath
            // 
            this.IMGpath.Location = new System.Drawing.Point(109, 46);
            this.IMGpath.Name = "IMGpath";
            this.IMGpath.Size = new System.Drawing.Size(149, 21);
            this.IMGpath.TabIndex = 4;
            // 
            // selectImg
            // 
            this.selectImg.Location = new System.Drawing.Point(264, 46);
            this.selectImg.Name = "selectImg";
            this.selectImg.Size = new System.Drawing.Size(31, 23);
            this.selectImg.TabIndex = 5;
            this.selectImg.Text = "...";
            this.selectImg.UseVisualStyleBackColor = true;
            this.selectImg.Click += new System.EventHandler(this.selectImg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 262);
            this.Controls.Add(this.selectImg);
            this.Controls.Add(this.IMGpath);
            this.Controls.Add(this.IMG_Path);
            this.Controls.Add(this.content);
            this.Controls.Add(this.begin);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button begin;
        private System.Windows.Forms.TextBox content;
        private System.Windows.Forms.Label IMG_Path;
        private System.Windows.Forms.TextBox IMGpath;
        private System.Windows.Forms.Button selectImg;
    }
}

