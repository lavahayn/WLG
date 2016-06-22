namespace WLG.UI
{
    partial class UILogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UILogin));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pwtbLbl = new System.Windows.Forms.Label();
            this.userTbLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // pwtbLbl
            // 
            resources.ApplyResources(this.pwtbLbl, "pwtbLbl");
            this.pwtbLbl.Name = "pwtbLbl";
            // 
            // userTbLbl
            // 
            resources.ApplyResources(this.userTbLbl, "userTbLbl");
            this.userTbLbl.Name = "userTbLbl";
            // 
            // UILogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userTbLbl);
            this.Controls.Add(this.pwtbLbl);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UILogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UILogin_FormClosing);
            this.Load += new System.EventHandler(this.UILogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UILogin_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label pwtbLbl;
        private System.Windows.Forms.Label userTbLbl;
    }
}