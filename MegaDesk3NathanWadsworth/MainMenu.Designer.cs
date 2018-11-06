namespace MegaDesk4NathanWadsworth
{
    partial class MainMenu
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
            this.NewQuoteBut = new System.Windows.Forms.Button();
            this.ViewQuotesBut = new System.Windows.Forms.Button();
            this.SearchQuotesBut = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NewQuoteBut
            // 
            this.NewQuoteBut.Location = new System.Drawing.Point(15, 39);
            this.NewQuoteBut.Name = "NewQuoteBut";
            this.NewQuoteBut.Size = new System.Drawing.Size(145, 44);
            this.NewQuoteBut.TabIndex = 0;
            this.NewQuoteBut.Text = "Add a Quote";
            this.NewQuoteBut.UseVisualStyleBackColor = true;
            this.NewQuoteBut.Click += new System.EventHandler(this.NewQuoteBut_Click);
            // 
            // ViewQuotesBut
            // 
            this.ViewQuotesBut.Location = new System.Drawing.Point(166, 39);
            this.ViewQuotesBut.Name = "ViewQuotesBut";
            this.ViewQuotesBut.Size = new System.Drawing.Size(145, 44);
            this.ViewQuotesBut.TabIndex = 1;
            this.ViewQuotesBut.Text = "View Quotes";
            this.ViewQuotesBut.UseVisualStyleBackColor = true;
            this.ViewQuotesBut.Click += new System.EventHandler(this.ViewQuotesBut_Click);
            // 
            // SearchQuotesBut
            // 
            this.SearchQuotesBut.Location = new System.Drawing.Point(317, 39);
            this.SearchQuotesBut.Name = "SearchQuotesBut";
            this.SearchQuotesBut.Size = new System.Drawing.Size(145, 44);
            this.SearchQuotesBut.TabIndex = 2;
            this.SearchQuotesBut.Text = "Search Quotes";
            this.SearchQuotesBut.UseVisualStyleBackColor = true;
            this.SearchQuotesBut.Click += new System.EventHandler(this.SearchQuotesBut_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(166, 364);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(145, 44);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MegaDesk3NathanWadsworth.Properties.Resources._8100900167_764ea4d457_z;
            this.pictureBox1.Location = new System.Drawing.Point(79, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 269);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.SearchQuotesBut);
            this.Controls.Add(this.ViewQuotesBut);
            this.Controls.Add(this.NewQuoteBut);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewQuoteBut;
        private System.Windows.Forms.Button ViewQuotesBut;
        private System.Windows.Forms.Button SearchQuotesBut;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

