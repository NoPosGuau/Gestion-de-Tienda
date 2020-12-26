namespace TIENDA
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guardarbox = new System.Windows.Forms.Button();
            this.editarbox = new System.Windows.Forms.Button();
            this.eliminarbox = new System.Windows.Forms.Button();
            this.mostrabox = new System.Windows.Forms.Button();
            this.deudoresbox = new System.Windows.Forms.Button();
            this.gv = new System.Windows.Forms.DataGridView();
            this.articulotex = new System.Windows.Forms.TextBox();
            this.condiciontex = new System.Windows.Forms.TextBox();
            this.preciotex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buscarbox = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.SuspendLayout();
            // 
            // guardarbox
            // 
            this.guardarbox.BackColor = System.Drawing.Color.Transparent;
            this.guardarbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guardarbox.BackgroundImage")));
            this.guardarbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guardarbox.FlatAppearance.BorderSize = 0;
            this.guardarbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardarbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarbox.ForeColor = System.Drawing.Color.Transparent;
            this.guardarbox.Location = new System.Drawing.Point(19, 429);
            this.guardarbox.Name = "guardarbox";
            this.guardarbox.Size = new System.Drawing.Size(59, 57);
            this.guardarbox.TabIndex = 0;
            this.guardarbox.UseVisualStyleBackColor = false;
            this.guardarbox.Click += new System.EventHandler(this.guardarbox_Click);
            // 
            // editarbox
            // 
            this.editarbox.BackColor = System.Drawing.Color.Transparent;
            this.editarbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editarbox.BackgroundImage")));
            this.editarbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editarbox.FlatAppearance.BorderSize = 0;
            this.editarbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editarbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarbox.ForeColor = System.Drawing.Color.Transparent;
            this.editarbox.Location = new System.Drawing.Point(95, 429);
            this.editarbox.Name = "editarbox";
            this.editarbox.Size = new System.Drawing.Size(60, 57);
            this.editarbox.TabIndex = 2;
            this.editarbox.UseVisualStyleBackColor = false;
            this.editarbox.Click += new System.EventHandler(this.editarbox_Click);
            // 
            // eliminarbox
            // 
            this.eliminarbox.BackColor = System.Drawing.Color.Transparent;
            this.eliminarbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eliminarbox.BackgroundImage")));
            this.eliminarbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eliminarbox.FlatAppearance.BorderSize = 0;
            this.eliminarbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarbox.ForeColor = System.Drawing.Color.White;
            this.eliminarbox.Location = new System.Drawing.Point(175, 429);
            this.eliminarbox.Name = "eliminarbox";
            this.eliminarbox.Size = new System.Drawing.Size(60, 57);
            this.eliminarbox.TabIndex = 4;
            this.eliminarbox.UseVisualStyleBackColor = false;
            this.eliminarbox.Click += new System.EventHandler(this.eliminarbox_Click);
            // 
            // mostrabox
            // 
            this.mostrabox.BackColor = System.Drawing.Color.Transparent;
            this.mostrabox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mostrabox.BackgroundImage")));
            this.mostrabox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mostrabox.FlatAppearance.BorderSize = 0;
            this.mostrabox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mostrabox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrabox.ForeColor = System.Drawing.Color.White;
            this.mostrabox.Location = new System.Drawing.Point(269, 429);
            this.mostrabox.Name = "mostrabox";
            this.mostrabox.Size = new System.Drawing.Size(51, 57);
            this.mostrabox.TabIndex = 6;
            this.mostrabox.UseVisualStyleBackColor = false;
            this.mostrabox.Click += new System.EventHandler(this.mostrabox_Click);
            // 
            // deudoresbox
            // 
            this.deudoresbox.BackColor = System.Drawing.Color.Transparent;
            this.deudoresbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deudoresbox.BackgroundImage")));
            this.deudoresbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deudoresbox.FlatAppearance.BorderSize = 0;
            this.deudoresbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deudoresbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deudoresbox.ForeColor = System.Drawing.Color.White;
            this.deudoresbox.Location = new System.Drawing.Point(446, 429);
            this.deudoresbox.Name = "deudoresbox";
            this.deudoresbox.Size = new System.Drawing.Size(62, 57);
            this.deudoresbox.TabIndex = 8;
            this.deudoresbox.UseVisualStyleBackColor = false;
            this.deudoresbox.Click += new System.EventHandler(this.deudoresbox_Click);
            // 
            // gv
            // 
            this.gv.BackgroundColor = System.Drawing.Color.DeepPink;
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Location = new System.Drawing.Point(19, 171);
            this.gv.Name = "gv";
            this.gv.Size = new System.Drawing.Size(489, 236);
            this.gv.TabIndex = 9;
            this.gv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_CellContentClick);
            // 
            // articulotex
            // 
            this.articulotex.BackColor = System.Drawing.Color.DeepPink;
            this.articulotex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.articulotex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articulotex.Location = new System.Drawing.Point(175, 29);
            this.articulotex.Name = "articulotex";
            this.articulotex.Size = new System.Drawing.Size(168, 22);
            this.articulotex.TabIndex = 10;
            this.articulotex.TextChanged += new System.EventHandler(this.articulotex_TextChanged);
            // 
            // condiciontex
            // 
            this.condiciontex.BackColor = System.Drawing.Color.DeepPink;
            this.condiciontex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.condiciontex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.condiciontex.Location = new System.Drawing.Point(175, 75);
            this.condiciontex.Name = "condiciontex";
            this.condiciontex.Size = new System.Drawing.Size(168, 22);
            this.condiciontex.TabIndex = 12;
            this.condiciontex.TextChanged += new System.EventHandler(this.condiciontex_TextChanged);
            // 
            // preciotex
            // 
            this.preciotex.BackColor = System.Drawing.Color.DeepPink;
            this.preciotex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.preciotex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preciotex.Location = new System.Drawing.Point(175, 116);
            this.preciotex.Name = "preciotex";
            this.preciotex.Size = new System.Drawing.Size(100, 22);
            this.preciotex.TabIndex = 14;
            this.preciotex.TextChanged += new System.EventHandler(this.preciotex_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "ARTICULO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DeepPink;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "CONDICION";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DeepPink;
            this.label3.Location = new System.Drawing.Point(14, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "PRECIO";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // buscarbox
            // 
            this.buscarbox.BackColor = System.Drawing.Color.Transparent;
            this.buscarbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buscarbox.BackgroundImage")));
            this.buscarbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buscarbox.FlatAppearance.BorderSize = 0;
            this.buscarbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarbox.ForeColor = System.Drawing.Color.Transparent;
            this.buscarbox.Location = new System.Drawing.Point(460, 25);
            this.buscarbox.Name = "buscarbox";
            this.buscarbox.Size = new System.Drawing.Size(48, 46);
            this.buscarbox.TabIndex = 22;
            this.buscarbox.UseVisualStyleBackColor = false;
            this.buscarbox.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepPink;
            this.label4.Location = new System.Drawing.Point(555, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 39);
            this.label4.TabIndex = 24;
            this.label4.Text = "Gloria a Dios";
            this.label4.UseMnemonic = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(821, 500);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buscarbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.preciotex);
            this.Controls.Add(this.condiciontex);
            this.Controls.Add(this.articulotex);
            this.Controls.Add(this.gv);
            this.Controls.Add(this.deudoresbox);
            this.Controls.Add(this.mostrabox);
            this.Controls.Add(this.eliminarbox);
            this.Controls.Add(this.editarbox);
            this.Controls.Add(this.guardarbox);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button guardarbox;
        private System.Windows.Forms.Button editarbox;
        private System.Windows.Forms.Button eliminarbox;
        private System.Windows.Forms.Button mostrabox;
        private System.Windows.Forms.Button deudoresbox;
        private System.Windows.Forms.DataGridView gv;
        private System.Windows.Forms.TextBox articulotex;
        private System.Windows.Forms.TextBox condiciontex;
        private System.Windows.Forms.TextBox preciotex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buscarbox;
        private System.Windows.Forms.Label label4;
    }
}

