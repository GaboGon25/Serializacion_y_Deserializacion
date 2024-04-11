﻿namespace Serializacion_y_Deserializacion
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
            btnInsertarJSON.Location = new Point(565, 807);
            btnInsertarJSON.Name = "btnInsertarJSON";
            btnInsertarJSON.Size = new Size(174, 107);
            btnInsertarJSON.TabIndex = 26;
            btnInsertarJSON.Text = "INSERTAR";
            btnInsertarJSON.UseVisualStyleBackColor = true;
            // 
            // btnDeserializarJSON
            // 
            btnDeserializarJSON.Location = new Point(318, 807);
            btnDeserializarJSON.Name = "btnDeserializarJSON";
            btnDeserializarJSON.Size = new Size(193, 107);
            btnDeserializarJSON.TabIndex = 25;
            btnDeserializarJSON.Text = "DESERIALIZAR";
            btnDeserializarJSON.UseVisualStyleBackColor = true;
            // 
            // btnSerializarJSON
            // 
            btnSerializarJSON.Location = new Point(73, 807);
            btnSerializarJSON.Name = "btnSerializarJSON";
            btnSerializarJSON.Size = new Size(197, 107);
            btnSerializarJSON.TabIndex = 24;
            btnSerializarJSON.Text = "SERIALIZAR";
            btnSerializarJSON.UseVisualStyleBackColor = true;
            // 
            // dgvJSON
            // 
            dgvJSON.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJSON.Location = new Point(73, 526);
            dgvJSON.Name = "dgvJSON";
            dgvJSON.RowHeadersWidth = 82;
            dgvJSON.Size = new Size(869, 244);
            dgvJSON.TabIndex = 23;
            // 
            // txtSaldo
            // 
            txtSaldo.Location = new Point(306, 408);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(544, 39);
            txtSaldo.TabIndex = 22;
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Location = new Point(306, 304);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(544, 39);
            txtPrimerApellido.TabIndex = 21;
            // 
            // txtPrimerNombre
            // 
            txtPrimerNombre.Location = new Point(306, 210);
            txtPrimerNombre.Name = "txtPrimerNombre";
            txtPrimerNombre.Size = new Size(544, 39);
            txtPrimerNombre.TabIndex = 20;
            // 
            // txtCuenta
            // 
            txtCuenta.Location = new Point(306, 120);
            txtCuenta.Name = "txtCuenta";
            txtCuenta.Size = new Size(544, 39);
            txtCuenta.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(426, 30);
            label5.Name = "label5";
            label5.Size = new Size(150, 65);
            label5.TabIndex = 18;
            label5.Text = "JSON";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(97, 411);
            label4.Name = "label4";
            label4.Size = new Size(73, 32);
            label4.TabIndex = 17;
            label4.Text = "Saldo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 311);
            label3.Name = "label3";
            label3.Size = new Size(178, 32);
            label3.TabIndex = 16;
            label3.Text = "Primer Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 210);
            label2.Name = "label2";
            label2.Size = new Size(178, 32);
            label2.TabIndex = 15;
            label2.Text = "Primer Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 114);
            label1.Name = "label1";
            label1.Size = new Size(90, 32);
            label1.TabIndex = 14;
            label1.Text = "Cuenta";
            // 
            // frmJSON
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 970);
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