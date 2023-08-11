namespace parcial
{
    partial class Home
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.panelBot = new System.Windows.Forms.Panel();
            this.Panel_Empleados = new System.Windows.Forms.Panel();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.panelEmpleadoInferior = new System.Windows.Forms.Panel();
            this.btnEmpleadoExit = new System.Windows.Forms.Button();
            this.panelEmpleadoSuperior = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.Panel_Empleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.panelEmpleadoInferior.SuspendLayout();
            this.panelEmpleadoSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panelTop.Controls.Add(this.btnMinimize);
            this.panelTop.Controls.Add(this.btnExit);
            this.panelTop.Location = new System.Drawing.Point(155, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1040, 45);
            this.panelTop.TabIndex = 21;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMinimize.Location = new System.Drawing.Point(965, 9);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(24, 22);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(996, 9);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 22);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panelLeft.Controls.Add(this.panel1);
            this.panelLeft.Controls.Add(this.btnProductos);
            this.panelLeft.Controls.Add(this.btnEmpleados);
            this.panelLeft.Controls.Add(this.btnClientes);
            this.panelLeft.Controls.Add(this.btnVentas);
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(157, 577);
            this.panelLeft.TabIndex = 22;
            this.panelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_right_Paint);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(155, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 94);
            this.panel1.TabIndex = 24;
            // 
            // btnProductos
            // 
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.Location = new System.Drawing.Point(10, 143);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(142, 26);
            this.btnProductos.TabIndex = 3;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnProductos.UseVisualStyleBackColor = true;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnEmpleados.Location = new System.Drawing.Point(10, 184);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(131, 26);
            this.btnEmpleados.TabIndex = 2;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btn_empleados_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Location = new System.Drawing.Point(10, 105);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(131, 26);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClientes.UseVisualStyleBackColor = true;
            // 
            // btnVentas
            // 
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.Location = new System.Drawing.Point(10, 67);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(131, 26);
            this.btnVentas.TabIndex = 0;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnVentas.UseVisualStyleBackColor = true;
            // 
            // panelBot
            // 
            this.panelBot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panelBot.Location = new System.Drawing.Point(155, 531);
            this.panelBot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBot.Name = "panelBot";
            this.panelBot.Size = new System.Drawing.Size(1040, 45);
            this.panelBot.TabIndex = 23;
            // 
            // Panel_Empleados
            // 
            this.Panel_Empleados.BackColor = System.Drawing.Color.Silver;
            this.Panel_Empleados.Controls.Add(this.dgvEmpleados);
            this.Panel_Empleados.Controls.Add(this.panelEmpleadoInferior);
            this.Panel_Empleados.Controls.Add(this.panelEmpleadoSuperior);
            this.Panel_Empleados.Location = new System.Drawing.Point(155, 40);
            this.Panel_Empleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel_Empleados.Name = "Panel_Empleados";
            this.Panel_Empleados.Size = new System.Drawing.Size(1040, 491);
            this.Panel_Empleados.TabIndex = 24;
            this.Panel_Empleados.Visible = false;
            this.Panel_Empleados.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Empleados_Paint);
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEmpleados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Legajo,
            this.Nombre,
            this.Apellido,
            this.DNI,
            this.Domicilio,
            this.FechaNacimiento});
            this.dgvEmpleados.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvEmpleados.Location = new System.Drawing.Point(0, 47);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.RowTemplate.Height = 25;
            this.dgvEmpleados.Size = new System.Drawing.Size(1040, 444);
            this.dgvEmpleados.TabIndex = 2;
            this.dgvEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellContentClick);
            // 
            // panelEmpleadoInferior
            // 
            this.panelEmpleadoInferior.BackColor = System.Drawing.Color.Gray;
            this.panelEmpleadoInferior.Controls.Add(this.btnEmpleadoExit);
            this.panelEmpleadoInferior.Location = new System.Drawing.Point(0, 461);
            this.panelEmpleadoInferior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelEmpleadoInferior.Name = "panelEmpleadoInferior";
            this.panelEmpleadoInferior.Size = new System.Drawing.Size(1040, 29);
            this.panelEmpleadoInferior.TabIndex = 1;
            this.panelEmpleadoInferior.Visible = false;
            // 
            // btnEmpleadoExit
            // 
            this.btnEmpleadoExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleadoExit.Location = new System.Drawing.Point(948, 4);
            this.btnEmpleadoExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmpleadoExit.Name = "btnEmpleadoExit";
            this.btnEmpleadoExit.Size = new System.Drawing.Size(82, 22);
            this.btnEmpleadoExit.TabIndex = 0;
            this.btnEmpleadoExit.Text = "Salir";
            this.btnEmpleadoExit.UseVisualStyleBackColor = true;
            this.btnEmpleadoExit.Click += new System.EventHandler(this.btn_employee_exit_Click);
            // 
            // panelEmpleadoSuperior
            // 
            this.panelEmpleadoSuperior.BackColor = System.Drawing.Color.Gray;
            this.panelEmpleadoSuperior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEmpleadoSuperior.Controls.Add(this.btnSearch);
            this.panelEmpleadoSuperior.Controls.Add(this.txbSearch);
            this.panelEmpleadoSuperior.Controls.Add(this.btnNuevo);
            this.panelEmpleadoSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelEmpleadoSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelEmpleadoSuperior.Name = "panelEmpleadoSuperior";
            this.panelEmpleadoSuperior.Size = new System.Drawing.Size(1041, 46);
            this.panelEmpleadoSuperior.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(947, 12);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 22);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(695, 13);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(235, 23);
            this.txbSearch.TabIndex = 1;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNuevo.FlatAppearance.BorderSize = 3;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNuevo.Location = new System.Drawing.Point(4, 2);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(175, 39);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo empleado";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btn_new_employee_Click);
            // 
            // Legajo
            // 
            this.Legajo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Legajo.DataPropertyName = "Legajo";
            this.Legajo.Frozen = true;
            this.Legajo.HeaderText = "Legajo";
            this.Legajo.MinimumWidth = 80;
            this.Legajo.Name = "Legajo";
            this.Legajo.ReadOnly = true;
            this.Legajo.Width = 80;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.Frozen = true;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 200;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.Frozen = true;
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 200;
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 200;
            // 
            // DNI
            // 
            this.DNI.DataPropertyName = "DNI";
            this.DNI.Frozen = true;
            this.DNI.HeaderText = "DNI";
            this.DNI.MinimumWidth = 200;
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            this.DNI.Width = 200;
            // 
            // Domicilio
            // 
            this.Domicilio.DataPropertyName = "Domicilio";
            this.Domicilio.Frozen = true;
            this.Domicilio.HeaderText = "Domicilio";
            this.Domicilio.MinimumWidth = 200;
            this.Domicilio.Name = "Domicilio";
            this.Domicilio.ReadOnly = true;
            this.Domicilio.Width = 200;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.DataPropertyName = "FechaNacimiento";
            this.FechaNacimiento.Frozen = true;
            this.FechaNacimiento.HeaderText = "Fecha de Nacimiento";
            this.FechaNacimiento.MinimumWidth = 100;
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.ReadOnly = true;
            this.FechaNacimiento.Width = 132;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 576);
            this.Controls.Add(this.Panel_Empleados);
            this.Controls.Add(this.panelBot);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panelTop.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.Panel_Empleados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.panelEmpleadoInferior.ResumeLayout(false);
            this.panelEmpleadoSuperior.ResumeLayout(false);
            this.panelEmpleadoSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelTop;
        private Panel panelLeft;
        private Button btnProductos;
        private Button btnEmpleados;
        private Button btnClientes;
        private Button btnVentas;
        private Panel panelBot;
        private Panel panel1;
        private Panel Panel_Empleados;
        private Panel panelEmpleadoSuperior;
        private Panel panelEmpleadoInferior;
        private Button btnEmpleadoExit;
        private Button btnSearch;
        private TextBox txbSearch;
        private Button btnNuevo;
        private Button btnExit;
        private Button btnMinimize;
        private DataGridView dgvEmpleados;
        private DataGridViewTextBoxColumn Legajo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn Domicilio;
        private DataGridViewTextBoxColumn FechaNacimiento;
    }
}