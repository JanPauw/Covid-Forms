
namespace frmCovid
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.edtInput = new System.Windows.Forms.TextBox();
            this.btnJanClicked = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // edtInput
            // 
            this.edtInput.Location = new System.Drawing.Point(118, 61);
            this.edtInput.Name = "edtInput";
            this.edtInput.Size = new System.Drawing.Size(116, 23);
            this.edtInput.TabIndex = 0;
            // 
            // btnJanClicked
            // 
            this.btnJanClicked.Location = new System.Drawing.Point(118, 90);
            this.btnJanClicked.Name = "btnJanClicked";
            this.btnJanClicked.Size = new System.Drawing.Size(116, 23);
            this.btnJanClicked.TabIndex = 1;
            this.btnJanClicked.Text = "Jan Clicked This";
            this.btnJanClicked.UseVisualStyleBackColor = true;
            this.btnJanClicked.Click += new System.EventHandler(this.btnJanClicked_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(118, 120);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 15);
            this.lblOutput.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnJanClicked);
            this.Controls.Add(this.edtInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edtInput;
        private System.Windows.Forms.Button btnJanClicked;
        private System.Windows.Forms.Label lblOutput;
    }
}

