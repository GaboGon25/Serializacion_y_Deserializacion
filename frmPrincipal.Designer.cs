namespace Serializacion_y_Deserializacion
{
    partial class frmPrincipal
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
            btnXML = new Button();
            btnJSON = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.125F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(96, 99);
            label1.Name = "label1";
            label1.Size = new Size(761, 78);
            label1.TabIndex = 0;
            label1.Text = "Escoga el tipo de formato ";
            // 
            // btnXML
            // 
            btnXML.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnXML.Location = new Point(241, 549);
            btnXML.Name = "btnXML";
            btnXML.Size = new Size(394, 125);
            btnXML.TabIndex = 1;
            btnXML.Text = "XML";
            btnXML.UseVisualStyleBackColor = true;
            btnXML.Click += btnXML_Click;
            // 
            // btnJSON
            // 
            btnJSON.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnJSON.ForeColor = SystemColors.ActiveCaptionText;
            btnJSON.Location = new Point(241, 297);
            btnJSON.Name = "btnJSON";
            btnJSON.Size = new Size(394, 125);
            btnJSON.TabIndex = 2;
            btnJSON.Text = "JSON";
            btnJSON.UseVisualStyleBackColor = true;
            btnJSON.Click += btnJSON_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 884);
            Controls.Add(btnJSON);
            Controls.Add(btnXML);
            Controls.Add(label1);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnXML;
        private Button btnJSON;
    }
}