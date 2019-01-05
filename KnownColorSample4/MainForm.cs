/*
 * Created by SharpDevelop.
 * User: Шелли
 * Date: 05.01.2019
 * Time: 15:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace KnownColorSample4
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
			if (radioButton1.Checked)
				FromArgb1(e);
			else if (radioButton2.Checked)
				FromArgb2(e);
		}
		
		public void FromArgb1(PaintEventArgs e)
		{
			Graphics g = e.Graphics;
             
			// Transparent red, green, and blue brushes.
			SolidBrush trnsRedBrush = new SolidBrush(Color.FromArgb(120, 255, 0, 0));
			SolidBrush trnsGreenBrush = new SolidBrush(Color.FromArgb(120, 0, 255, 0));
			SolidBrush trnsBlueBrush = new SolidBrush(Color.FromArgb(120, 0, 0, 255));
             
			// Base and height of the triangle that is used to position the
			// circles. Each vertex of the triangle is at the center of one of the
			// 3 circles. The base is equal to the diameter of the circles.
			float triBase = 100;
			float triHeight = (float)Math.Sqrt(3 * (triBase * triBase) / 4);
             
			// Coordinates of first circle's bounding rectangle.
			float x1 = 140;
			float y1 = 140;
             
			// Fill 3 over-lapping circles. Each circle is a different color.
			g.FillEllipse(trnsRedBrush, x1, y1, 2 * triHeight, 2 * triHeight);
			g.FillEllipse(trnsGreenBrush, x1 + triBase / 2, y1 + triHeight,
				2 * triHeight, 2 * triHeight);
			g.FillEllipse(trnsBlueBrush, x1 + triBase, y1, 2 * triHeight, 2 * triHeight);
		}
		
		public void FromArgb2(PaintEventArgs e)
		{
			Graphics g = e.Graphics;
             
			// Opaque colors (alpha value defaults to 255 -- max value).
			Color red = Color.FromArgb(255, 0, 0);
			Color green = Color.FromArgb(0, 255, 0);
			Color blue = Color.FromArgb(0, 0, 255);
             
			// Solid brush initialized to red.
			SolidBrush myBrush = new SolidBrush(red);
			int alpha;

			// x coordinate of first red rectangle
			int x = 50;         
    
			// y coordinate of first red rectangle
			int y = 50;         
                   
			// Fill rectangles with red, varying the alpha value from 25 to 250.
			for (alpha = 25; alpha <= 250; alpha += 25) {
				myBrush.Color = Color.FromArgb(alpha, red);
				g.FillRectangle(myBrush, x, y, 50, 100);
				g.FillRectangle(myBrush, x, y + 250, 50, 50);
				x += 50;
			}
			// x coordinate of first green rectangle.
			x = 50;             
    
			// y coordinate of first green rectangle.
			y += 50;            
                      
			// Fill rectangles with green, varying the alpha value from 25 to 250.
			for (alpha = 25; alpha <= 250; alpha += 25) {
				myBrush.Color = Color.FromArgb(alpha, green);
				g.FillRectangle(myBrush, x, y, 50, 150);
				x += 50;
			}
			// x coordinate of first blue rectangle.
			x = 50;             
    
			// y coordinate of first blue rectangle.
			y += 100;           
             
			// Fill rectangles with blue, varying the alpha value from 25 to 250.
			for (alpha = 25; alpha <= 250; alpha += 25) {
				myBrush.Color = Color.FromArgb(alpha, blue);
				g.FillRectangle(myBrush, x, y, 50, 150);
				x += 50;
			}
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			this.Size = new Size(600, 550);
		}
		void RadioButton1CheckedChanged(object sender, EventArgs e)
		{
			this.Invalidate();
		}
	}
}
