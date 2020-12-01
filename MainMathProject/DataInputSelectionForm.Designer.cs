namespace MainMathProject
{
    partial class DataInputSelectionForm
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
            this.x_lable = new System.Windows.Forms.Label();
            this.hand_input = new System.Windows.Forms.Button();
            this.open_file = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // x_lable
            // 
            this.x_lable.AutoSize = true;
            this.x_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x_lable.Location = new System.Drawing.Point(40, 10);
            this.x_lable.Name = "x_lable";
            this.x_lable.Size = new System.Drawing.Size(301, 24);
            this.x_lable.TabIndex = 1;
            this.x_lable.Text = "Выберите способ ввода данных";
            // 
            // hand_input
            // 
            this.hand_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hand_input.Location = new System.Drawing.Point(100, 45);
            this.hand_input.Name = "hand_input";
            this.hand_input.Size = new System.Drawing.Size(170, 35);
            this.hand_input.TabIndex = 2;
            this.hand_input.Text = "Ввести вручную";
            this.hand_input.UseVisualStyleBackColor = true;
            this.hand_input.Click += new System.EventHandler(this.hand_input_Click);
            // 
            // open_file
            // 
            this.open_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.open_file.Location = new System.Drawing.Point(100, 90);
            this.open_file.Name = "open_file";
            this.open_file.Size = new System.Drawing.Size(170, 35);
            this.open_file.TabIndex = 2;
            this.open_file.Text = "Загрузить из файла";
            this.open_file.UseVisualStyleBackColor = true;
            this.open_file.Click += new System.EventHandler(this.open_file_Click);
            // 
            // DataInputSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 141);
            this.Controls.Add(this.open_file);
            this.Controls.Add(this.hand_input);
            this.Controls.Add(this.x_lable);
            this.Name = "DataInputSelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор способа ввода данных";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SetForm_Closed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label x_lable;
        private System.Windows.Forms.Button hand_input;
        private System.Windows.Forms.Button open_file;
    }
}