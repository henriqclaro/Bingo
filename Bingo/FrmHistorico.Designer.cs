namespace Bingo
{
    partial class FrmHistorico
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
            this.lbxHistorico = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbxHistorico
            // 
            this.lbxHistorico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbxHistorico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.lbxHistorico.ForeColor = System.Drawing.Color.White;
            this.lbxHistorico.FormattingEnabled = true;
            this.lbxHistorico.Location = new System.Drawing.Point(13, 13);
            this.lbxHistorico.Name = "lbxHistorico";
            this.lbxHistorico.Size = new System.Drawing.Size(327, 420);
            this.lbxHistorico.TabIndex = 0;
            // 
            // FrmHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(356, 450);
            this.Controls.Add(this.lbxHistorico);
            this.Name = "FrmHistorico";
            this.Text = "FrmHistorico";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxHistorico;
    }
}