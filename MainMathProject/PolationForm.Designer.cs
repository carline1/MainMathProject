﻿namespace MainMathProject
{
    partial class PolationForm
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
            this.pol_text = new System.Windows.Forms.Label();
            this.pol_value = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exist_val_text = new System.Windows.Forms.Label();
            this.exist_val = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pol_text
            // 
            this.pol_text.AutoSize = true;
            this.pol_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pol_text.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pol_text.Location = new System.Drawing.Point(167, 29);
            this.pol_text.Name = "pol_text";
            this.pol_text.Size = new System.Drawing.Size(99, 24);
            this.pol_text.TabIndex = 0;
            this.pol_text.Text = "...поляция";
            // 
            // pol_value
            // 
            this.pol_value.AutoSize = true;
            this.pol_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pol_value.Location = new System.Drawing.Point(60, 108);
            this.pol_value.Name = "pol_value";
            this.pol_value.Size = new System.Drawing.Size(206, 24);
            this.pol_value.TabIndex = 1;
            this.pol_value.Text = "[   ;   ] с надежность ...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(111, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Доверительный интервал:";
            // 
            // exist_val_text
            // 
            this.exist_val_text.AutoSize = true;
            this.exist_val_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exist_val_text.Location = new System.Drawing.Point(12, 5);
            this.exist_val_text.Name = "exist_val_text";
            this.exist_val_text.Size = new System.Drawing.Size(366, 24);
            this.exist_val_text.TabIndex = 2;
            this.exist_val_text.Text = "Значение уже есть во входных данных";
            // 
            // exist_val
            // 
            this.exist_val.AutoSize = true;
            this.exist_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exist_val.Location = new System.Drawing.Point(12, 29);
            this.exist_val.Name = "exist_val";
            this.exist_val.Size = new System.Drawing.Size(60, 24);
            this.exist_val.TabIndex = 2;
            this.exist_val.Text = "y[x] = ";
            // 
            // PolationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 162);
            this.Controls.Add(this.exist_val);
            this.Controls.Add(this.exist_val_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pol_value);
            this.Controls.Add(this.pol_text);
            this.Name = "PolationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PolationForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SetForm_Closed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pol_text;
        private System.Windows.Forms.Label pol_value;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label exist_val_text;
        private System.Windows.Forms.Label exist_val;
    }
}