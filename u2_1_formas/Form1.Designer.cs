namespace u2_1_formas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblresultado = new System.Windows.Forms.Label();
            this.Cbox1 = new System.Windows.Forms.CheckBox();
            this.Rbox1 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(134, 92);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(178, 41);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Mostrar";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese su nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(134, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(178, 23);
            this.txtNombre.TabIndex = 2;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(349, 71);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(70, 15);
            this.lblresultado.TabIndex = 3;
            this.lblresultado.Text = "RESULTADO";
            // 
            // Cbox1
            // 
            this.Cbox1.AutoSize = true;
            this.Cbox1.Location = new System.Drawing.Point(12, 139);
            this.Cbox1.Name = "Cbox1";
            this.Cbox1.Size = new System.Drawing.Size(70, 19);
            this.Cbox1.TabIndex = 4;
            this.Cbox1.Text = "Hombre";
            this.Cbox1.UseVisualStyleBackColor = true;
            // 
            // Rbox1
            // 
            this.Rbox1.AutoSize = true;
            this.Rbox1.Location = new System.Drawing.Point(336, 139);
            this.Rbox1.Name = "Rbox1";
            this.Rbox1.Size = new System.Drawing.Size(56, 19);
            this.Rbox1.TabIndex = 5;
            this.Rbox1.TabStop = true;
            this.Rbox1.Text = "Mujer";
            this.Rbox1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(436, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 146);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 295);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Rbox1);
            this.Controls.Add(this.Cbox1);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn1;
        private Label label1;
        private TextBox txtNombre;
        private Label lblresultado;
        private CheckBox Cbox1;
        private RadioButton Rbox1;
        private PictureBox pictureBox1;
    }
}