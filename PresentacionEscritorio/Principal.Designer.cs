
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
            this.dgvPosts = new System.Windows.Forms.DataGridView();
            this.btnPublicarPost = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnDarLike = new System.Windows.Forms.Button();
            this.btnComentar = new System.Windows.Forms.Button();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.btnPublicarComentario = new System.Windows.Forms.Button();
            this.btnVerComentarios = new System.Windows.Forms.Button();
            this.dgvComentarios = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComentarios)).BeginInit();
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
            this.btnPublicarPost.Location = new System.Drawing.Point(506, 295);
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
            this.btnDarLike.Location = new System.Drawing.Point(506, 324);
            this.btnDarLike.Name = "btnDarLike";
            this.btnDarLike.Size = new System.Drawing.Size(153, 23);
            this.btnDarLike.TabIndex = 4;
            this.btnDarLike.Text = "Like";
            this.btnDarLike.UseVisualStyleBackColor = true;
            this.btnDarLike.Click += new System.EventHandler(this.btnDarLike_Click);
            // 
            // btnComentar
            // 
            this.btnComentar.Location = new System.Drawing.Point(506, 353);
            this.btnComentar.Name = "btnComentar";
            this.btnComentar.Size = new System.Drawing.Size(153, 23);
            this.btnComentar.TabIndex = 5;
            this.btnComentar.Text = "Comentar";
            this.btnComentar.UseVisualStyleBackColor = true;
            this.btnComentar.Click += new System.EventHandler(this.btnComentar_Click);
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(684, 342);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(144, 52);
            this.txtComentario.TabIndex = 6;
            this.txtComentario.Visible = false;
            // 
            // btnPublicarComentario
            // 
            this.btnPublicarComentario.Location = new System.Drawing.Point(684, 400);
            this.btnPublicarComentario.Name = "btnPublicarComentario";
            this.btnPublicarComentario.Size = new System.Drawing.Size(144, 23);
            this.btnPublicarComentario.TabIndex = 7;
            this.btnPublicarComentario.Text = "Publicar Comentario";
            this.btnPublicarComentario.UseVisualStyleBackColor = true;
            this.btnPublicarComentario.Visible = false;
            this.btnPublicarComentario.Click += new System.EventHandler(this.btnPublicarComentario_Click);
            // 
            // btnVerComentarios
            // 
            this.btnVerComentarios.Location = new System.Drawing.Point(506, 382);
            this.btnVerComentarios.Name = "btnVerComentarios";
            this.btnVerComentarios.Size = new System.Drawing.Size(153, 23);
            this.btnVerComentarios.TabIndex = 8;
            this.btnVerComentarios.Text = "Ver comentarios";
            this.btnVerComentarios.UseVisualStyleBackColor = true;
            this.btnVerComentarios.Click += new System.EventHandler(this.btnVerComentarios_Click);
            // 
            // dgvComentarios
            // 
            this.dgvComentarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComentarios.Location = new System.Drawing.Point(26, 267);
            this.dgvComentarios.Name = "dgvComentarios";
            this.dgvComentarios.Size = new System.Drawing.Size(464, 178);
            this.dgvComentarios.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Comentarios";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 457);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvComentarios);
            this.Controls.Add(this.btnVerComentarios);
            this.Controls.Add(this.btnPublicarComentario);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.btnComentar);
            this.Controls.Add(this.btnDarLike);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnPublicarPost);
            this.Controls.Add(this.dgvPosts);
            this.Controls.Add(this.lblPost);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComentarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPost;
        private System.Windows.Forms.DataGridView dgvPosts;
        private System.Windows.Forms.Button btnPublicarPost;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnDarLike;
        private System.Windows.Forms.Button btnComentar;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Button btnPublicarComentario;
        private System.Windows.Forms.Button btnVerComentarios;
        private System.Windows.Forms.DataGridView dgvComentarios;
        private System.Windows.Forms.Label label1;
    }
}