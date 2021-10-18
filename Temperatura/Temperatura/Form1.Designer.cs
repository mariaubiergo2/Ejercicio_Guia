
namespace Temperatura
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.celsiusTxt = new System.Windows.Forms.TextBox();
            this.FTempTxt = new System.Windows.Forms.Label();
            this.ConvertBtn = new System.Windows.Forms.Button();
            this.CCBtn = new System.Windows.Forms.Button();
            this.fTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperatura en C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Temperatura en F";
            // 
            // celsiusTxt
            // 
            this.celsiusTxt.Location = new System.Drawing.Point(127, 106);
            this.celsiusTxt.Name = "celsiusTxt";
            this.celsiusTxt.Size = new System.Drawing.Size(100, 22);
            this.celsiusTxt.TabIndex = 2;
            // 
            // FTempTxt
            // 
            this.FTempTxt.AutoSize = true;
            this.FTempTxt.Location = new System.Drawing.Point(406, 109);
            this.FTempTxt.Name = "FTempTxt";
            this.FTempTxt.Size = new System.Drawing.Size(0, 17);
            this.FTempTxt.TabIndex = 3;
            // 
            // ConvertBtn
            // 
            this.ConvertBtn.Location = new System.Drawing.Point(137, 159);
            this.ConvertBtn.Name = "ConvertBtn";
            this.ConvertBtn.Size = new System.Drawing.Size(75, 23);
            this.ConvertBtn.TabIndex = 4;
            this.ConvertBtn.Text = "Convert";
            this.ConvertBtn.UseVisualStyleBackColor = true;
            this.ConvertBtn.Click += new System.EventHandler(this.ConvertBtn_Click);
            // 
            // CCBtn
            // 
            this.CCBtn.Location = new System.Drawing.Point(379, 157);
            this.CCBtn.Name = "CCBtn";
            this.CCBtn.Size = new System.Drawing.Size(75, 23);
            this.CCBtn.TabIndex = 6;
            this.CCBtn.Text = "Convert";
            this.CCBtn.UseVisualStyleBackColor = true;
            this.CCBtn.Click += new System.EventHandler(this.CCBtn_Click);
            // 
            // fTxt
            // 
            this.fTxt.Location = new System.Drawing.Point(369, 104);
            this.fTxt.Name = "fTxt";
            this.fTxt.Size = new System.Drawing.Size(100, 22);
            this.fTxt.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CCBtn);
            this.Controls.Add(this.fTxt);
            this.Controls.Add(this.ConvertBtn);
            this.Controls.Add(this.FTempTxt);
            this.Controls.Add(this.celsiusTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox celsiusTxt;
        private System.Windows.Forms.Label FTempTxt;
        private System.Windows.Forms.Button ConvertBtn;
        private System.Windows.Forms.Button CCBtn;
        private System.Windows.Forms.TextBox fTxt;
    }
}

