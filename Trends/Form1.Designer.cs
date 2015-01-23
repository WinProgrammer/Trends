namespace Trends
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
			this.btnSayHello = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnSayHello
			// 
			this.btnSayHello.Location = new System.Drawing.Point(49, 54);
			this.btnSayHello.Name = "btnSayHello";
			this.btnSayHello.Size = new System.Drawing.Size(75, 23);
			this.btnSayHello.TabIndex = 0;
			this.btnSayHello.Text = "Say Hello";
			this.btnSayHello.UseVisualStyleBackColor = true;
			this.btnSayHello.Click += new System.EventHandler(this.btnSayHello_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(572, 386);
			this.Controls.Add(this.btnSayHello);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Trends";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnSayHello;
	}
}

