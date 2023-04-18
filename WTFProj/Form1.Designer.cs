namespace WTFProj
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.IPv4_lbl = new System.Windows.Forms.Label();
            this.CopyBtn = new System.Windows.Forms.Button();
            this.IPv6_lbl = new System.Windows.Forms.Label();
            this.HintIPv4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IPv4_lbl
            // 
            resources.ApplyResources(this.IPv4_lbl, "IPv4_lbl");
            this.IPv4_lbl.Name = "IPv4_lbl";
            // 
            // CopyBtn
            // 
            this.CopyBtn.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.CopyBtn, "CopyBtn");
            this.CopyBtn.Name = "CopyBtn";
            this.CopyBtn.UseVisualStyleBackColor = false;
            this.CopyBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // IPv6_lbl
            // 
            resources.ApplyResources(this.IPv6_lbl, "IPv6_lbl");
            this.IPv6_lbl.Name = "IPv6_lbl";
            // 
            // HintIPv4
            // 
            resources.ApplyResources(this.HintIPv4, "HintIPv4");
            this.HintIPv4.Name = "HintIPv4";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HintIPv4);
            this.Controls.Add(this.IPv6_lbl);
            this.Controls.Add(this.CopyBtn);
            this.Controls.Add(this.IPv4_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Opacity = 0.75D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IPv4_lbl;
        private System.Windows.Forms.Button CopyBtn;
        private System.Windows.Forms.Label IPv6_lbl;
        private System.Windows.Forms.Label HintIPv4;
        private System.Windows.Forms.Label label1;
    }
}

