/*
 * Created by SharpDevelop.
 * User: Шелли
 * Date: 04.01.2019
 * Time: 22:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ComboBoxBind
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
			// init combobox
			combo.DataSource = KnownColorClass.KnownColorArray;
			combo.ValueMember = "Color";
			combo.DisplayMember = "Name";
			
			// create binding
			combo.DataBindings.Add("SelectedValue", this, "BackColor");
			combo.DataBindings[0].DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
		}
	}
}
