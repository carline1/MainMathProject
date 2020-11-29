namespace MainMathProject
{
    partial class ReliabilityForm
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
            this.rel95 = new System.Windows.Forms.Button();
            this.rel99 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rel95
            // 
            this.rel95.Location = new System.Drawing.Point(100, 80);
            this.rel95.Name = "rel95";
            this.rel95.Size = new System.Drawing.Size(90, 40);
            this.rel95.TabIndex = 0;
            this.rel95.Text = "0.05";
            this.rel95.UseVisualStyleBackColor = true;
            this.rel95.Click += new System.EventHandler(this.rel95_Click);
            // 
            // rel99
            // 
            this.rel99.Location = new System.Drawing.Point(196, 80);
            this.rel99.Name = "rel99";
            this.rel99.Size = new System.Drawing.Size(90, 40);
            this.rel99.TabIndex = 1;
            this.rel99.Text = "0.01";
            this.rel99.UseVisualStyleBackColor = true;
            this.rel99.Click += new System.EventHandler(this.rel99_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(90, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите надежность";
            // 
            // ReliabilityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 141);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rel99);
            this.Controls.Add(this.rel95);
            this.Name = "ReliabilityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SetForm_Closed);
            this.Text = "Выбор надежности";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rel95;
        private System.Windows.Forms.Button rel99;
        private System.Windows.Forms.Label label1;
    }
}