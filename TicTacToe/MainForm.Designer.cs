namespace TicTacToe
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cell_20 = new System.Windows.Forms.Button();
            this.Cell_10 = new System.Windows.Forms.Button();
            this.Cell_00 = new System.Windows.Forms.Button();
            this.Cell_21 = new System.Windows.Forms.Button();
            this.Cell_11 = new System.Windows.Forms.Button();
            this.Cell_01 = new System.Windows.Forms.Button();
            this.Cell_22 = new System.Windows.Forms.Button();
            this.Cell_12 = new System.Windows.Forms.Button();
            this.Cell_02 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Cell_20);
            this.panel1.Controls.Add(this.Cell_10);
            this.panel1.Controls.Add(this.Cell_00);
            this.panel1.Controls.Add(this.Cell_21);
            this.panel1.Controls.Add(this.Cell_11);
            this.panel1.Controls.Add(this.Cell_01);
            this.panel1.Controls.Add(this.Cell_22);
            this.panel1.Controls.Add(this.Cell_12);
            this.panel1.Controls.Add(this.Cell_02);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 230);
            this.panel1.TabIndex = 0;
            // 
            // Cell_20
            // 
            this.Cell_20.Location = new System.Drawing.Point(149, 152);
            this.Cell_20.Name = "Cell_20";
            this.Cell_20.Size = new System.Drawing.Size(75, 77);
            this.Cell_20.TabIndex = 8;
            this.Cell_20.UseVisualStyleBackColor = true;
            this.Cell_20.Click += new System.EventHandler(this.HandleAction);
            // 
            // Cell_10
            // 
            this.Cell_10.Location = new System.Drawing.Point(75, 152);
            this.Cell_10.Name = "Cell_10";
            this.Cell_10.Size = new System.Drawing.Size(75, 77);
            this.Cell_10.TabIndex = 7;
            this.Cell_10.UseVisualStyleBackColor = true;
            this.Cell_10.Click += new System.EventHandler(this.HandleAction);
            // 
            // Cell_00
            // 
            this.Cell_00.Location = new System.Drawing.Point(1, 152);
            this.Cell_00.Name = "Cell_00";
            this.Cell_00.Size = new System.Drawing.Size(75, 77);
            this.Cell_00.TabIndex = 6;
            this.Cell_00.UseVisualStyleBackColor = true;
            this.Cell_00.Click += new System.EventHandler(this.HandleAction);
            // 
            // Cell_21
            // 
            this.Cell_21.Location = new System.Drawing.Point(149, 76);
            this.Cell_21.Name = "Cell_21";
            this.Cell_21.Size = new System.Drawing.Size(75, 77);
            this.Cell_21.TabIndex = 5;
            this.Cell_21.UseVisualStyleBackColor = true;
            this.Cell_21.Click += new System.EventHandler(this.HandleAction);
            // 
            // Cell_11
            // 
            this.Cell_11.Location = new System.Drawing.Point(75, 76);
            this.Cell_11.Name = "Cell_11";
            this.Cell_11.Size = new System.Drawing.Size(75, 77);
            this.Cell_11.TabIndex = 4;
            this.Cell_11.UseVisualStyleBackColor = true;
            this.Cell_11.Click += new System.EventHandler(this.HandleAction);
            // 
            // Cell_01
            // 
            this.Cell_01.Location = new System.Drawing.Point(1, 76);
            this.Cell_01.Name = "Cell_01";
            this.Cell_01.Size = new System.Drawing.Size(75, 77);
            this.Cell_01.TabIndex = 3;
            this.Cell_01.UseVisualStyleBackColor = true;
            this.Cell_01.Click += new System.EventHandler(this.HandleAction);
            // 
            // Cell_22
            // 
            this.Cell_22.Location = new System.Drawing.Point(148, 0);
            this.Cell_22.Name = "Cell_22";
            this.Cell_22.Size = new System.Drawing.Size(75, 77);
            this.Cell_22.TabIndex = 2;
            this.Cell_22.UseVisualStyleBackColor = true;
            this.Cell_22.Click += new System.EventHandler(this.HandleAction);
            // 
            // Cell_12
            // 
            this.Cell_12.Location = new System.Drawing.Point(74, 0);
            this.Cell_12.Name = "Cell_12";
            this.Cell_12.Size = new System.Drawing.Size(75, 77);
            this.Cell_12.TabIndex = 1;
            this.Cell_12.UseVisualStyleBackColor = true;
            this.Cell_12.Click += new System.EventHandler(this.HandleAction);
            // 
            // Cell_02
            // 
            this.Cell_02.Location = new System.Drawing.Point(0, 0);
            this.Cell_02.Name = "Cell_02";
            this.Cell_02.Size = new System.Drawing.Size(75, 77);
            this.Cell_02.TabIndex = 0;
            this.Cell_02.UseVisualStyleBackColor = true;
            this.Cell_02.Click += new System.EventHandler(this.HandleAction);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 234);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Cell_20;
        private System.Windows.Forms.Button Cell_10;
        private System.Windows.Forms.Button Cell_00;
        private System.Windows.Forms.Button Cell_21;
        private System.Windows.Forms.Button Cell_11;
        private System.Windows.Forms.Button Cell_01;
        private System.Windows.Forms.Button Cell_22;
        private System.Windows.Forms.Button Cell_12;
        private System.Windows.Forms.Button Cell_02;
    }
}

