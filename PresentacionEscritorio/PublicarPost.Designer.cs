
namespace PresentacionEscritorio
{
    partial class PublicarPost
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
            this.txtContenido = new System.Windows.Forms.TextBox();
            this.btnPublicarPost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contenido";
            // 
            // txtContenido
            // 
            this.txtContenido.Location = new System.Drawing.Point(103, 24);
            this.txtContenido.Multiline = true;
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(279, 110);
            this.txtContenido.TabIndex = 1;
            // 
            // btnPublicarPost
            // 
            this.btnPublicarPost.Location = new System.Drawing.Point(136, 168);
            this.btnPublicarPost.Name = "btnPublicarPost";
            this.btnPublicarPost.Size = new System.Drawing.Size(119, 23);
            this.btnPublicarPost.TabIndex = 2;
            this.btnPublicarPost.Text = "Publicar";
            this.btnPublicarPost.UseVisualStyleBackColor = true;
            this.btnPublicarPost.Click += new System.EventHandler(this.btnPublicarPost_Click);
            // 
            // PublicarPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(409, 214);
            this.Controls.Add(this.btnPublicarPost);
            this.Controls.Add(this.txtContenido);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "PublicarPost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PublicarPost";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PublicarPost_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContenido;
        private System.Windows.Forms.Button btnPublicarPost;
    }
}