﻿namespace HelloWorld
{
    partial class frmHelloWorld
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnHelloWorld = new System.Windows.Forms.Button();
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 89);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHelloWorld
            // 
            this.btnHelloWorld.Location = new System.Drawing.Point(297, 372);
            this.btnHelloWorld.Name = "btnHelloWorld";
            this.btnHelloWorld.Size = new System.Drawing.Size(110, 24);
            this.btnHelloWorld.TabIndex = 1;
            this.btnHelloWorld.Text = "ShowHelloWorld";
            this.btnHelloWorld.UseVisualStyleBackColor = true;
            this.btnHelloWorld.Click += new System.EventHandler(this.btnHelloWorld_Click);
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.AutoSize = true;
            this.lblHelloWorld.Font = new System.Drawing.Font("Lucida Sans Unicode", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloWorld.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblHelloWorld.Location = new System.Drawing.Point(97, 114);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblHelloWorld.Size = new System.Drawing.Size(0, 59);
            this.lblHelloWorld.TabIndex = 0;
            this.lblHelloWorld.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmHelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(734, 408);
            this.Controls.Add(this.btnHelloWorld);
            this.Controls.Add(this.lblHelloWorld);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(90, 45);
            this.MaximumSize = new System.Drawing.Size(1000, 450);
            this.MinimumSize = new System.Drawing.Size(400, 350);
            this.Name = "frmHelloWorld";
            this.Text = "HelloWorld";
            this.Load += new System.EventHandler(this.frmHelloWorld_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHelloWorld;
        private System.Windows.Forms.Label lblHelloWorld;
    }
}

