namespace MainMathProject
{
    partial class ShowRegressForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.regress = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.residuals = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gist_residuals = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.qq_plot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.regress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.residuals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gist_residuals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qq_plot)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(396, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регрессионная модель";
            // 
            // regress
            // 
            this.regress.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.regress.ChartAreas.Add(chartArea1);
            this.regress.Location = new System.Drawing.Point(1, 37);
            this.regress.Name = "regress";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.MarkerColor = System.Drawing.SystemColors.InactiveBorder;
            series1.Name = "reg";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Color = System.Drawing.Color.DodgerBlue;
            series2.MarkerColor = System.Drawing.SystemColors.HotTrack;
            series2.MarkerSize = 6;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "cor";
            this.regress.Series.Add(series1);
            this.regress.Series.Add(series2);
            this.regress.Size = new System.Drawing.Size(975, 410);
            this.regress.TabIndex = 1;
            this.regress.Text = "char1";
            // 
            // residuals
            // 
            this.residuals.BackColor = System.Drawing.SystemColors.Control;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.BackColor = System.Drawing.SystemColors.Control;
            chartArea2.Name = "ChartArea1";
            this.residuals.ChartAreas.Add(chartArea2);
            this.residuals.Location = new System.Drawing.Point(33, 453);
            this.residuals.Name = "residuals";
            series3.BorderColor = System.Drawing.SystemColors.HotTrack;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.MarkerColor = System.Drawing.SystemColors.HotTrack;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series3.Name = "res";
            this.residuals.Series.Add(series3);
            this.residuals.Size = new System.Drawing.Size(322, 183);
            this.residuals.TabIndex = 1;
            this.residuals.Text = "char1";
            // 
            // gist_residuals
            // 
            this.gist_residuals.BackColor = System.Drawing.SystemColors.Control;
            chartArea3.BackColor = System.Drawing.SystemColors.Control;
            chartArea3.Name = "ChartArea1";
            this.gist_residuals.ChartAreas.Add(chartArea3);
            this.gist_residuals.Location = new System.Drawing.Point(345, 453);
            this.gist_residuals.Name = "gist_residuals";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Name = "reg";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series5.MarkerColor = System.Drawing.Color.Red;
            series5.MarkerSize = 6;
            series5.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series5.Name = "cor";
            this.gist_residuals.Series.Add(series4);
            this.gist_residuals.Series.Add(series5);
            this.gist_residuals.Size = new System.Drawing.Size(322, 183);
            this.gist_residuals.TabIndex = 1;
            this.gist_residuals.Text = "char1";
            // 
            // qq_plot
            // 
            this.qq_plot.BackColor = System.Drawing.SystemColors.Control;
            chartArea4.AxisX.MajorGrid.Enabled = false;
            chartArea4.AxisY.MajorGrid.Enabled = false;
            chartArea4.BackColor = System.Drawing.SystemColors.Control;
            chartArea4.Name = "ChartArea1";
            this.qq_plot.ChartAreas.Add(chartArea4);
            this.qq_plot.Location = new System.Drawing.Point(654, 453);
            this.qq_plot.Name = "qq_plot";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.Red;
            series6.Name = "reg";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series7.MarkerColor = System.Drawing.SystemColors.HotTrack;
            series7.MarkerSize = 6;
            series7.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series7.Name = "cor";
            this.qq_plot.Series.Add(series6);
            this.qq_plot.Series.Add(series7);
            this.qq_plot.Size = new System.Drawing.Size(322, 183);
            this.qq_plot.TabIndex = 1;
            this.qq_plot.Text = "char1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(162, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Остатки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(407, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Гистограмма остатков";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(786, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "QQ-Plot";
            // 
            // next
            // 
            this.next.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.next.Location = new System.Drawing.Point(741, 12);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(255, 43);
            this.next.TabIndex = 2;
            this.next.Text = "Перейти к интерполированию/ экстраполированию";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // ShowRegressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 639);
            this.Controls.Add(this.next);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qq_plot);
            this.Controls.Add(this.gist_residuals);
            this.Controls.Add(this.residuals);
            this.Controls.Add(this.regress);
            this.Name = "ShowRegressForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowRegressForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SetForm_Closed);
            ((System.ComponentModel.ISupportInitialize)(this.regress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.residuals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gist_residuals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qq_plot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart regress;
        private System.Windows.Forms.DataVisualization.Charting.Chart residuals;
        private System.Windows.Forms.DataVisualization.Charting.Chart gist_residuals;
        private System.Windows.Forms.DataVisualization.Charting.Chart qq_plot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button next;
    }
}