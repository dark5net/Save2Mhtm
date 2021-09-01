
namespace Save2Mhtm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tBoxURL = new System.Windows.Forms.TextBox();
            this.tBoxfilePath = new System.Windows.Forms.TextBox();
            this.btnStartSave = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tBoxURL
            // 
            this.tBoxURL.Location = new System.Drawing.Point(12, 62);
            this.tBoxURL.Multiline = true;
            this.tBoxURL.Name = "tBoxURL";
            this.tBoxURL.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tBoxURL.Size = new System.Drawing.Size(685, 326);
            this.tBoxURL.TabIndex = 0;
            this.tBoxURL.Text = "https://payloads.online/archivers/2018-12-19/1/";
            // 
            // tBoxfilePath
            // 
            this.tBoxfilePath.Location = new System.Drawing.Point(12, 23);
            this.tBoxfilePath.Name = "tBoxfilePath";
            this.tBoxfilePath.Size = new System.Drawing.Size(352, 20);
            this.tBoxfilePath.TabIndex = 1;
            // 
            // btnStartSave
            // 
            this.btnStartSave.Location = new System.Drawing.Point(410, 21);
            this.btnStartSave.Name = "btnStartSave";
            this.btnStartSave.Size = new System.Drawing.Size(75, 23);
            this.btnStartSave.TabIndex = 2;
            this.btnStartSave.Text = "开始保存";
            this.btnStartSave.UseVisualStyleBackColor = true;
            this.btnStartSave.Click += new System.EventHandler(this.btnStartSave_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(540, 30);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(0, 13);
            this.lbl1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 400);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnStartSave);
            this.Controls.Add(this.tBoxfilePath);
            this.Controls.Add(this.tBoxURL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Save2Mhtm beta 1 http://www.dark5.net";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxURL;
        private System.Windows.Forms.TextBox tBoxfilePath;
        private System.Windows.Forms.Button btnStartSave;
        private System.Windows.Forms.Label lbl1;
    }
}

