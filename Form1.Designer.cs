using System;

namespace Pixels
{
    partial class Form1
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.drawBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.drawPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Items.AddRange(new object[] {"Fill", "Checkerbox(5x5)", "Checkerbox(50x50)", "Noise"});
            this.listBox.Location = new System.Drawing.Point(12, 12);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(200, 56);
            this.listBox.TabIndex = 0;
            // 
            // drawBtn
            // 
            this.drawBtn.Location = new System.Drawing.Point(12, 74);
            this.drawBtn.Name = "drawBtn";
            this.drawBtn.Size = new System.Drawing.Size(200, 24);
            this.drawBtn.TabIndex = 1;
            this.drawBtn.Text = "draw";
            this.drawBtn.UseVisualStyleBackColor = true;
            this.drawBtn.Click += new System.EventHandler(this.drawBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(12, 414);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(200, 24);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // drawPanel
            // 
            this.drawPanel.Location = new System.Drawing.Point(218, 12);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(570, 426);
            this.drawPanel.TabIndex = 3;
            this.drawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawPanel_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.drawPanel);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.drawBtn);
            this.Controls.Add(this.listBox);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button drawBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Panel drawPanel;

        private System.Windows.Forms.ListBox listBox;

        #endregion
    }
}