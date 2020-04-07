using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace httpClient
{
    public partial class Form1 : Form
    {
        int countRows = 0;
        HttpSend send;
        public Form1()
        {
            InitializeComponent();
            send = new HttpSend();
            MethodBox.SelectedIndex=0;
        }
        private void AddParam_Click(object sender, EventArgs e)
        {
            AddRows(panelParam);
        }
        private void AddHeader_Click(object sender, EventArgs e)
        {
            AddRows(panelHeader);
        }
        TableLayoutPanel CreateTable() 
        {
            TableLayoutPanel tab = new TableLayoutPanel();

            tab.AutoScroll = true;
            tab.ColumnCount = 3;
            tab.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tab.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tab.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
       
            tab.Dock = DockStyle.Fill;
            tab.Location = new Point(0, 0);
            tab.Name = "tableHeaders";
            tab.RowCount = 1;
            tab.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tab.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tab.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tab.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tab.Size = new Size(791, 328);
            tab.TabIndex = 4;
            return tab;

        }
        Panel CreatePanel()
        {
            Panel panel = new Panel();
         
            panel.Dock = DockStyle.Top;
            panel.Location = new Point(0, 147);
            panel.Name = "panel7";
            panel.Size = new Size(790, 49);
            panel.TabIndex = 3;
            panel.BackColor = Color.Black;
            return panel;
        }

        TextBox CreateTextBox(string key) 
        {
            TextBox t1 = new TextBox();
            t1.Dock = DockStyle.Fill;
            t1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            t1.Location = new Point(3, 3);
            t1.Size = new Size(264, 35);
            t1.Text = key;
            t1.Enter += (sender, e) => OnFocus((sender as TextBox), key);
            t1.Leave += (sender, e) => LeaveFocus((sender as TextBox), key);
            return t1;
        }
        Button CreateButton(Panel p, Panel table) 
        {
            Button b1 = new Button();
            b1.Dock = DockStyle.Top;
            b1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            b1.Location = new Point(543, 3);
            b1.Size = new Size(266, 34);
            b1.Text = "remove";
            b1.UseVisualStyleBackColor = true;
            int j = countRows++;
            b1.Click += (e, EventArgs) => { Remove_Rows(table, p, j); };
            return b1;
        }

        private void AddRows(Panel table)
        {
            Panel p = CreatePanel();
            TableLayoutPanel t = CreateTable();
            p.Controls.Add(t);

            TextBox t1 = CreateTextBox("key");
            TextBox t2 = CreateTextBox("value");
            Button b1 = CreateButton(p, table);

            t.Controls.Add(t1);
            t.Controls.Add(t2);
            t.Controls.Add(b1);
            table.Controls.Add(p);
        }

        private void Remove_Rows(Panel table,Panel remove, int i)
        {
            table.Controls.Remove(remove);
        }
         
        private void SendRequest_Click(object sender, EventArgs e)
        {
            ResultRequestBox.Text = "";
            RequestBox.Text = "";

            send.Start(textUrl.Text, panelParam.Controls, panelHeader.Controls);
            send.RequestServer(ResultRequestBox, MethodBox.SelectedItem.ToString());

            RequestBox.Text = send.url+ send.param;
        }

        
        void LeaveFocus(TextBox text, string s) {

            if (text.Text == "" || text.Text == " ")
            {   
                text.Text = s;
                text.ForeColor = Color.Silver;
                text.Font = new Font(text.Font, FontStyle.Regular);
            }
        }
        void OnFocus(TextBox text, string s) {

            if (text.Text == s)
            {   
                text.Text = "";
                text.ForeColor = Color.Black;
                text.Font = new Font(text.Font, FontStyle.Bold);
            }
        }
    }
}
