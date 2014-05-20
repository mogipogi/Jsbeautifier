namespace JSBeautifierGUI
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
            this.rtbInput = new System.Windows.Forms.RichTextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbInput
            // 
            this.rtbInput.Location = new System.Drawing.Point(13, 13);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(460, 429);
            this.rtbInput.TabIndex = 0;
            this.rtbInput.Text = "";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(480, 418);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(57, 23);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 454);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.rtbInput);
            this.Name = "Form1";
            this.Text = "JSBeautifier";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.Button btnGo;
    }
}

