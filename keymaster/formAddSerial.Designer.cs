namespace keymaster
{
	partial class formAddSerial
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
			this.comboBoxProgram = new System.Windows.Forms.ComboBox();
			this.textBoxSerial = new System.Windows.Forms.TextBox();
			this.buttonNewProgram = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOK = new System.Windows.Forms.Button();
			this.textBoxHistory = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// comboBoxProgram
			// 
			this.comboBoxProgram.FormattingEnabled = true;
			this.comboBoxProgram.Location = new System.Drawing.Point(12, 12);
			this.comboBoxProgram.Name = "comboBoxProgram";
			this.comboBoxProgram.Size = new System.Drawing.Size(244, 21);
			this.comboBoxProgram.TabIndex = 0;
			// 
			// textBoxSerial
			// 
			this.textBoxSerial.Location = new System.Drawing.Point(12, 39);
			this.textBoxSerial.Name = "textBoxSerial";
			this.textBoxSerial.Size = new System.Drawing.Size(337, 20);
			this.textBoxSerial.TabIndex = 1;
			this.textBoxSerial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// buttonNewProgram
			// 
			this.buttonNewProgram.Location = new System.Drawing.Point(262, 10);
			this.buttonNewProgram.Name = "buttonNewProgram";
			this.buttonNewProgram.Size = new System.Drawing.Size(87, 23);
			this.buttonNewProgram.TabIndex = 2;
			this.buttonNewProgram.Text = "New Program";
			this.buttonNewProgram.UseVisualStyleBackColor = true;
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(12, 125);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(87, 23);
			this.buttonCancel.TabIndex = 3;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(262, 125);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(87, 23);
			this.buttonOK.TabIndex = 4;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			// 
			// textBoxHistory
			// 
			this.textBoxHistory.Location = new System.Drawing.Point(12, 65);
			this.textBoxHistory.Multiline = true;
			this.textBoxHistory.Name = "textBoxHistory";
			this.textBoxHistory.Size = new System.Drawing.Size(337, 54);
			this.textBoxHistory.TabIndex = 5;
			// 
			// formAddSerial
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(361, 160);
			this.Controls.Add(this.textBoxHistory);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonNewProgram);
			this.Controls.Add(this.textBoxSerial);
			this.Controls.Add(this.comboBoxProgram);
			this.Name = "formAddSerial";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add Serial";
			this.Load += new System.EventHandler(this.formAddSerial_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBoxProgram;
		private System.Windows.Forms.TextBox textBoxSerial;
		private System.Windows.Forms.Button buttonNewProgram;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.TextBox textBoxHistory;
	}
}