namespace MyApp
{
    partial class Form2
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
            textNombre = new TextBox();
            textCorreo = new TextBox();
            buttActualizar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 48);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 153);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "Correo";
            // 
            // textNombre
            // 
            textNombre.Location = new Point(86, 89);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(125, 27);
            textNombre.TabIndex = 2;
            // 
            // textCorreo
            // 
            textCorreo.Location = new Point(86, 202);
            textCorreo.Name = "textCorreo";
            textCorreo.Size = new Size(284, 27);
            textCorreo.TabIndex = 3;
            // 
            // buttActualizar
            // 
            buttActualizar.Location = new Point(480, 127);
            buttActualizar.Name = "buttActualizar";
            buttActualizar.Size = new Size(94, 29);
            buttActualizar.TabIndex = 4;
            buttActualizar.Text = "Actualizar";
            buttActualizar.UseVisualStyleBackColor = true;
            buttActualizar.Click += buttActualizar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 351);
            Controls.Add(buttActualizar);
            Controls.Add(textCorreo);
            Controls.Add(textNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Modificar";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textNombre;
        private TextBox textCorreo;
        private Button buttActualizar;
    }
}