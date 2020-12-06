namespace MainMathProject
{
    partial class InputXForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.x_lable = new System.Windows.Forms.Label();
            this.x_text = new System.Windows.Forms.TextBox();
            this.x_add = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.success = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // x_lable
            // 
            this.x_lable.AutoSize = true;
            this.x_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x_lable.Location = new System.Drawing.Point(60, 35);
            this.x_lable.Name = "x_lable";
            this.x_lable.Size = new System.Drawing.Size(123, 24);
            this.x_lable.TabIndex = 0;
            this.x_lable.Text = "Введите x[1]";
            // 
            // x_text
            // 
            this.x_text.Location = new System.Drawing.Point(220, 40);
            this.x_text.Name = "x_text";
            this.x_text.Size = new System.Drawing.Size(100, 20);
            this.x_text.TabIndex = 1;
            // 
            // x_add
            // 
            this.x_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.x_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x_add.Location = new System.Drawing.Point(175, 82);
            this.x_add.Name = "x_add";
            this.x_add.Size = new System.Drawing.Size(100, 29);
            this.x_add.TabIndex = 3;
            this.x_add.Text = "Добавить X";
            this.x_add.UseVisualStyleBackColor = true;
            this.x_add.Click += new System.EventHandler(this.x_add_Click);
            // 
            // back
            // 
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.Location = new System.Drawing.Point(107, 83);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(62, 28);
            this.back.TabIndex = 4;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // success
            // 
            this.success.Cursor = System.Windows.Forms.Cursors.Hand;
            this.success.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.success.Location = new System.Drawing.Point(281, 83);
            this.success.Name = "success";
            this.success.Size = new System.Drawing.Size(100, 29);
            this.success.TabIndex = 5;
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
            this.error.TabIndex = 8;
            this.error.Text = "Ошибка!";
            // 
            // InputXForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 141);
            this.Controls.Add(this.error);
            this.Controls.Add(this.success);
            this.Controls.Add(this.back);
            this.Controls.Add(this.x_add);
            this.Controls.Add(this.x_text);
            this.Controls.Add(this.x_lable);
            this.Name = "InputXForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ввод X";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SetForm_Closed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label x_lable;
        private System.Windows.Forms.TextBox x_text;
        private System.Windows.Forms.Button x_add;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button success;
        private System.Windows.Forms.Label error;
    }
}

