namespace Serializacion_y_Deserializacion
{
    partial class frmJSON
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
            btnInsertarJSON = new Button();
            btnDeserializarJSON = new Button();
            btnSerializarJSON = new Button();
            dgvJSON = new DataGridView();
            txtSaldo = new TextBox();
            txtPrimerApellido = new TextBox();
            txtPrimerNombre = new TextBox();
            txtCuenta = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvJSON).BeginInit();
            SuspendLayout();
            // 
            // btnInsertarJSON
            // 
            btnInsertarJSON.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnInsertarJSON.Location = new Point(565, 806);
            btnInsertarJSON.Margin = new Padding(4, 2, 4, 2);
            btnInsertarJSON.Name = "btnInsertarJSON";
            btnInsertarJSON.Size = new Size(175, 107);
            btnInsertarJSON.TabIndex = 26;
            btnInsertarJSON.Text = "INSERTAR";
            btnInsertarJSON.UseVisualStyleBackColor = true;
            btnInsertarJSON.Click += btnInsertarJSON_Click;
            // 
            // btnDeserializarJSON
            // 
            btnDeserializarJSON.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnDeserializarJSON.Location = new Point(318, 806);
            btnDeserializarJSON.Margin = new Padding(4, 2, 4, 2);
            btnDeserializarJSON.Name = "btnDeserializarJSON";
            btnDeserializarJSON.Size = new Size(193, 107);
            btnDeserializarJSON.TabIndex = 25;
            btnDeserializarJSON.Text = "DESERIALIZAR";
            btnDeserializarJSON.UseVisualStyleBackColor = true;
            btnDeserializarJSON.Click += btnDeserializarJSON_Click;
            // 
            // btnSerializarJSON
            // 
            btnSerializarJSON.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSerializarJSON.Location = new Point(72, 806);
            btnSerializarJSON.Margin = new Padding(4, 2, 4, 2);
            btnSerializarJSON.Name = "btnSerializarJSON";
            btnSerializarJSON.Size = new Size(197, 107);
            btnSerializarJSON.TabIndex = 24;
            btnSerializarJSON.Text = "SERIALIZAR";
            btnSerializarJSON.UseVisualStyleBackColor = true;
            btnSerializarJSON.Click += btnSerializarJSON_Click;
            // 
            // dgvJSON
            // 
            dgvJSON.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJSON.Location = new Point(72, 527);
            dgvJSON.Margin = new Padding(4, 2, 4, 2);
            dgvJSON.Name = "dgvJSON";
            dgvJSON.RowHeadersWidth = 82;
            dgvJSON.Size = new Size(869, 243);
            dgvJSON.TabIndex = 23;
            // 
            // txtSaldo
            // 
            txtSaldo.Location = new Point(306, 407);
            txtSaldo.Margin = new Padding(4, 2, 4, 2);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(544, 39);
            txtSaldo.TabIndex = 22;
            txtSaldo.KeyPress += txtSaldo_KeyPress;
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Location = new Point(306, 303);
            txtPrimerApellido.Margin = new Padding(4, 2, 4, 2);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(544, 39);
            txtPrimerApellido.TabIndex = 21;
            txtPrimerApellido.KeyPress += txtPrimerApellido_KeyPress;
            // 
            // txtPrimerNombre
            // 
            txtPrimerNombre.Location = new Point(306, 209);
            txtPrimerNombre.Margin = new Padding(4, 2, 4, 2);
            txtPrimerNombre.Name = "txtPrimerNombre";
            txtPrimerNombre.Size = new Size(544, 39);
            txtPrimerNombre.TabIndex = 20;
            txtPrimerNombre.KeyPress += txtPrimerNombre_KeyPress;
            // 
            // txtCuenta
            // 
            txtCuenta.Location = new Point(306, 119);
            txtCuenta.Margin = new Padding(4, 2, 4, 2);
            txtCuenta.Name = "txtCuenta";
            txtCuenta.Size = new Size(544, 39);
            txtCuenta.TabIndex = 19;
            txtCuenta.KeyPress += txtCuenta_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(425, 30);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(150, 65);
            label5.TabIndex = 18;
            label5.Text = "JSON";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(97, 412);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(73, 32);
            label4.TabIndex = 17;
            label4.Text = "Saldo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 311);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(178, 32);
            label3.TabIndex = 16;
            label3.Text = "Primer Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 209);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(178, 32);
            label2.TabIndex = 15;
            label2.Text = "Primer Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 113);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(90, 32);
            label1.TabIndex = 14;
            label1.Text = "Cuenta";
            // 
            // frmJSON
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 971);
            Controls.Add(btnInsertarJSON);
            Controls.Add(btnDeserializarJSON);
            Controls.Add(btnSerializarJSON);
            Controls.Add(dgvJSON);
            Controls.Add(txtSaldo);
            Controls.Add(txtPrimerApellido);
            Controls.Add(txtPrimerNombre);
            Controls.Add(txtCuenta);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 2, 4, 2);
            Name = "frmJSON";
            Text = "frmJSON";
            ((System.ComponentModel.ISupportInitialize)dgvJSON).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnInsertarJSON;
        private Button btnDeserializarJSON;
        private Button btnSerializarJSON;
        private DataGridView dgvJSON;
        private TextBox txtSaldo;
        private TextBox txtPrimerApellido;
        private TextBox txtPrimerNombre;
        private TextBox txtCuenta;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}