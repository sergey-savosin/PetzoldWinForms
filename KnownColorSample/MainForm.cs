/*
 * Created by SharpDevelop.
 * User: Шелли
 * Date: 05.01.2019
 * Time: 15:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace KnownColorSample
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
		
		private void DisplayKnownColors(PaintEventArgs e)
		{
    
			// Get all the values from the KnownColor enumeration.
			System.Array colorsArray = Enum.GetValues(typeof(KnownColor));
			KnownColor[] allColors = new KnownColor[colorsArray.Length];

			Array.Copy(colorsArray, allColors, colorsArray.Length);

			// Loop through printing out the values' names in the colors 
			// they represent.
			float y = 0;
			float x = 10.0F;

			for (int i = 0; i < allColors.Length; i++) {

				// If x is a multiple of 30, start a new column.
				if (i > 0 && i % 30 == 0) {
					x += 105.0F;
					y = 15.0F;
				} else {
					// Otherwise, increment y by 15.
					y += 15.0F;
				}

				// Create a custom brush from the color and use it to draw
				// the brush's name.
				SolidBrush aBrush = 
					new SolidBrush(Color.FromName(allColors[i].ToString()));
				e.Graphics.DrawString(allColors[i].ToString(), 
					this.Font, aBrush, x, y);

				// Dispose of the custom brush.
				aBrush.Dispose();
			}

		}
		void MainFormPaint(object sender, PaintEventArgs e)
		{
			DisplayKnownColors(e);
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			this.BackColor = Color.FromKnownColor(KnownColor.Gray);
			this.Size = new Size(650, 550);
		}
	}
}
