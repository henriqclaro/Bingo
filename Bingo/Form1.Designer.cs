namespace Bingo
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.numQtd = new System.Windows.Forms.NumericUpDown();
            this.btnInciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numQtd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantidade de Cartelas:";
            // 
            // numQtd
            // 
            this.numQtd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.numQtd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.numQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQtd.ForeColor = System.Drawing.Color.White;
            this.numQtd.Location = new System.Drawing.Point(65, 63);
            this.numQtd.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numQtd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQtd.Name = "numQtd";
            this.numQtd.Size = new System.Drawing.Size(166, 35);
            this.numQtd.TabIndex = 1;
            this.numQtd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnInciar
            // 
            this.btnInciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnInciar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnInciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInciar.Location = new System.Drawing.Point(17, 123);
            this.btnInciar.Name = "btnInciar";
            this.btnInciar.Size = new System.Drawing.Size(268, 45);
            this.btnInciar.TabIndex = 2;
            this.btnInciar.Text = "Iniciar";
            this.btnInciar.UseVisualStyleBackColor = true;
            this.btnInciar.Click += new System.EventHandler(this.btnInciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(297, 180);
            this.Controls.Add(this.btnInciar);
            this.Controls.Add(this.numQtd);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numQtd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numQtd;
        private System.Windows.Forms.Button btnInciar;
    }
}

