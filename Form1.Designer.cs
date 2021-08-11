
namespace Lab_3
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblDays = new System.Windows.Forms.Label();
            this.txtRegion1 = new System.Windows.Forms.TextBox();
            this.lblResult1 = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResult2 = new System.Windows.Forms.Label();
            this.lblResult3 = new System.Windows.Forms.Label();
            this.txtRegion2 = new System.Windows.Forms.TextBox();
            this.txtRegion3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cases";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(153, 29);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(132, 27);
            this.txtInput.TabIndex = 1;
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(68, 71);
            this.lblDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(68, 20);
            this.lblDays.TabIndex = 2;
            this.lblDays.Text = "Region 1";
            // 
            // txtRegion1
            // 
            this.txtRegion1.Location = new System.Drawing.Point(45, 105);
            this.txtRegion1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRegion1.Multiline = true;
            this.txtRegion1.Name = "txtRegion1";
            this.txtRegion1.Size = new System.Drawing.Size(126, 227);
            this.txtRegion1.TabIndex = 5;
            this.txtRegion1.TextChanged += new System.EventHandler(this.txtCases_TextChanged);
            // 
            // lblResult1
            // 
            this.lblResult1.AutoSize = true;
            this.lblResult1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult1.Location = new System.Drawing.Point(45, 352);
            this.lblResult1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult1.MinimumSize = new System.Drawing.Size(126, 46);
            this.lblResult1.Name = "lblResult1";
            this.lblResult1.Size = new System.Drawing.Size(126, 46);
            this.lblResult1.TabIndex = 8;
            this.lblResult1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(45, 418);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(100, 35);
            this.btnEnter.TabIndex = 11;
            this.btnEnter.Text = "&Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(185, 418);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 35);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(319, 418);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 35);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Region 2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Region 3";
            // 
            // lblResult2
            // 
            this.lblResult2.AutoSize = true;
            this.lblResult2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult2.Location = new System.Drawing.Point(185, 352);
            this.lblResult2.MinimumSize = new System.Drawing.Size(126, 46);
            this.lblResult2.Name = "lblResult2";
            this.lblResult2.Size = new System.Drawing.Size(126, 46);
            this.lblResult2.TabIndex = 9;
            this.lblResult2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResult3
            // 
            this.lblResult3.AutoSize = true;
            this.lblResult3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult3.Location = new System.Drawing.Point(319, 352);
            this.lblResult3.MinimumSize = new System.Drawing.Size(126, 46);
            this.lblResult3.Name = "lblResult3";
            this.lblResult3.Size = new System.Drawing.Size(126, 46);
            this.lblResult3.TabIndex = 10;
            this.lblResult3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRegion2
            // 
            this.txtRegion2.Location = new System.Drawing.Point(185, 105);
            this.txtRegion2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRegion2.Multiline = true;
            this.txtRegion2.Name = "txtRegion2";
            this.txtRegion2.Size = new System.Drawing.Size(126, 227);
            this.txtRegion2.TabIndex = 6;
            // 
            // txtRegion3
            // 
            this.txtRegion3.Location = new System.Drawing.Point(319, 105);
            this.txtRegion3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRegion3.Multiline = true;
            this.txtRegion3.Name = "txtRegion3";
            this.txtRegion3.Size = new System.Drawing.Size(126, 227);
            this.txtRegion3.TabIndex = 7;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(485, 472);
            this.Controls.Add(this.txtRegion3);
            this.Controls.Add(this.txtRegion2);
            this.Controls.Add(this.lblResult3);
            this.Controls.Add(this.lblResult2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblResult1);
            this.Controls.Add(this.txtRegion1);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Average Weekly Units by Region";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.TextBox txtRegion1;
        private System.Windows.Forms.Label lblResult1;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResult2;
        private System.Windows.Forms.Label lblResult3;
        private System.Windows.Forms.TextBox txtRegion2;
        private System.Windows.Forms.TextBox txtRegion3;
    }
}

