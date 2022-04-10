
namespace DesafioPractico2
{
    partial class HeapMaximo
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbHeap = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudNúmero = new System.Windows.Forms.NumericUpDown();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.rbtnPostOrden = new System.Windows.Forms.RadioButton();
            this.rbtnPreOrden = new System.Windows.Forms.RadioButton();
            this.rbtnEnOrden = new System.Windows.Forms.RadioButton();
            this.rbtnAnchura = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbHeap.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNúmero)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Heap Maximo";
            // 
            // tbHeap
            // 
            this.tbHeap.Controls.Add(this.tabPage1);
            this.tbHeap.Location = new System.Drawing.Point(12, 212);
            this.tbHeap.Name = "tbHeap";
            this.tbHeap.SelectedIndex = 0;
            this.tbHeap.Size = new System.Drawing.Size(990, 457);
            this.tbHeap.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(982, 431);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Heap";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Paint += new System.Windows.Forms.PaintEventHandler(this.tabPage1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "#";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Altura del Montículo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudNúmero);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(69, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 104);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controles";
            // 
            // nudNúmero
            // 
            this.nudNúmero.Location = new System.Drawing.Point(37, 42);
            this.nudNúmero.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudNúmero.Name = "nudNúmero";
            this.nudNúmero.Size = new System.Drawing.Size(120, 30);
            this.nudNúmero.TabIndex = 5;
            this.nudNúmero.Enter += new System.EventHandler(this.nudNúmero_Enter);
            this.nudNúmero.Leave += new System.EventHandler(this.nudNúmero_Leave);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(17)))), ((int)(((byte)(84)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(424, 37);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(99, 44);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(17)))), ((int)(((byte)(84)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(303, 37);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(99, 44);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(17)))), ((int)(((byte)(84)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(184, 37);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 44);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(15, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(101, 96);
            this.listBox1.TabIndex = 7;
            // 
            // btnMostrar
            // 
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Location = new System.Drawing.Point(203, 18);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(99, 44);
            this.btnMostrar.TabIndex = 8;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNumeros);
            this.groupBox2.Controls.Add(this.rbtnPostOrden);
            this.groupBox2.Controls.Add(this.rbtnPreOrden);
            this.groupBox2.Controls.Add(this.rbtnEnOrden);
            this.groupBox2.Controls.Add(this.rbtnAnchura);
            this.groupBox2.Controls.Add(this.btnMostrar);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(678, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 226);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recorridos";
            // 
            // txtNumeros
            // 
            this.txtNumeros.Location = new System.Drawing.Point(15, 176);
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.Size = new System.Drawing.Size(305, 30);
            this.txtNumeros.TabIndex = 13;
            // 
            // rbtnPostOrden
            // 
            this.rbtnPostOrden.AutoSize = true;
            this.rbtnPostOrden.Location = new System.Drawing.Point(203, 132);
            this.rbtnPostOrden.Name = "rbtnPostOrden";
            this.rbtnPostOrden.Size = new System.Drawing.Size(103, 27);
            this.rbtnPostOrden.TabIndex = 12;
            this.rbtnPostOrden.TabStop = true;
            this.rbtnPostOrden.Text = "Post Orden";
            this.rbtnPostOrden.UseVisualStyleBackColor = true;
            // 
            // rbtnPreOrden
            // 
            this.rbtnPreOrden.AutoSize = true;
            this.rbtnPreOrden.Location = new System.Drawing.Point(203, 66);
            this.rbtnPreOrden.Name = "rbtnPreOrden";
            this.rbtnPreOrden.Size = new System.Drawing.Size(98, 27);
            this.rbtnPreOrden.TabIndex = 11;
            this.rbtnPreOrden.TabStop = true;
            this.rbtnPreOrden.Text = "Pre Orden";
            this.rbtnPreOrden.UseVisualStyleBackColor = true;
            // 
            // rbtnEnOrden
            // 
            this.rbtnEnOrden.AutoSize = true;
            this.rbtnEnOrden.Location = new System.Drawing.Point(203, 99);
            this.rbtnEnOrden.Name = "rbtnEnOrden";
            this.rbtnEnOrden.Size = new System.Drawing.Size(93, 27);
            this.rbtnEnOrden.TabIndex = 10;
            this.rbtnEnOrden.TabStop = true;
            this.rbtnEnOrden.Text = "En Orden";
            this.rbtnEnOrden.UseVisualStyleBackColor = true;
            // 
            // rbtnAnchura
            // 
            this.rbtnAnchura.AutoSize = true;
            this.rbtnAnchura.Location = new System.Drawing.Point(22, 33);
            this.rbtnAnchura.Name = "rbtnAnchura";
            this.rbtnAnchura.Size = new System.Drawing.Size(85, 27);
            this.rbtnAnchura.TabIndex = 9;
            this.rbtnAnchura.TabStop = true;
            this.rbtnAnchura.Text = "Anchura";
            this.rbtnAnchura.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(17)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-6, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 78);
            this.panel1.TabIndex = 10;
            // 
            // HeapMaximo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1014, 669);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbHeap);
            this.Name = "HeapMaximo";
            this.Text = "HeapMaximo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HeapMaximo_FormClosed);
            this.tbHeap.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudNúmero)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tbHeap;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudNúmero;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnPostOrden;
        private System.Windows.Forms.RadioButton rbtnPreOrden;
        private System.Windows.Forms.RadioButton rbtnEnOrden;
        private System.Windows.Forms.RadioButton rbtnAnchura;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumeros;
    }
}