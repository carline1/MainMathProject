namespace MainMathProject
{
    partial class CorrelationForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cor_field = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.r_label = new System.Windows.Forms.Label();
            this.hyp_test = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cor_field)).BeginInit();
            this.SuspendLayout();
            // 
            // cor_field
            // 
            this.cor_field.BackColor = System.Drawing.SystemColors.Control;
            chartArea3.Name = "ChartArea1";
            this.cor_field.ChartAreas.Add(chartArea3);
            this.cor_field.Location = new System.Drawing.Point(369, 64);
            this.cor_field.Name = "cor_field";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Name = "point";
            this.cor_field.Series.Add(series3);
            this.cor_field.Size = new System.Drawing.Size(707, 428);
            this.cor_field.TabIndex = 0;
            this.cor_field.Text = "chart1";
            // 
            // r_label
            // 
            this.r_label.AutoSize = true;
            this.r_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.r_label.Location = new System.Drawing.Point(42, 83);
            this.r_label.Name = "r_label";
            this.r_label.Size = new System.Drawing.Size(37, 24);
            this.r_label.TabIndex = 1;
            this.r_label.Text = "r = ";
            // 
            // hyp_test
            // 
            this.hyp_test.AutoSize = true;
            this.hyp_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hyp_test.Location = new System.Drawing.Point(42, 179);
            this.hyp_test.Name = "hyp_test";
            this.hyp_test.Size = new System.Drawing.Size(165, 24);
            this.hyp_test.TabIndex = 2;
            this.hyp_test.Text = "<Наличие связи>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(620, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Поле корреляции";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(41, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Коэффициент корреляции";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(41, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Проверка гипотез";
            // 
            // CorrelationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 504);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hyp_test);
            this.Controls.Add(this.r_label);
            this.Controls.Add(this.cor_field);
            this.Name = "CorrelationForm";
            this.Text = "Correlation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SetForm_Closed);
            ((System.ComponentModel.ISupportInitialize)(this.cor_field)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart cor_field;
        private System.Windows.Forms.Label r_label;
        private System.Windows.Forms.Label hyp_test;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}