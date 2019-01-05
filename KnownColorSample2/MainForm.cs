/*
 * Created by SharpDevelop.
 * User: Шелли
 * Date: 05.01.2019
 * Time: 15:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace KnownColorSample2
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
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void MainFormPaint(object sender, PaintEventArgs e)
		{
			KnownColorBrightnessExample1(e);
		}
		
		public void KnownColorBrightnessExample1(PaintEventArgs e)
		{
			Graphics g = e.Graphics;
             
			// Color structures. One is a variable used for temporary storage. The other
			// is a constant used for comparisons.
			Color someColor = Color.FromArgb(0);
			Color redShade = Color.FromArgb(255, 200, 100, 100);
             
			// Array to store KnownColor values that match the brightness of the
			// redShade color.
			KnownColor[] colorMatches = new KnownColor[15];
     
			// Number of matches found.
			int count = 0;   
          
			// Iterate through the KnownColor enums until 15 matches are found.
			for (KnownColor enumValue = 0;
				enumValue <= KnownColor.YellowGreen && count < 15; enumValue++)
			{
				someColor = Color.FromKnownColor(enumValue);
				if (Math.Abs(someColor.GetBrightness() - redShade.GetBrightness()) < 0.01)
					colorMatches[count++] = enumValue;
			}
             
			// Display the redShade color and its argb value.
			SolidBrush myBrush1 = new SolidBrush(redShade);
			Font myFont = new Font("Arial", 12);
			int x = 20;
			int y = 20;
			someColor = redShade;
			g.FillRectangle(myBrush1, x, y, 100, 30);
			g.DrawString(someColor.ToString(), myFont, Brushes.Black, x + 120, y);
             
			// Iterate through the matches that were found and display each color that
			// Corresponds with the enum value in the array. also display the name of
			// The KnownColor.
			for (int i = 0; i < count; i++) {
				y += 40;
				someColor = Color.FromKnownColor(colorMatches[i]);
				myBrush1.Color = someColor;
				g.FillRectangle(myBrush1, x, y, 100, 30);
				g.DrawString(someColor.ToString(), myFont, Brushes.Black, x + 120, y);
			}
			
			this.Text = string.Format("color count: {0}", count);
		}
	}
}
