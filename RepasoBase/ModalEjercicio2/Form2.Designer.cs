namespace ModalEjercicio2
{
    partial class Form2
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1_public = new System.Windows.Forms.TextBox();
            this.textBox2_public = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(256, 123);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2_cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(24, 125);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1_ok";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1_public
            // 
            this.textBox1_public.Location = new System.Drawing.Point(108, 18);
            this.textBox1_public.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1_public.Name = "textBox1_public";
            this.textBox1_public.Size = new System.Drawing.Size(178, 26);
            this.textBox1_public.TabIndex = 6;
            this.textBox1_public.Text = "textBox1_public";
            // 
            // textBox2_public
            // 
            this.textBox2_public.Location = new System.Drawing.Point(108, 54);
            this.textBox2_public.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2_public.Name = "textBox2_public";
            this.textBox2_public.Size = new System.Drawing.Size(178, 26);
            this.textBox2_public.TabIndex = 9;
            this.textBox2_public.Text = "textBox2_public";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(110, 93);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(156, 24);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "checkBox1_public";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 169);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox2_public);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1_public);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox textBox1_public;
        public System.Windows.Forms.TextBox textBox2_public;
        public System.Windows.Forms.CheckBox checkBox1;
    }
}