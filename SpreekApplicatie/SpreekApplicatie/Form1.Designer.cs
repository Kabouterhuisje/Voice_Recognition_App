namespace SpreekApplicatie
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
            this.btnRead = new System.Windows.Forms.Button();
            this.btnInport = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.rtxtInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(432, 12);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(113, 23);
            this.btnRead.TabIndex = 6;
            this.btnRead.Text = "Read Text";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnInport
            // 
            this.btnInport.Location = new System.Drawing.Point(433, 42);
            this.btnInport.Name = "btnInport";
            this.btnInport.Size = new System.Drawing.Size(112, 23);
            this.btnInport.TabIndex = 7;
            this.btnInport.Text = "Start Inport";
            this.btnInport.UseVisualStyleBackColor = true;
            this.btnInport.Click += new System.EventHandler(this.btnInport_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(432, 72);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(113, 23);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "Stop Inport";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // rtxtInput
            // 
            this.rtxtInput.Location = new System.Drawing.Point(13, 13);
            this.rtxtInput.Multiline = true;
            this.rtxtInput.Name = "rtxtInput";
            this.rtxtInput.Size = new System.Drawing.Size(413, 350);
            this.rtxtInput.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 375);
            this.Controls.Add(this.rtxtInput);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnInport);
            this.Controls.Add(this.btnRead);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnInport;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox rtxtInput;
    }
}

