namespace MainMathProject
{
    partial class InputNForm
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
            this.n_quant = new System.Windows.Forms.Button();
            this.n_text = new System.Windows.Forms.TextBox();
            this.n_lable = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.error_outside = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // n_quant
            // 
            this.n_quant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.n_quant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.n_quant.Location = new System.Drawing.Point(147, 83);
            this.n_quant.Name = "n_quant";
            this.n_quant.Size = new System.Drawing.Size(82, 29);
            this.n_quant.TabIndex = 6;
            this.n_quant.Text = "Далее";
            this.n_quant.UseVisualStyleBackColor = true;
            this.n_quant.Click += new System.EventHandler(this.n_quant_Click);
            // 
            // n_text
            // 
            this.n_text.Location = new System.Drawing.Point(185, 40);
            this.n_text.Name = "n_text";
            this.n_text.Size = new System.Drawing.Size(100, 20);
            this.n_text.TabIndex = 5;
            // 
            // n_lable
            // 
            this.n_lable.AutoSize = true;
            this.n_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.n_lable.Location = new System.Drawing.Point(75, 35);
            this.n_lable.Name = "n_lable";
            this.n_lable.Size = new System.Drawing.Size(104, 24);
            this.n_lable.TabIndex = 4;
            this.n_lable.Text = "Введите n";
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(158, 117);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(62, 15);
            this.error.TabIndex = 7;
            this.error.Text = "Ошибка!";
            // 
            // error_outside
            // 
            this.error_outside.AutoSize = true;
            this.error_outside.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.error_outside.ForeColor = System.Drawing.Color.Red;
            this.error_outside.Location = new System.Drawing.Point(217, 119);
            this.error_outside.Name = "error_outside";
            this.error_outside.Size = new System.Drawing.Size(167, 13);
            this.error_outside.TabIndex = 8;
            this.error_outside.Text = "Ошибка! Макс. знач. = 374";
            // 
            // InputNForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 141);
            this.Controls.Add(this.error_outside);
            this.Controls.Add(this.error);
            this.Controls.Add(this.n_quant);
            this.Controls.Add(this.n_text);
            this.Controls.Add(this.n_lable);
            this.Name = "InputNForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ввод N";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SetForm_Closed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button n_quant;
        private System.Windows.Forms.TextBox n_text;
        private System.Windows.Forms.Label n_lable;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Label error_outside;
    }
}