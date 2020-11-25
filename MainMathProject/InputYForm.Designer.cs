namespace MainMathProject
{
    partial class InputYForm
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
            this.y_text = new System.Windows.Forms.TextBox();
            this.y_lable = new System.Windows.Forms.Label();
            this.y_add = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.success = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // y_text
            // 
            this.y_text.Location = new System.Drawing.Point(220, 40);
            this.y_text.Name = "y_text";
            this.y_text.Size = new System.Drawing.Size(100, 20);
            this.y_text.TabIndex = 4;
            // 
            // y_lable
            // 
            this.y_lable.AutoSize = true;
            this.y_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.y_lable.Location = new System.Drawing.Point(60, 35);
            this.y_lable.Name = "y_lable";
            this.y_lable.Size = new System.Drawing.Size(122, 24);
            this.y_lable.TabIndex = 3;
            this.y_lable.Text = "Введите y[1]";
            // 
            // y_add
            // 
            this.y_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.y_add.Location = new System.Drawing.Point(175, 82);
            this.y_add.Name = "y_add";
            this.y_add.Size = new System.Drawing.Size(100, 29);
            this.y_add.TabIndex = 6;
            this.y_add.Text = "Добавить Y";
            this.y_add.UseVisualStyleBackColor = true;
            this.y_add.Click += new System.EventHandler(this.y_add_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.Location = new System.Drawing.Point(107, 83);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(62, 28);
            this.back.TabIndex = 7;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // success
            // 
            this.success.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.success.Location = new System.Drawing.Point(281, 83);
            this.success.Name = "success";
            this.success.Size = new System.Drawing.Size(100, 29);
            this.success.TabIndex = 8;
            this.success.Text = "Готово";
            this.success.UseVisualStyleBackColor = true;
            this.success.Click += new System.EventHandler(this.success_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(155, 117);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(62, 15);
            this.error.TabIndex = 9;
            this.error.Text = "Ошибка!";
            // 
            // InputY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 141);
            this.Controls.Add(this.error);
            this.Controls.Add(this.success);
            this.Controls.Add(this.back);
            this.Controls.Add(this.y_add);
            this.Controls.Add(this.y_text);
            this.Controls.Add(this.y_lable);
            this.Name = "InputY";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ввод Y";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SetForm_Closed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox y_text;
        private System.Windows.Forms.Label y_lable;
        private System.Windows.Forms.Button y_add;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button success;
        private System.Windows.Forms.Label error;
    }
}