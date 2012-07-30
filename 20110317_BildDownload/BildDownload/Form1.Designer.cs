namespace BildDownload
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txt_url = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_speichern = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(50, 40);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(426, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Herunterladen";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(50, 69);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(426, 233);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// txt_url
			// 
			this.txt_url.Location = new System.Drawing.Point(50, 14);
			this.txt_url.Name = "txt_url";
			this.txt_url.Size = new System.Drawing.Size(426, 20);
			this.txt_url.TabIndex = 2;
			this.txt_url.Text = "http://www.microsoft.com/germany/visualstudio/assets/images2010/basic_layout/vs20" +
				"10_logo.gif";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "URL:";
			// 
			// btn_speichern
			// 
			this.btn_speichern.Location = new System.Drawing.Point(328, 308);
			this.btn_speichern.Name = "btn_speichern";
			this.btn_speichern.Size = new System.Drawing.Size(148, 23);
			this.btn_speichern.TabIndex = 4;
			this.btn_speichern.Text = "Speichern";
			this.btn_speichern.UseVisualStyleBackColor = true;
			this.btn_speichern.Click += new System.EventHandler(this.btn_speichern_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(488, 349);
			this.Controls.Add(this.btn_speichern);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_url);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txt_url;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_speichern;
	}
}

