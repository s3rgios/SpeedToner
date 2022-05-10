namespace ProyectoFinalDueño
{
    partial class FormaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaMenu));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.btnGraficaFrutas = new System.Windows.Forms.Button();
            this.pFrutas = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGraficaAguas = new System.Windows.Forms.Button();
            this.btnGraficaElotes = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnSlide = new System.Windows.Forms.PictureBox();
            this.IconoMinimizar = new System.Windows.Forms.PictureBox();
            this.IconoRestaurar = new System.Windows.Forms.PictureBox();
            this.IconoMaximizar = new System.Windows.Forms.PictureBox();
            this.IconoCerrar = new System.Windows.Forms.PictureBox();
            this.MenuVertical.SuspendLayout();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pFrutas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.MenuVertical.Controls.Add(this.pictureBox3);
            this.MenuVertical.Controls.Add(this.pictureBox2);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Controls.Add(this.btnGraficaAguas);
            this.MenuVertical.Controls.Add(this.btnGraficaElotes);
            this.MenuVertical.Controls.Add(this.pFrutas);
            this.MenuVertical.Controls.Add(this.btnGraficaFrutas);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(250, 600);
            this.MenuVertical.TabIndex = 0;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.Controls.Add(this.IconoMinimizar);
            this.BarraTitulo.Controls.Add(this.IconoRestaurar);
            this.BarraTitulo.Controls.Add(this.IconoMaximizar);
            this.BarraTitulo.Controls.Add(this.IconoCerrar);
            this.BarraTitulo.Controls.Add(this.btnSlide);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(250, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(900, 50);
            this.BarraTitulo.TabIndex = 1;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelContenedor.BackgroundImage")));
            this.PanelContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(250, 50);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(900, 550);
            this.PanelContenedor.TabIndex = 2;
            this.PanelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelContenedor_Paint);
            // 
            // btnGraficaFrutas
            // 
            this.btnGraficaFrutas.FlatAppearance.BorderSize = 0;
            this.btnGraficaFrutas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnGraficaFrutas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraficaFrutas.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraficaFrutas.ForeColor = System.Drawing.Color.Black;
            this.btnGraficaFrutas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGraficaFrutas.Location = new System.Drawing.Point(0, 170);
            this.btnGraficaFrutas.Name = "btnGraficaFrutas";
            this.btnGraficaFrutas.Size = new System.Drawing.Size(250, 45);
            this.btnGraficaFrutas.TabIndex = 7;
            this.btnGraficaFrutas.Text = " Grafica Frutas";
            this.btnGraficaFrutas.UseVisualStyleBackColor = true;
            this.btnGraficaFrutas.Click += new System.EventHandler(this.btnGraficaFrutas_Click);
            // 
            // pFrutas
            // 
            this.pFrutas.Image = ((System.Drawing.Image)(resources.GetObject("pFrutas.Image")));
            this.pFrutas.Location = new System.Drawing.Point(0, 170);
            this.pFrutas.Name = "pFrutas";
            this.pFrutas.Size = new System.Drawing.Size(64, 45);
            this.pFrutas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pFrutas.TabIndex = 12;
            this.pFrutas.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 301);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 231);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btnGraficaAguas
            // 
            this.btnGraficaAguas.FlatAppearance.BorderSize = 0;
            this.btnGraficaAguas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnGraficaAguas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraficaAguas.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraficaAguas.ForeColor = System.Drawing.Color.Black;
            this.btnGraficaAguas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGraficaAguas.Location = new System.Drawing.Point(0, 301);
            this.btnGraficaAguas.Name = "btnGraficaAguas";
            this.btnGraficaAguas.Size = new System.Drawing.Size(250, 45);
            this.btnGraficaAguas.TabIndex = 15;
            this.btnGraficaAguas.Text = "  Grafica Aguas";
            this.btnGraficaAguas.UseVisualStyleBackColor = true;
            this.btnGraficaAguas.Click += new System.EventHandler(this.btnGraficaAguas_Click);
            // 
            // btnGraficaElotes
            // 
            this.btnGraficaElotes.FlatAppearance.BorderSize = 0;
            this.btnGraficaElotes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnGraficaElotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraficaElotes.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraficaElotes.ForeColor = System.Drawing.Color.Black;
            this.btnGraficaElotes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGraficaElotes.Location = new System.Drawing.Point(0, 231);
            this.btnGraficaElotes.Name = "btnGraficaElotes";
            this.btnGraficaElotes.Size = new System.Drawing.Size(194, 45);
            this.btnGraficaElotes.TabIndex = 14;
            this.btnGraficaElotes.Text = "        Grafica Elotes";
            this.btnGraficaElotes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGraficaElotes.UseVisualStyleBackColor = true;
            this.btnGraficaElotes.Click += new System.EventHandler(this.btnGraficaElotes_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 93);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // btnSlide
            // 
            this.btnSlide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSlide.Image = ((System.Drawing.Image)(resources.GetObject("btnSlide.Image")));
            this.btnSlide.Location = new System.Drawing.Point(6, 9);
            this.btnSlide.Name = "btnSlide";
            this.btnSlide.Size = new System.Drawing.Size(35, 35);
            this.btnSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSlide.TabIndex = 2;
            this.btnSlide.TabStop = false;
            this.btnSlide.Click += new System.EventHandler(this.btnSlide_Click);
            // 
            // IconoMinimizar
            // 
            this.IconoMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconoMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconoMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("IconoMinimizar.Image")));
            this.IconoMinimizar.Location = new System.Drawing.Point(786, 9);
            this.IconoMinimizar.Name = "IconoMinimizar";
            this.IconoMinimizar.Size = new System.Drawing.Size(30, 30);
            this.IconoMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconoMinimizar.TabIndex = 12;
            this.IconoMinimizar.TabStop = false;
            this.IconoMinimizar.Click += new System.EventHandler(this.IconoMinimizar_Click);
            // 
            // IconoRestaurar
            // 
            this.IconoRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconoRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconoRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("IconoRestaurar.Image")));
            this.IconoRestaurar.Location = new System.Drawing.Point(822, 9);
            this.IconoRestaurar.Name = "IconoRestaurar";
            this.IconoRestaurar.Size = new System.Drawing.Size(30, 30);
            this.IconoRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconoRestaurar.TabIndex = 11;
            this.IconoRestaurar.TabStop = false;
            this.IconoRestaurar.Visible = false;
            this.IconoRestaurar.Click += new System.EventHandler(this.IconoRestaurar_Click);
            // 
            // IconoMaximizar
            // 
            this.IconoMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconoMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconoMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("IconoMaximizar.Image")));
            this.IconoMaximizar.Location = new System.Drawing.Point(822, 9);
            this.IconoMaximizar.Name = "IconoMaximizar";
            this.IconoMaximizar.Size = new System.Drawing.Size(30, 30);
            this.IconoMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconoMaximizar.TabIndex = 10;
            this.IconoMaximizar.TabStop = false;
            this.IconoMaximizar.Click += new System.EventHandler(this.IconoMaximizar_Click);
            // 
            // IconoCerrar
            // 
            this.IconoCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconoCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconoCerrar.Image = ((System.Drawing.Image)(resources.GetObject("IconoCerrar.Image")));
            this.IconoCerrar.Location = new System.Drawing.Point(858, 9);
            this.IconoCerrar.Name = "IconoCerrar";
            this.IconoCerrar.Size = new System.Drawing.Size(30, 30);
            this.IconoCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconoCerrar.TabIndex = 9;
            this.IconoCerrar.TabStop = false;
            this.IconoCerrar.Click += new System.EventHandler(this.IconoCerrar_Click);
            // 
            // FormaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1150, 600);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormaMenu";
            this.Text = "Form1";
            this.MenuVertical.ResumeLayout(false);
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pFrutas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGraficaAguas;
        private System.Windows.Forms.Button btnGraficaElotes;
        private System.Windows.Forms.PictureBox pFrutas;
        private System.Windows.Forms.Button btnGraficaFrutas;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox IconoMinimizar;
        private System.Windows.Forms.PictureBox IconoRestaurar;
        private System.Windows.Forms.PictureBox IconoMaximizar;
        private System.Windows.Forms.PictureBox IconoCerrar;
        private System.Windows.Forms.PictureBox btnSlide;
        private System.Windows.Forms.Panel PanelContenedor;
    }
}

