namespace MainMathProject
{
    partial class DialogPolationForm
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
            this.polation_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.polation_text = new System.Windows.Forms.TextBox();
            this.rel95 = new System.Windows.Forms.RadioButton();
            this.rel99 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // polation_button
            // 
            this.polation_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.polation_button.Location = new System.Drawing.Point(115, 185);
            this.polation_button.Name = "polation_button";
            this.polation_button.Size = new System.Drawing.Size(178, 48);
            this.polation_button.TabIndex = 0;
            this.polation_button.Text = "Рассчитать";
            this.polation_button.UseVisualStyleBackColor = true;
            this.polation_button.Click += new System.EventHandler(this.interpolation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите значение для прогнозирования";
            // 
            // polation_text
            // 
            this.polation_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.polation_text.Location = new System.Drawing.Point(141, 57);
            this.polation_text.Name = "polation_text";
            this.polation_text.Size = new System.Drawing.Size(127, 22);
            this.polation_text.TabIndex = 2;
            // 
            // rel95
            // 
            this.rel95.AutoSize = true;
            this.rel95.Checked = true;
            this.rel95.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rel95.Location = new System.Drawing.Point(141, 136);
            this.rel95.Name = "rel95";
            this.rel95.Size = new System.Drawing.Size(50, 20);
            this.rel95.TabIndex = 3;
            this.rel95.TabStop = true;
            this.rel95.Text = "0.05";
            this.rel95.UseVisualStyleBackColor = true;
            // 
            // rel99
            // 
            this.rel99.AutoSize = true;
            this.rel99.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rel99.Location = new System.Drawing.Point(218, 136);
            this.rel99.Name = "rel99";
            this.rel99.Size = new System.Drawing.Size(50, 20);
            this.rel99.TabIndex = 3;
            this.rel99.Text = "0.01";
            this.rel99.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(95, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выберите надежность";
            // 
            // DialogPolationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 259);
            this.Controls.Add(this.rel99);
            this.Controls.Add(this.rel95);
            this.Controls.Add(this.polation_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.polation_button);
            this.Name = "DialogPolationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ввод данных для прогнозирования";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SetForm_Closed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button polation_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rel95;
        private System.Windows.Forms.RadioButton rel99;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox polation_text;
    }
}