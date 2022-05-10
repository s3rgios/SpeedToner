namespace ProyectoFinalDueño
{
    partial class FormaGraficaFrutas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaGraficaFrutas));
            this.btnCerrar = new System.Windows.Forms.Label();
            this.chartGraficaFrutas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblVentasTotales = new System.Windows.Forms.Label();
            this.lblCantidadVentasFrutas = new System.Windows.Forms.Label();
            this.TMActualizar = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartGraficaFrutas)).BeginInit();
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
            this.btnCerrar.TabIndex = 31;
            this.btnCerrar.Text = "X";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // chartGraficaFrutas
            // 
            this.chartGraficaFrutas.BackColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "ChartArea1";
            this.chartGraficaFrutas.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartGraficaFrutas.Legends.Add(legend4);
            this.chartGraficaFrutas.Location = new System.Drawing.Point(58, 93);
            this.chartGraficaFrutas.Name = "chartGraficaFrutas";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartGraficaFrutas.Series.Add(series4);
            this.chartGraficaFrutas.Size = new System.Drawing.Size(763, 330);
            this.chartGraficaFrutas.TabIndex = 37;
            this.chartGraficaFrutas.Text = "chart1";
            // 
            // lblVentasTotales
            // 
            this.lblVentasTotales.AutoSize = true;
            this.lblVentasTotales.BackColor = System.Drawing.Color.White;
            this.lblVentasTotales.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentasTotales.ForeColor = System.Drawing.Color.Firebrick;
            this.lblVentasTotales.Location = new System.Drawing.Point(272, 45);
            this.lblVentasTotales.Name = "lblVentasTotales";
            this.lblVentasTotales.Size = new System.Drawing.Size(269, 24);
            this.lblVentasTotales.TabIndex = 38;
            this.lblVentasTotales.Text = "Dinero Total Generado:";
            // 
            // lblCantidadVentasFrutas
            // 
            this.lblCantidadVentasFrutas.AutoSize = true;
            this.lblCantidadVentasFrutas.BackColor = System.Drawing.Color.White;
            this.lblCantidadVentasFrutas.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadVentasFrutas.ForeColor = System.Drawing.Color.Firebrick;
            this.lblCantidadVentasFrutas.Location = new System.Drawing.Point(547, 45);
            this.lblCantidadVentasFrutas.Name = "lblCantidadVentasFrutas";
            this.lblCantidadVentasFrutas.Size = new System.Drawing.Size(31, 24);
            this.lblCantidadVentasFrutas.TabIndex = 39;
            this.lblCantidadVentasFrutas.Text = "---";
            // 
            // TMActualizar
            // 
            this.TMActualizar.Tick += new System.EventHandler(this.TMActualizar_Tick);
            // 
            // FormaGraficaFrutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(857, 461);
            this.Controls.Add(this.lblCantidadVentasFrutas);
            this.Controls.Add(this.lblVentasTotales);
            this.Controls.Add(this.chartGraficaFrutas);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormaGraficaFrutas";
            this.Text = "FormaGraficaFrutas";
            this.Load += new System.EventHandler(this.FormaGraficaFrutas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartGraficaFrutas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnCerrar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraficaFrutas;
        private System.Windows.Forms.Label lblVentasTotales;
        private System.Windows.Forms.Label lblCantidadVentasFrutas;
        private System.Windows.Forms.Timer TMActualizar;
    }
}