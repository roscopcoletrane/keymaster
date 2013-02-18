namespace keymaster
{
	partial class formMain
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
			this.listBoxProgram = new System.Windows.Forms.ListBox();
			this.listBoxSerials = new System.Windows.Forms.ListBox();
			this.listBoxHistory = new System.Windows.Forms.ListBox();
			this.buttonAddSerial = new System.Windows.Forms.Button();
			this.buttonUpdateSerial = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listBoxProgram
			// 
			this.listBoxProgram.FormattingEnabled = true;
			this.listBoxProgram.Location = new System.Drawing.Point(12, 12);
			this.listBoxProgram.Name = "listBoxProgram";
			this.listBoxProgram.Size = new System.Drawing.Size(254, 433);
			this.listBoxProgram.TabIndex = 0;
			// 
			// listBoxSerials
			// 
			this.listBoxSerials.FormattingEnabled = true;
			this.listBoxSerials.Location = new System.Drawing.Point(272, 12);
			this.listBoxSerials.Name = "listBoxSerials";
			this.listBoxSerials.Size = new System.Drawing.Size(214, 394);
			this.listBoxSerials.TabIndex = 1;
			// 
			// listBoxHistory
			// 
			this.listBoxHistory.FormattingEnabled = true;
			this.listBoxHistory.Location = new System.Drawing.Point(492, 12);
			this.listBoxHistory.Name = "listBoxHistory";
			this.listBoxHistory.Size = new System.Drawing.Size(410, 394);
			this.listBoxHistory.TabIndex = 2;
			// 
			// buttonAddSerial
			// 
			this.buttonAddSerial.Location = new System.Drawing.Point(272, 413);
			this.buttonAddSerial.Name = "buttonAddSerial";
			this.buttonAddSerial.Size = new System.Drawing.Size(214, 32);
			this.buttonAddSerial.TabIndex = 3;
			this.buttonAddSerial.Text = "Add Serial";
			this.buttonAddSerial.UseVisualStyleBackColor = true;
			this.buttonAddSerial.Click += new System.EventHandler(this.buttonAddSerial_Click);
			// 
			// buttonUpdateSerial
			// 
			this.buttonUpdateSerial.Location = new System.Drawing.Point(492, 412);
			this.buttonUpdateSerial.Name = "buttonUpdateSerial";
			this.buttonUpdateSerial.Size = new System.Drawing.Size(410, 32);
			this.buttonUpdateSerial.TabIndex = 4;
			this.buttonUpdateSerial.Text = "Update Serial";
			this.buttonUpdateSerial.UseVisualStyleBackColor = true;
			// 
			// formMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(914, 456);
			this.Controls.Add(this.buttonUpdateSerial);
			this.Controls.Add(this.buttonAddSerial);
			this.Controls.Add(this.listBoxHistory);
			this.Controls.Add(this.listBoxSerials);
			this.Controls.Add(this.listBoxProgram);
			this.Name = "formMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Keymaster";
			this.Load += new System.EventHandler(this.formMain_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox listBoxProgram;
		private System.Windows.Forms.ListBox listBoxSerials;
		private System.Windows.Forms.ListBox listBoxHistory;
		private System.Windows.Forms.Button buttonAddSerial;
		private System.Windows.Forms.Button buttonUpdateSerial;
	}
}

