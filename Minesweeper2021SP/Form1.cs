using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper2021SP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Rows = 10;
            Columns = 4;
            //InitializeComponent();
            InitializeComponent2();
        }

        public int Rows { get; set; }
        public int Columns { get; set; }
        private System.Windows.Forms.Button[,] _buttons;
        private void InitializeComponent2()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            _buttons = new Button[Rows, Columns];
            for (int r = 0; r < Rows; r++)
            for (int c = 0; c < Columns; c++)
            {
                _buttons[r, c] = new Button {Dock = DockStyle.Fill, TabIndex = r * Columns + c};
            }
                    
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = Columns;
            for (int c = 0; c < Columns; c++)
                this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F / Columns));
            for (int r = 0; r < Rows; r++)
                this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F / Rows));

            for (int r = 0; r < Rows; r++)
            for (int c = 0; c < Columns; c++)
                    this.tableLayoutPanel1.Controls.Add(_buttons[r,c], c, r);

            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = Rows;

            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 703);
            this.tableLayoutPanel1.TabIndex = 0;
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 703);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
