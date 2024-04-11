namespace Serializacion_y_Deserializacion
{
    partial class frmXML
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtCuenta = new TextBox();
            txtPrimerNombre = new TextBox();
            txtPrimerApellido = new TextBox();
            txtSaldo = new TextBox();
            dgvXML = new DataGridView();
            btnSerializarXML = new Button();
            btnDeserializarXML = new Button();
            btnInsertarXML = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvXML).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 148);
            label1.Name = "label1";
            label1.Size = new Size(90, 32);
            label1.TabIndex = 0;
            label1.Text = "Cuenta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 244);
            label2.Name = "label2";
            label2.Size = new Size(178, 32);
            label2.TabIndex = 1;
            label2.Text = "Primer Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 345);
            label3.Name = "label3";
            label3.Size = new Size(178, 32);
            label3.TabIndex = 2;
            label3.Text = "Primer Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 445);
            label4.Name = "label4";
            label4.Size = new Size(73, 32);
            label4.TabIndex = 3;
            label4.Text = "Saldo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(449, 59);
            label5.Name = "label5";
            label5.Size = new Size(130, 65);
            label5.TabIndex = 4;
            label5.Text = "XML";
            // 
            // txtCuenta
            // 
            txtCuenta.Location = new Point(277, 154);
            txtCuenta.Name = "txtCuenta";
            txtCuenta.Size = new Size(544, 39);
            txtCuenta.TabIndex = 5;
            // 
            // txtPrimerNombre
            // 
            txtPrimerNombre.Location = new Point(277, 244);
            txtPrimerNombre.Name = "txtPrimerNombre";
            txtPrimerNombre.Size = new Size(544, 39);
            txtPrimerNombre.TabIndex = 6;
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Location = new Point(277, 338);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(544, 39);
            txtPrimerApellido.TabIndex = 7;
            // 
            // txtSaldo
            // 
            txtSaldo.Location = new Point(277, 442);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(544, 39);
            txtSaldo.TabIndex = 8;
            // 
            // dgvXML
            // 
            dgvXML.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvXML.Location = new Point(44, 560);
            dgvXML.Name = "dgvXML";
            dgvXML.RowHeadersWidth = 82;
            dgvXML.Size = new Size(869, 244);
            dgvXML.TabIndex = 9;
            // 
            // btnSerializarXML
            // 
            btnSerializarXML.Location = new Point(44, 841);
            btnSerializarXML.Name = "btnSerializarXML";
            btnSerializarXML.Size = new Size(197, 107);
            btnSerializarXML.TabIndex = 10;
            btnSerializarXML.Text = "SERIALIZAR";
            btnSerializarXML.UseVisualStyleBackColor = true;
            // 
            // btnDeserializarXML
            // 
            btnDeserializarXML.Location = new Point(289, 841);
            btnDeserializarXML.Name = "btnDeserializarXML";
            btnDeserializarXML.Size = new Size(193, 107);
            btnDeserializarXML.TabIndex = 11;
            btnDeserializarXML.Text = "DESERIALIZAR";
            btnDeserializarXML.UseVisualStyleBackColor = true;
            // 
            // btnInsertarXML
            // 
            btnInsertarXML.Location = new Point(536, 841);
            btnInsertarXML.Name = "btnInsertarXML";
            btnInsertarXML.Size = new Size(174, 107);
            btnInsertarXML.TabIndex = 12;
            btnInsertarXML.Text = "INSERTAR";
            btnInsertarXML.UseVisualStyleBackColor = true;
            // 
            // frmXML
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 997);
            Controls.Add(btnInsertarXML);
            Controls.Add(btnDeserializarXML);
            Controls.Add(btnSerializarXML);
            Controls.Add(dgvXML);
            Controls.Add(txtSaldo);
            Controls.Add(txtPrimerApellido);
            Controls.Add(txtPrimerNombre);
            Controls.Add(txtCuenta);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmXML";
            Text = "frmXML";
            ((System.ComponentModel.ISupportInitialize)dgvXML).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtCuenta;
        private TextBox txtPrimerNombre;
        private TextBox txtPrimerApellido;
        private TextBox txtSaldo;
        private DataGridView dgvXML;
        private Button btnSerializarXML;
        private Button btnDeserializarXML;
        private Button btnInsertarXML;
    }
}