
namespace Resistence.Forms
{
    partial class CodeColors
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
            this.colorGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.colorGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // colorGridView
            // 
            this.colorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.colorGridView.Location = new System.Drawing.Point(170, 139);
            this.colorGridView.Name = "colorGridView";
            this.colorGridView.Size = new System.Drawing.Size(742, 353);
            this.colorGridView.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(205, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(665, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ahora que ya sabes para qué sirve cada banda, vamos a ver el código de colores de" +
    " las resistencias.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(53, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(197, 17);
            this.label12.TabIndex = 22;
            this.label12.Text = "bien la función de cada una:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(53, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(978, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "por lo que dependiendo del tipo de resistencia, cada banda va a significar una co" +
    "sa, por eso, a continuación tienes un resumen para que entiendas ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(53, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(973, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Para calcular el valor de una resistencia lo primero que tenemos que hacer es ide" +
    "ntificar el número de bandas que tiene. Pueden ser 4, 5 o 6 bandas ";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(327, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(405, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "El código de colores de las resistencias";
            // 
            // CodeColors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 610);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colorGridView);
            this.Name = "CodeColors";
            this.Text = "CodeColors";
            this.Load += new System.EventHandler(this.CodeColors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.colorGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView colorGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
    }
}