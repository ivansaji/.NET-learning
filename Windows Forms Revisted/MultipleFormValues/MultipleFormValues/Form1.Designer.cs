namespace MultipleFormValues
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
            this.txtChangeCase = new System.Windows.Forms.TextBox();
            this.changeCase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtChangeCase
            // 
            this.txtChangeCase.Location = new System.Drawing.Point(158, 85);
            this.txtChangeCase.Name = "txtChangeCase";
            this.txtChangeCase.Size = new System.Drawing.Size(303, 20);
            this.txtChangeCase.TabIndex = 0;
            this.txtChangeCase.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // changeCase
            // 
            this.changeCase.Location = new System.Drawing.Point(158, 157);
            this.changeCase.Name = "changeCase";
            this.changeCase.Size = new System.Drawing.Size(75, 23);
            this.changeCase.TabIndex = 1;
            this.changeCase.Text = "changeCase";
            this.changeCase.UseVisualStyleBackColor = true;
            this.changeCase.Click += new System.EventHandler(this.changeCase_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.changeCase);
            this.Controls.Add(this.txtChangeCase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtChangeCase;
        private System.Windows.Forms.Button changeCase;
    }
}

