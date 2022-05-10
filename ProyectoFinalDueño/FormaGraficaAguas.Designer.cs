namespace ProyectoFinalDueño
{
    partial class FormaGraficaAguas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaGraficaAguas));
            this.btnCerrar = new System.Windows.Forms.Label();
            this.chartGraficaAguas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblVentasTotalesAguas = new System.Windows.Forms.Label();
            this.lblCantidadVentasElotes = new System.Windows.Forms.Label();
            this.TMActualizar = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartGraficaAguas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.AutoSize = true;
            this.btnCerrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnCerrar.Location = new System.Drawing.Point(827, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(18, 18);
            this.btnCerrar.TabIndex = 32;
            this.btnCerrar.Text = "X";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // chartGraficaAguas
            // 
            this.chartGraficaAguas.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.Name = "ChartArea1";
            this.chartGraficaAguas.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGraficaAguas.Legends.Add(legend1);
            this.chartGraficaAguas.Location = new System.Drawing.Point(12, 73);
            this.chartGraficaAguas.Name = "chartGraficaAguas";
            this.chartGraficaAguas.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartGraficaAguas.Series.Add(series1);
            this.chartGraficaAguas.Size = new System.Drawing.Size(833, 360);
            this.chartGraficaAguas.TabIndex = 39;
            this.chartGraficaAguas.Text = "chart1";
            this.chartGraficaAguas.Click += new System.EventHandler(this.chartGraficaAguas_Click);
            // 
            // lblVentasTotalesAguas
            // 
            this.lblVentasTotalesAguas.AutoSize = true;
            this.lblVentasTotalesAguas.BackColor = System.Drawing.Color.White;
            this.lblVentasTotalesAguas.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentasTotalesAguas.Location = new System.Drawing.Point(252, 21);
            this.lblVentasTotalesAguas.Name = "lblVentasTotalesAguas";
            this.lblVentasTotalesAguas.Size = new System.Drawing.Size(269, 24);
            this.lblVentasTotalesAguas.TabIndex = 40;
            this.lblVentasTotalesAguas.Text = "Dinero Total Generado:";
            // 
            // lblCantidadVentasElotes
            // 
            this.lblCantidadVentasElotes.AutoSize = true;
            this.lblCantidadVentasElotes.BackColor = System.Drawing.Color.White;
            this.lblCantidadVentasElotes.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadVentasElotes.Location = new System.Drawing.Point(527, 21);
            this.lblCantidadVentasElotes.Name = "lblCantidadVentasElotes";
            this.lblCantidadVentasElotes.Size = new System.Drawing.Size(38, 24);
            this.lblCantidadVentasElotes.TabIndex = 41;
            this.lblCantidadVentasElotes.Text = "----";
            // 
            // TMActualizar
            // 
            this.TMActualizar.Tick += new System.EventHandler(this.TMActualizar_Tick);
            // 
            // FormaGraficaAguas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(857, 461);
            this.Controls.Add(this.lblCantidadVentasElotes);
            this.Controls.Add(this.lblVentasTotalesAguas);
            this.Controls.Add(this.chartGraficaAguas);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormaGraficaAguas";
            this.Text = "FormaGraficaAguas";
            this.Load += new System.EventHandler(this.FormaGraficaAguas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartGraficaAguas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnCerrar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraficaAguas;
        private System.Windows.Forms.Label lblVentasTotalesAguas;
        private System.Windows.Forms.Label lblCantidadVentasElotes;
        private System.Windows.Forms.Timer TMActualizar;
    }
}