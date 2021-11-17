
namespace PresentacionEscritorio
{
    partial class Principal
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
            this.lblPost = new System.Windows.Forms.Label();
            this.pnlPost1 = new System.Windows.Forms.Panel();
            this.txtContenido = new System.Windows.Forms.TextBox();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.lblLikes = new System.Windows.Forms.Label();
            this.lblFechaPublicacion = new System.Windows.Forms.Label();
            this.lblNickname = new System.Windows.Forms.Label();
            this.dgvPosts = new System.Windows.Forms.DataGridView();
            this.btnPublicarPost = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnDarLike = new System.Windows.Forms.Button();
            this.btnComentar = new System.Windows.Forms.Button();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.btnPublicarComentario = new System.Windows.Forms.Button();
            this.pnlPost1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPost
            // 
            this.lblPost.AutoSize = true;
            this.lblPost.Location = new System.Drawing.Point(404, 24);
            this.lblPost.Name = "lblPost";
            this.lblPost.Size = new System.Drawing.Size(36, 13);
            this.lblPost.TabIndex = 0;
            this.lblPost.Text = "POST";
            // 
            // pnlPost1
            // 
            this.pnlPost1.Controls.Add(this.txtContenido);
            this.pnlPost1.Controls.Add(this.lblComentarios);
            this.pnlPost1.Controls.Add(this.lblLikes);
            this.pnlPost1.Controls.Add(this.lblFechaPublicacion);
            this.pnlPost1.Controls.Add(this.lblNickname);
            this.pnlPost1.Location = new System.Drawing.Point(26, 251);
            this.pnlPost1.Name = "pnlPost1";
            this.pnlPost1.Size = new System.Drawing.Size(454, 166);
            this.pnlPost1.TabIndex = 0;
            // 
            // txtContenido
            // 
            this.txtContenido.Enabled = false;
            this.txtContenido.Location = new System.Drawing.Point(15, 29);
            this.txtContenido.Multiline = true;
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(416, 110);
            this.txtContenido.TabIndex = 4;
            // 
            // lblComentarios
            // 
            this.lblComentarios.AutoSize = true;
            this.lblComentarios.Location = new System.Drawing.Point(74, 142);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(71, 13);
            this.lblComentarios.TabIndex = 3;
            this.lblComentarios.Text = "Comentarios: ";
            // 
            // lblLikes
            // 
            this.lblLikes.AutoSize = true;
            this.lblLikes.Location = new System.Drawing.Point(12, 142);
            this.lblLikes.Name = "lblLikes";
            this.lblLikes.Size = new System.Drawing.Size(38, 13);
            this.lblLikes.TabIndex = 2;
            this.lblLikes.Text = "Likes: ";
            // 
            // lblFechaPublicacion
            // 
            this.lblFechaPublicacion.AutoSize = true;
            this.lblFechaPublicacion.Location = new System.Drawing.Point(378, 13);
            this.lblFechaPublicacion.Name = "lblFechaPublicacion";
            this.lblFechaPublicacion.Size = new System.Drawing.Size(13, 13);
            this.lblFechaPublicacion.TabIndex = 1;
            this.lblFechaPublicacion.Text = "--";
            // 
            // lblNickname
            // 
            this.lblNickname.AutoSize = true;
            this.lblNickname.Location = new System.Drawing.Point(12, 13);
            this.lblNickname.Name = "lblNickname";
            this.lblNickname.Size = new System.Drawing.Size(13, 13);
            this.lblNickname.TabIndex = 0;
            this.lblNickname.Text = "--";
            // 
            // dgvPosts
            // 
            this.dgvPosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosts.Location = new System.Drawing.Point(26, 52);
            this.dgvPosts.Name = "dgvPosts";
            this.dgvPosts.Size = new System.Drawing.Size(783, 178);
            this.dgvPosts.TabIndex = 1;
            // 
            // btnPublicarPost
            // 
            this.btnPublicarPost.Location = new System.Drawing.Point(496, 251);
            this.btnPublicarPost.Name = "btnPublicarPost";
            this.btnPublicarPost.Size = new System.Drawing.Size(153, 23);
            this.btnPublicarPost.TabIndex = 2;
            this.btnPublicarPost.Text = "Publicar Post";
            this.btnPublicarPost.UseVisualStyleBackColor = true;
            this.btnPublicarPost.Click += new System.EventHandler(this.btnPublicarPost_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(584, 14);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(206, 23);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnDarLike
            // 
            this.btnDarLike.Location = new System.Drawing.Point(496, 280);
            this.btnDarLike.Name = "btnDarLike";
            this.btnDarLike.Size = new System.Drawing.Size(153, 23);
            this.btnDarLike.TabIndex = 4;
            this.btnDarLike.Text = "Like";
            this.btnDarLike.UseVisualStyleBackColor = true;
            this.btnDarLike.Click += new System.EventHandler(this.btnDarLike_Click);
            // 
            // btnComentar
            // 
            this.btnComentar.Location = new System.Drawing.Point(496, 309);
            this.btnComentar.Name = "btnComentar";
            this.btnComentar.Size = new System.Drawing.Size(153, 23);
            this.btnComentar.TabIndex = 5;
            this.btnComentar.Text = "Comentar";
            this.btnComentar.UseVisualStyleBackColor = true;
            this.btnComentar.Click += new System.EventHandler(this.btnComentar_Click);
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(665, 297);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(144, 52);
            this.txtComentario.TabIndex = 6;
            this.txtComentario.Visible = false;
            // 
            // btnPublicarComentario
            // 
            this.btnPublicarComentario.Location = new System.Drawing.Point(665, 355);
            this.btnPublicarComentario.Name = "btnPublicarComentario";
            this.btnPublicarComentario.Size = new System.Drawing.Size(144, 23);
            this.btnPublicarComentario.TabIndex = 7;
            this.btnPublicarComentario.Text = "Publicar Comentario";
            this.btnPublicarComentario.UseVisualStyleBackColor = true;
            this.btnPublicarComentario.Visible = false;
            this.btnPublicarComentario.Click += new System.EventHandler(this.btnPublicarComentario_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 457);
            this.Controls.Add(this.btnPublicarComentario);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.btnComentar);
            this.Controls.Add(this.btnDarLike);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnPublicarPost);
            this.Controls.Add(this.dgvPosts);
            this.Controls.Add(this.pnlPost1);
            this.Controls.Add(this.lblPost);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.pnlPost1.ResumeLayout(false);
            this.pnlPost1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPost;
        private System.Windows.Forms.Panel pnlPost1;
        private System.Windows.Forms.TextBox txtContenido;
        private System.Windows.Forms.Label lblComentarios;
        private System.Windows.Forms.Label lblLikes;
        private System.Windows.Forms.Label lblFechaPublicacion;
        private System.Windows.Forms.Label lblNickname;
        private System.Windows.Forms.DataGridView dgvPosts;
        private System.Windows.Forms.Button btnPublicarPost;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnDarLike;
        private System.Windows.Forms.Button btnComentar;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Button btnPublicarComentario;
    }
}