namespace MegaDesk4NathanWadsworth
{
    partial class DisplayQuote
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
            this.quoteTB = new System.Windows.Forms.TextBox();
            this.CustNameTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MatCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RushCombo = new System.Windows.Forms.ComboBox();
            this.DrawersUpDown = new System.Windows.Forms.NumericUpDown();
            this.DepthUpDown = new System.Windows.Forms.NumericUpDown();
            this.WidthUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DrawersUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // quoteTB
            // 
            this.quoteTB.Location = new System.Drawing.Point(127, 268);
            this.quoteTB.Name = "quoteTB";
            this.quoteTB.ReadOnly = true;
            this.quoteTB.Size = new System.Drawing.Size(105, 20);
            this.quoteTB.TabIndex = 35;
            // 
            // CustNameTB
            // 
            this.CustNameTB.Enabled = false;
            this.CustNameTB.Location = new System.Drawing.Point(127, 19);
            this.CustNameTB.Name = "CustNameTB";
            this.CustNameTB.Size = new System.Drawing.Size(105, 20);
            this.CustNameTB.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Customer Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Desk Cost";
            // 
            // MatCombo
            // 
            this.MatCombo.Enabled = false;
            this.MatCombo.FormattingEnabled = true;
            this.MatCombo.Location = new System.Drawing.Point(127, 174);
            this.MatCombo.Name = "MatCombo";
            this.MatCombo.Size = new System.Drawing.Size(105, 21);
            this.MatCombo.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Rush options";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Surface Material";
            // 
            // RushCombo
            // 
            this.RushCombo.Enabled = false;
            this.RushCombo.FormattingEnabled = true;
            this.RushCombo.Location = new System.Drawing.Point(127, 213);
            this.RushCombo.Name = "RushCombo";
            this.RushCombo.Size = new System.Drawing.Size(105, 21);
            this.RushCombo.TabIndex = 28;
            // 
            // DrawersUpDown
            // 
            this.DrawersUpDown.Enabled = false;
            this.DrawersUpDown.Location = new System.Drawing.Point(127, 134);
            this.DrawersUpDown.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.DrawersUpDown.Name = "DrawersUpDown";
            this.DrawersUpDown.Size = new System.Drawing.Size(105, 20);
            this.DrawersUpDown.TabIndex = 27;
            this.DrawersUpDown.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // DepthUpDown
            // 
            this.DepthUpDown.Enabled = false;
            this.DepthUpDown.Location = new System.Drawing.Point(127, 95);
            this.DepthUpDown.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.DepthUpDown.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.DepthUpDown.Name = "DepthUpDown";
            this.DepthUpDown.Size = new System.Drawing.Size(105, 20);
            this.DepthUpDown.TabIndex = 26;
            this.DepthUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // WidthUpDown
            // 
            this.WidthUpDown.Enabled = false;
            this.WidthUpDown.Location = new System.Drawing.Point(127, 55);
            this.WidthUpDown.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.WidthUpDown.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.WidthUpDown.Name = "WidthUpDown";
            this.WidthUpDown.Size = new System.Drawing.Size(105, 20);
            this.WidthUpDown.TabIndex = 25;
            this.WidthUpDown.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Number of drawers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Enter the depth";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Enter the width";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(15, 381);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(115, 48);
            this.Back.TabIndex = 36;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.quoteTB);
            this.Controls.Add(this.CustNameTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MatCombo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RushCombo);
            this.Controls.Add(this.DrawersUpDown);
            this.Controls.Add(this.DepthUpDown);
            this.Controls.Add(this.WidthUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DisplayQuote";
            this.Text = "DisplayQuote";
            this.Load += new System.EventHandler(this.DisplayQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DrawersUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox quoteTB;
        private System.Windows.Forms.TextBox CustNameTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox MatCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox RushCombo;
        private System.Windows.Forms.NumericUpDown DrawersUpDown;
        private System.Windows.Forms.NumericUpDown DepthUpDown;
        private System.Windows.Forms.NumericUpDown WidthUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Back;
    }
}