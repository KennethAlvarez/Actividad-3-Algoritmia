/*
 * Created by SharpDevelop.
 * User: 1GX69LA_RS4
 * Date: 05/10/2019
 * Time: 09:42 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AlgoritmiaAct3
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.components = new System.ComponentModel.Container();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.listView1 = new System.Windows.Forms.ListView();
			this.ID = new System.Windows.Forms.ColumnHeader();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.agenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.señueloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(13, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(807, 432);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(13, 450);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 44);
			this.button1.TabIndex = 1;
			this.button1.Text = "Seleccionar imagen";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Enabled = false;
			this.button2.Location = new System.Drawing.Point(93, 450);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 44);
			this.button2.TabIndex = 2;
			this.button2.Text = "Empezar análisis";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// treeView1
			// 
			this.treeView1.Location = new System.Drawing.Point(825, 233);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(181, 211);
			this.treeView1.TabIndex = 3;
			this.treeView1.Click += new System.EventHandler(this.TreeView1Click);
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.ID,
									this.columnHeader1,
									this.columnHeader2,
									this.columnHeader3});
			this.listView1.Location = new System.Drawing.Point(826, 12);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(236, 215);
			this.listView1.TabIndex = 4;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// ID
			// 
			this.ID.Text = "ID";
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "X";
			this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Y";
			this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Radio";
			this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.agenteToolStripMenuItem,
									this.señueloToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(117, 48);
			// 
			// agenteToolStripMenuItem
			// 
			this.agenteToolStripMenuItem.Name = "agenteToolStripMenuItem";
			this.agenteToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.agenteToolStripMenuItem.Text = "Agente";
			this.agenteToolStripMenuItem.Click += new System.EventHandler(this.AgenteToolStripMenuItemClick);
			// 
			// señueloToolStripMenuItem
			// 
			this.señueloToolStripMenuItem.Name = "señueloToolStripMenuItem";
			this.señueloToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.señueloToolStripMenuItem.Text = "Señuelo";
			this.señueloToolStripMenuItem.Click += new System.EventHandler(this.SeñueloToolStripMenuItemClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(453, 471);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 5;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(881, 456);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 43);
			this.button3.TabIndex = 6;
			this.button3.Text = "Empezar Animación";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.Enabled = false;
			this.button4.Location = new System.Drawing.Point(489, 456);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 38);
			this.button4.TabIndex = 7;
			this.button4.Text = "Generar Aleatoriamente";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(428, 463);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(55, 21);
			this.comboBox1.TabIndex = 8;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			// 
			// button5
			// 
			this.button5.Enabled = false;
			this.button5.Location = new System.Drawing.Point(570, 460);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 34);
			this.button5.TabIndex = 9;
			this.button5.Text = "Reanudar";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(717, 460);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(75, 34);
			this.button6.TabIndex = 10;
			this.button6.Text = "Reiniciar";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1074, 506);
			this.ContextMenuStrip = this.contextMenuStrip1;
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.treeView1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "MainForm";
			this.Text = "AlgoritmiaAct3";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStripMenuItem señueloToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem agenteToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader ID;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		
	}
}
