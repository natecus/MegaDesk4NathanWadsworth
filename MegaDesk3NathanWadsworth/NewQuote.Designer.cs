namespace MegaDesk3NathanWadsworth
{
    partial class NewQuote
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
            this.Back = new System.Windows.Forms.Button();
            this.DisplayQuoteBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WidthUpDown = new System.Windows.Forms.NumericUpDown();
            this.DepthUpDown = new System.Windows.Forms.NumericUpDown();
            this.DrawersUpDown = new System.Windows.Forms.NumericUpDown();
            this.RushCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MatCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.WidthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawersUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 390);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(115, 48);
            this.Back.TabIndex = 0;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // DisplayQuoteBut
            // 
            this.DisplayQuoteBut.Location = new System.Drawing.Point(358, 390);
            this.DisplayQuoteBut.Name = "DisplayQuoteBut";
            this.DisplayQuoteBut.Size = new System.Drawing.Size(114, 48);
            this.DisplayQuoteBut.TabIndex = 1;
            this.DisplayQuoteBut.Text = "Calculate Quote";
            this.DisplayQuoteBut.UseVisualStyleBackColor = true;
            this.DisplayQuoteBut.Click += new System.EventHandler(this.DisplayQuoteBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter the width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter the depth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of drawers";
            // 
            // WidthUpDown
            // 
            this.WidthUpDown.Location = new System.Drawing.Point(147, 41);
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
            this.WidthUpDown.TabIndex = 5;
            this.WidthUpDown.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // DepthUpDown
            // 
            this.DepthUpDown.Location = new System.Drawing.Point(147, 81);
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
            this.DepthUpDown.TabIndex = 6;
            this.DepthUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // DrawersUpDown
            // 
            this.DrawersUpDown.Location = new System.Drawing.Point(147, 120);
            this.DrawersUpDown.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.DrawersUpDown.Name = "DrawersUpDown";
            this.DrawersUpDown.Size = new System.Drawing.Size(105, 20);
            this.DrawersUpDown.TabIndex = 7;
            this.DrawersUpDown.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // RushCombo
            // 
            this.RushCombo.FormattingEnabled = true;
            this.RushCombo.Location = new System.Drawing.Point(147, 199);
            this.RushCombo.Name = "RushCombo";
            this.RushCombo.Size = new System.Drawing.Size(105, 21);
            this.RushCombo.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Surface Material";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Rush options";
            // 
            // MatCombo
            // 
            this.MatCombo.FormattingEnabled = true;
            this.MatCombo.Location = new System.Drawing.Point(147, 160);
            this.MatCombo.Name = "MatCombo";
            this.MatCombo.Size = new System.Drawing.Size(105, 21);
            this.MatCombo.TabIndex = 16;
            // 
            // NewQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 450);
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
            this.Controls.Add(this.DisplayQuoteBut);
            this.Controls.Add(this.Back);
            this.Name = "NewQuote";
            this.Text = "New Quote";
            ((System.ComponentModel.ISupportInitialize)(this.WidthUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawersUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button DisplayQuoteBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown WidthUpDown;
        private System.Windows.Forms.NumericUpDown DepthUpDown;
        private System.Windows.Forms.NumericUpDown DrawersUpDown;
        private System.Windows.Forms.ComboBox RushCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox MatCombo;
    }
}