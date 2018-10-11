namespace MegaDesk3NathanWadsworth
{
    partial class ViewAllQoutes
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
            this.BackToMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackToMenu
            // 
            this.BackToMenu.Location = new System.Drawing.Point(115, 138);
            this.BackToMenu.Name = "BackToMenu";
            this.BackToMenu.Size = new System.Drawing.Size(229, 111);
            this.BackToMenu.TabIndex = 0;
            this.BackToMenu.Text = "Back";
            this.BackToMenu.UseVisualStyleBackColor = true;
            this.BackToMenu.Click += new System.EventHandler(this.BackToMenu_Click);
            // 
            // ViewAllQoutes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.BackToMenu);
            this.Name = "ViewAllQoutes";
            this.Text = "ViewAllQoutes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackToMenu;
    }
}