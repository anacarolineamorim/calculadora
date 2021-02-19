
namespace calculadora_2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.campo1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.radiosomar = new System.Windows.Forms.RadioButton();
            this.radiomultiplicar = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // campo1
            // 
            this.campo1.Location = new System.Drawing.Point(127, 23);
            this.campo1.Name = "campo1";
            this.campo1.Size = new System.Drawing.Size(271, 20);
            this.campo1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(127, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(271, 20);
            this.textBox2.TabIndex = 2;
            // 
            // radiosomar
            // 
            this.radiosomar.AutoSize = true;
            this.radiosomar.Location = new System.Drawing.Point(249, 206);
            this.radiosomar.Name = "radiosomar";
            this.radiosomar.Size = new System.Drawing.Size(53, 17);
            this.radiosomar.TabIndex = 3;
            this.radiosomar.TabStop = true;
            this.radiosomar.Text = "somar";
            this.radiosomar.UseVisualStyleBackColor = true;
            this.radiosomar.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radiomultiplicar
            // 
            this.radiomultiplicar.AutoSize = true;
            this.radiomultiplicar.Location = new System.Drawing.Point(358, 217);
            this.radiomultiplicar.Name = "radiomultiplicar";
            this.radiomultiplicar.Size = new System.Drawing.Size(71, 17);
            this.radiomultiplicar.TabIndex = 4;
            this.radiomultiplicar.TabStop = true;
            this.radiomultiplicar.Text = "multiplicar";
            this.radiomultiplicar.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(358, 284);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(52, 17);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "dividir";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(504, 254);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(72, 17);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "subtracao";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radiomultiplicar);
            this.Controls.Add(this.radiosomar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.campo1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox campo1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton radiosomar;
        private System.Windows.Forms.RadioButton radiomultiplicar;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
    }
}

