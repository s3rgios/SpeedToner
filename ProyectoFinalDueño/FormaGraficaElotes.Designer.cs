namespace ProyectoFinalDueño
{
    partial class FormaGraficaElotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaGraficaElotes));
            this.btnCerrar = new System.Windows.Forms.Label();
            this.charGraficaElotes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblVentasTotalesElotes = new System.Windows.Forms.Label();
            this.lblCantidadVentasElotes = new System.Windows.Forms.Label();
            this.TMActualizar = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.charGraficaElotes)).BeginInit();
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
            // charGraficaElotes
            // 
            this.charGraficaElotes.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.charGraficaElotes.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.charGraficaElotes.Legends.Add(legend1);
            this.charGraficaElotes.Location = new System.Drawing.Point(50, 70);
            this.charGraficaElotes.Name = "charGraficaElotes";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.IsValueShownAsLabel = true;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.charGraficaElotes.Series.Add(series1);
            this.charGraficaElotes.Size = new System.Drawing.Size(795, 379);
            this.charGraficaElotes.TabIndex = 39;
            this.charGraficaElotes.Text = "chart1";
            // 
            // lblVentasTotalesElotes
            // 
            this.lblVentasTotalesElotes.AutoSize = true;
            this.lblVentasTotalesElotes.BackColor = System.Drawing.Color.White;
            this.lblVentasTotalesElotes.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentasTotalesElotes.Location = new System.Drawing.Point(280, 25);
            this.lblVentasTotalesElotes.Name = "lblVentasTotalesElotes";
            this.lblVentasTotalesElotes.Size = new System.Drawing.Size(269, 24);
            this.lblVentasTotalesElotes.TabIndex = 41;
            this.lblVentasTotalesElotes.Text = "Dinero Total Generado:";
            // 
            // lblCantidadVentasElotes
            // 
            this.lblCantidadVentasElotes.AutoSize = true;
            this.lblCantidadVentasElotes.BackColor = System.Drawing.Color.White;
            this.lblCantidadVentasElotes.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadVentasElotes.Location = new System.Drawing.Point(555, 25);
            this.lblCantidadVentasElotes.Name = "lblCantidadVentasElotes";
            this.lblCantidadVentasElotes.Size = new System.Drawing.Size(31, 24);
            this.lblCantidadVentasElotes.TabIndex = 42;
            this.lblCantidadVentasElotes.Text = "---";
            // 
            // TMActualizar
            // 
            this.TMActualizar.Tick += new System.EventHandler(this.TMActualizar_Tick);
            // 
            // FormaGraficaElotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(857, 461);
            this.Controls.Add(this.lblCantidadVentasElotes);
            this.Controls.Add(this.lblVentasTotalesElotes);
            this.Controls.Add(this.charGraficaElotes);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormaGraficaElotes";
            this.Text = "FormaGraficaElotes";
            this.Load += new System.EventHandler(this.FormaGraficaElotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.charGraficaElotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnCerrar;
        private System.Windows.Forms.DataVisualization.Charting.Chart charGraficaElotes;
        private System.Windows.Forms.Label lblVentasTotalesElotes;
        private System.Windows.Forms.Label lblCantidadVentasElotes;
        private System.Windows.Forms.Timer TMActualizar;
    }
}