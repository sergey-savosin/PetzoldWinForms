/*
 * Created by SharpDevelop.
 * User: Шелли
 * Date: 04.01.2019
 * Time: 22:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ComboBoxBind
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ComboBox combo;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.combo = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// combo
			// 
			this.combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.combo.FormattingEnabled = true;
			this.combo.Location = new System.Drawing.Point(12, 12);
			this.combo.Name = "combo";
			this.combo.Size = new System.Drawing.Size(260, 21);
			this.combo.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.combo);
			this.Name = "MainForm";
			this.Text = "ComboBoxBind";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);

		}
	}
}
