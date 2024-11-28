namespace VentanaTorneo
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.creaConfederacion = new System.Windows.Forms.Button();
            this.texboxnumtorne = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxconfenombre = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCrearTor = new System.Windows.Forms.Button();
            this.txtTotalEquipos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreTor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.eliminarPorSelec = new System.Windows.Forms.Button();
            this.DespuesDe = new System.Windows.Forms.Button();
            this.txteliminar = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Modificar = new System.Windows.Forms.Button();
            this.btnAgregarEq = new System.Windows.Forms.Button();
            this.eliminaTodasCopias = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.eliminarXbusqueda = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMonstrarEq = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFundacion = new System.Windows.Forms.TextBox();
            this.txtJugadores = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtClub = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox3.Controls.Add(this.creaConfederacion);
            this.groupBox3.Controls.Add(this.texboxnumtorne);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBoxconfenombre);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(735, 87);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CONFEDERACION";
            // 
            // creaConfederacion
            // 
            this.creaConfederacion.Location = new System.Drawing.Point(438, 26);
            this.creaConfederacion.Name = "creaConfederacion";
            this.creaConfederacion.Size = new System.Drawing.Size(113, 23);
            this.creaConfederacion.TabIndex = 6;
            this.creaConfederacion.Text = "Crear confederación";
            this.creaConfederacion.UseVisualStyleBackColor = true;
            this.creaConfederacion.Click += new System.EventHandler(this.creaConfederacion_Click);
            // 
            // texboxnumtorne
            // 
            this.texboxnumtorne.Location = new System.Drawing.Point(165, 49);
            this.texboxnumtorne.Name = "texboxnumtorne";
            this.texboxnumtorne.Size = new System.Drawing.Size(118, 20);
            this.texboxnumtorne.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Nombre de la confederación:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Total de torneos:";
            // 
            // textBoxconfenombre
            // 
            this.textBoxconfenombre.Location = new System.Drawing.Point(165, 23);
            this.textBoxconfenombre.Name = "textBoxconfenombre";
            this.textBoxconfenombre.Size = new System.Drawing.Size(238, 20);
            this.textBoxconfenombre.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(906, 541);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(898, 515);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(898, 515);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Aquamarine;
            this.groupBox1.Controls.Add(this.listBox2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnCrearTor);
            this.groupBox1.Controls.Add(this.txtTotalEquipos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombreTor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 255);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TORNEOS";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(22, 81);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(691, 160);
            this.listBox2.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(445, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Mostrar torneos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCrearTor
            // 
            this.btnCrearTor.Location = new System.Drawing.Point(445, 21);
            this.btnCrearTor.Name = "btnCrearTor";
            this.btnCrearTor.Size = new System.Drawing.Size(106, 23);
            this.btnCrearTor.TabIndex = 5;
            this.btnCrearTor.Text = "Crear torneo";
            this.btnCrearTor.UseVisualStyleBackColor = true;
            this.btnCrearTor.Click += new System.EventHandler(this.btnCrearTor_Click);
            // 
            // txtTotalEquipos
            // 
            this.txtTotalEquipos.Location = new System.Drawing.Point(139, 50);
            this.txtTotalEquipos.Name = "txtTotalEquipos";
            this.txtTotalEquipos.Size = new System.Drawing.Size(118, 20);
            this.txtTotalEquipos.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total de equipos:";
            // 
            // txtNombreTor
            // 
            this.txtNombreTor.Location = new System.Drawing.Point(139, 24);
            this.txtNombreTor.Name = "txtNombreTor";
            this.txtNombreTor.Size = new System.Drawing.Size(238, 20);
            this.txtNombreTor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del torneo:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(898, 515);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Thistle;
            this.groupBox2.Controls.Add(this.eliminarPorSelec);
            this.groupBox2.Controls.Add(this.DespuesDe);
            this.groupBox2.Controls.Add(this.txteliminar);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Modificar);
            this.groupBox2.Controls.Add(this.btnAgregarEq);
            this.groupBox2.Controls.Add(this.eliminaTodasCopias);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.eliminarXbusqueda);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnMonstrarEq);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtFundacion);
            this.groupBox2.Controls.Add(this.txtJugadores);
            this.groupBox2.Controls.Add(this.txtCiudad);
            this.groupBox2.Controls.Add(this.txtClub);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(0, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(735, 448);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EQUIPOS";
            // 
            // eliminarPorSelec
            // 
            this.eliminarPorSelec.Location = new System.Drawing.Point(370, 104);
            this.eliminarPorSelec.Name = "eliminarPorSelec";
            this.eliminarPorSelec.Size = new System.Drawing.Size(93, 36);
            this.eliminarPorSelec.TabIndex = 19;
            this.eliminarPorSelec.Text = "Eliminar equipo seleccionado";
            this.eliminarPorSelec.UseVisualStyleBackColor = true;
            this.eliminarPorSelec.Click += new System.EventHandler(this.eliminarPorSelec_Click);
            // 
            // DespuesDe
            // 
            this.DespuesDe.Location = new System.Drawing.Point(489, 100);
            this.DespuesDe.Name = "DespuesDe";
            this.DespuesDe.Size = new System.Drawing.Size(124, 23);
            this.DespuesDe.TabIndex = 14;
            this.DespuesDe.Text = "Agregar después de";
            this.DespuesDe.UseVisualStyleBackColor = true;
            this.DespuesDe.Click += new System.EventHandler(this.DespuesDe_Click);
            // 
            // txteliminar
            // 
            this.txteliminar.Location = new System.Drawing.Point(537, 13);
            this.txteliminar.Name = "txteliminar";
            this.txteliminar.Size = new System.Drawing.Size(191, 20);
            this.txteliminar.TabIndex = 10;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(22, 159);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(691, 212);
            this.listBox1.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(455, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Buscar equipo:";
            // 
            // Modificar
            // 
            this.Modificar.Location = new System.Drawing.Point(635, 42);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(78, 23);
            this.Modificar.TabIndex = 13;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // btnAgregarEq
            // 
            this.btnAgregarEq.Location = new System.Drawing.Point(370, 42);
            this.btnAgregarEq.Name = "btnAgregarEq";
            this.btnAgregarEq.Size = new System.Drawing.Size(93, 27);
            this.btnAgregarEq.TabIndex = 8;
            this.btnAgregarEq.Text = "Agregar equipo";
            this.btnAgregarEq.UseVisualStyleBackColor = true;
            this.btnAgregarEq.Click += new System.EventHandler(this.btnAgregarEq_Click);
            // 
            // eliminaTodasCopias
            // 
            this.eliminaTodasCopias.Location = new System.Drawing.Point(489, 42);
            this.eliminaTodasCopias.Name = "eliminaTodasCopias";
            this.eliminaTodasCopias.Size = new System.Drawing.Size(124, 23);
            this.eliminaTodasCopias.TabIndex = 11;
            this.eliminaTodasCopias.Text = "Eliminar todas copias";
            this.eliminaTodasCopias.UseVisualStyleBackColor = true;
            this.eliminaTodasCopias.Click += new System.EventHandler(this.eliminaTodasCopias_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Año de fundacion:";
            // 
            // eliminarXbusqueda
            // 
            this.eliminarXbusqueda.Location = new System.Drawing.Point(489, 71);
            this.eliminarXbusqueda.Name = "eliminarXbusqueda";
            this.eliminarXbusqueda.Size = new System.Drawing.Size(124, 23);
            this.eliminarXbusqueda.TabIndex = 12;
            this.eliminarXbusqueda.Text = "Eliminar por busqueda";
            this.eliminarXbusqueda.UseVisualStyleBackColor = true;
            this.eliminarXbusqueda.Click += new System.EventHandler(this.eliminarXbusqueda_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Total de jugadores:";
            // 
            // btnMonstrarEq
            // 
            this.btnMonstrarEq.Location = new System.Drawing.Point(370, 75);
            this.btnMonstrarEq.Name = "btnMonstrarEq";
            this.btnMonstrarEq.Size = new System.Drawing.Size(93, 23);
            this.btnMonstrarEq.TabIndex = 11;
            this.btnMonstrarEq.Text = "Mostrar equipos";
            this.btnMonstrarEq.UseVisualStyleBackColor = true;
            this.btnMonstrarEq.Click += new System.EventHandler(this.btnMonstrarEq_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ciudad:";
            // 
            // txtFundacion
            // 
            this.txtFundacion.Location = new System.Drawing.Point(112, 120);
            this.txtFundacion.Name = "txtFundacion";
            this.txtFundacion.Size = new System.Drawing.Size(238, 20);
            this.txtFundacion.TabIndex = 15;
            // 
            // txtJugadores
            // 
            this.txtJugadores.Location = new System.Drawing.Point(112, 94);
            this.txtJugadores.Name = "txtJugadores";
            this.txtJugadores.Size = new System.Drawing.Size(238, 20);
            this.txtJugadores.TabIndex = 13;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(112, 68);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(238, 20);
            this.txtCiudad.TabIndex = 11;
            // 
            // txtClub
            // 
            this.txtClub.Location = new System.Drawing.Point(112, 42);
            this.txtClub.Name = "txtClub";
            this.txtClub.Size = new System.Drawing.Size(238, 20);
            this.txtClub.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre del club:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 552);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button creaConfederacion;
        private System.Windows.Forms.TextBox texboxnumtorne;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxconfenombre;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCrearTor;
        private System.Windows.Forms.TextBox txtTotalEquipos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreTor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button eliminarPorSelec;
        private System.Windows.Forms.Button DespuesDe;
        private System.Windows.Forms.TextBox txteliminar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Button btnAgregarEq;
        private System.Windows.Forms.Button eliminaTodasCopias;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button eliminarXbusqueda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMonstrarEq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFundacion;
        private System.Windows.Forms.TextBox txtJugadores;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtClub;
        private System.Windows.Forms.Label label3;
    }
}

