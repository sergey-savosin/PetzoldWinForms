/*
 * Created by SharpDevelop.
 * User: Шелли
 * Date: 05.01.2019
 * Time: 15:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace KnownColorSample3
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormPaint(object sender, PaintEventArgs e)
		{
			ShowPropertiesOfSlateBlue(e);
		}
		
		private void ShowPropertiesOfSlateBlue(PaintEventArgs e)
		{
			Color slateBlue = Color.FromName("SlateBlue");
			byte g = slateBlue.G;
			byte b = slateBlue.B;
			byte r = slateBlue.R;
			byte a = slateBlue.A;
			string text = String.Format("Slate Blue has these ARGB values: Alpha:{0}, " +
			               "red:{1}, green: {2}, blue {3}", new object[]{ a, r, g, b });
			e.Graphics.DrawString(text, 
				new Font(this.Font, FontStyle.Italic), 
				new SolidBrush(slateBlue), 
				new RectangleF(new PointF(0.0F, 0.0F), this.Size));
		}
	}
}
