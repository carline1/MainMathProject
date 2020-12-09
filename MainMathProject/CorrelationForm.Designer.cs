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
            this.comparison_t = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.regress_func = new System.Windows.Forms.Label();
            this.show_regress = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.r2_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cor_field)).BeginInit();
            this.SuspendLayout();
            // 
            // cor_field
            // 
            this.cor_field.BackColor = System.Drawing.SystemColors.Control;
            chartArea3.BackColor = System.Drawing.SystemColors.Control;
            chartArea3.Name = "ChartArea1";
            this.cor_field.ChartAreas.Add(chartArea3);
            this.cor_field.Location = new System.Drawing.Point(369, 64);
            this.cor_field.Name = "cor_field";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Name = "point";
            this.cor_field.Series.Add(series3);
            this.cor_field.Size = new System.Drawing.Size(707, 466);
            this.cor_field.TabIndex = 0;
            this.cor_field.TabStop = false;
            this.cor_field.Text = "chart1";
            // 
            // r_label
            // 
            this.r_label.AutoSize = true;
            this.r_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.r_label.Location = new System.Drawing.Point(32, 77);
            this.r_label.Name = "r_label";
            this.r_label.Size = new System.Drawing.Size(37, 24);
            this.r_label.TabIndex = 1;
            this.r_label.Text = "r = ";
            // 
            // hyp_test
            // 
            this.hyp_test.AutoSize = true;
            this.hyp_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hyp_test.Location = new System.Drawing.Point(32, 234);
            this.hyp_test.Name = "hyp_test";
            this.hyp_test.Size = new System.Drawing.Size(165, 24);
            this.hyp_test.TabIndex = 2;
            this.hyp_test.Text = "<Наличие связи>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(579, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Диаграмма рассеивания";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(31, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Коэффициент корреляции";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(31, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(298, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Результат проверки гипотез";
            // 
            // comparison_t
            // 
            this.comparison_t.AutoSize = true;
            this.comparison_t.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comparison_t.Location = new System.Drawing.Point(32, 296);
            this.comparison_t.Name = "comparison_t";
            this.comparison_t.Size = new System.Drawing.Size(154, 24);
            this.comparison_t.TabIndex = 5;
            this.comparison_t.Text = "<t табл и t набл>";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(31, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Уравнение регрессии";
            // 
            // regress_func
            // 
            this.regress_func.AutoSize = true;
            this.regress_func.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regress_func.Location = new System.Drawing.Point(32, 400);
            this.regress_func.Name = "regress_func";
            this.regress_func.Size = new System.Drawing.Size(172, 24);
            this.regress_func.TabIndex = 6;
            this.regress_func.Text = "<Ур-е регрессии>";
            // 
            // show_regress
            // 
            this.show_regress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show_regress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.show_regress.Location = new System.Drawing.Point(36, 462);
            this.show_regress.Name = "show_regress";
            this.show_regress.Size = new System.Drawing.Size(241, 47);
            this.show_regress.TabIndex = 7;
            this.show_regress.Text = "Посмотреть графики регрессии и остатков";
            this.show_regress.UseVisualStyleBackColor = true;
            this.show_regress.Click += new System.EventHandler(this.show_regress_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(385, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(735, 505);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "X";
            // 
            // r2_label
            // 
            this.r2_label.AutoSize = true;
            this.r2_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.r2_label.Location = new System.Drawing.Point(32, 154);
            this.r2_label.Name = "r2_label";
            this.r2_label.Size = new System.Drawing.Size(56, 24);
            this.r2_label.TabIndex = 1;
            this.r2_label.Text = "r^2 = ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(31, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(304, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Коэффициент детерминации";
            // 
            // CorrelationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 542);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.show_regress);
            this.Controls.Add(this.regress_func);
            this.Controls.Add(this.comparison_t);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hyp_test);
            this.Controls.Add(this.r2_label);
            this.Controls.Add(this.r_label);
            this.Controls.Add(this.cor_field);
            this.Name = "CorrelationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Корреляция";
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
        private System.Windows.Forms.Label comparison_t;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label regress_func;
        private System.Windows.Forms.Button show_regress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label r2_label;
        private System.Windows.Forms.Label label7;
    }
}