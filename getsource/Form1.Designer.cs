namespace getsource
{
    partial class grtsource
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
            this.url = new System.Windows.Forms.Label();
            this.btn_gets = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // url
            // 
            this.url.AutoSize = true;
            this.url.Location = new System.Drawing.Point(23, 226);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(36, 17);
            this.url.TabIndex = 0;
            this.url.Text = "URL";
            // 
            // btn_gets
            // 
            this.btn_gets.Location = new System.Drawing.Point(65, 126);
            this.btn_gets.Name = "btn_gets";
            this.btn_gets.Size = new System.Drawing.Size(103, 46);
            this.btn_gets.TabIndex = 1;
            this.btn_gets.Text = "get source !";
            this.btn_gets.UseVisualStyleBackColor = true;
            this.btn_gets.Click += new System.EventHandler(this.btn_gets_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(253, 7);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(334, 431);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(65, 226);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(182, 22);
            this.txt_url.TabIndex = 3;
            // 
            // grtsource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 450);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_gets);
            this.Controls.Add(this.url);
            this.Name = "grtsource";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "get source [ Kong12384ab ]";
            this.Load += new System.EventHandler(this.grtsource_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label url;
        private System.Windows.Forms.Button btn_gets;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txt_url;
    }
}

