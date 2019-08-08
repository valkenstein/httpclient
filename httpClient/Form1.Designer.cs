namespace httpClient
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelParam = new System.Windows.Forms.Panel();
            this.AddParam = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.AddHeader = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.HTTPRequest = new System.Windows.Forms.Panel();
            this.RequestBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MethodBox = new System.Windows.Forms.ComboBox();
            this.HTTPContent = new System.Windows.Forms.Panel();
            this.ResultRequestBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textUrl = new System.Windows.Forms.TextBox();
            this.sendRequest = new System.Windows.Forms.Button();
            this.bottomTable = new System.Windows.Forms.TableLayoutPanel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.HTTPRequest.SuspendLayout();
            this.HTTPContent.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.bottomTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.panelParam);
            this.panel2.Controls.Add(this.AddParam);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(790, 377);
            this.panel2.TabIndex = 0;
            // 
            // panelParam
            // 
            this.panelParam.AutoScroll = true;
            this.panelParam.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelParam.Location = new System.Drawing.Point(0, 37);
            this.panelParam.Name = "panelParam";
            this.panelParam.Size = new System.Drawing.Size(790, 299);
            this.panelParam.TabIndex = 3;
            // 
            // AddParam
            // 
            this.AddParam.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddParam.Location = new System.Drawing.Point(0, 336);
            this.AddParam.Name = "AddParam";
            this.AddParam.Size = new System.Drawing.Size(790, 41);
            this.AddParam.TabIndex = 2;
            this.AddParam.Text = "Add parameter";
            this.AddParam.UseVisualStyleBackColor = true;
            this.AddParam.Click += new System.EventHandler(this.AddParam_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "Query parameters";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.panelHeader);
            this.panel3.Controls.Add(this.AddHeader);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(799, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(791, 377);
            this.panel3.TabIndex = 1;
            // 
            // panelHeader
            // 
            this.panelHeader.AutoScroll = true;
            this.panelHeader.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHeader.Location = new System.Drawing.Point(0, 37);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(791, 299);
            this.panelHeader.TabIndex = 5;
            // 
            // AddHeader
            // 
            this.AddHeader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddHeader.Location = new System.Drawing.Point(0, 336);
            this.AddHeader.Name = "AddHeader";
            this.AddHeader.Size = new System.Drawing.Size(791, 41);
            this.AddHeader.TabIndex = 3;
            this.AddHeader.Text = "Add header";
            this.AddHeader.UseVisualStyleBackColor = true;
            this.AddHeader.Click += new System.EventHandler(this.AddHeader_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 37);
            this.label4.TabIndex = 2;
            this.label4.Text = "Headers";
            // 
            // HTTPRequest
            // 
            this.HTTPRequest.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HTTPRequest.Controls.Add(this.RequestBox);
            this.HTTPRequest.Controls.Add(this.label1);
            this.HTTPRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HTTPRequest.Location = new System.Drawing.Point(3, 386);
            this.HTTPRequest.Name = "HTTPRequest";
            this.HTTPRequest.Size = new System.Drawing.Size(790, 377);
            this.HTTPRequest.TabIndex = 0;
            // 
            // RequestBox
            // 
            this.RequestBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RequestBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RequestBox.Location = new System.Drawing.Point(0, 37);
            this.RequestBox.Name = "RequestBox";
            this.RequestBox.Size = new System.Drawing.Size(790, 340);
            this.RequestBox.TabIndex = 1;
            this.RequestBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "HTTP request";
            // 
            // MethodBox
            // 
            this.MethodBox.DisplayMember = "0";
            this.MethodBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MethodBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MethodBox.FormattingEnabled = true;
            this.MethodBox.ItemHeight = 39;
            this.MethodBox.Items.AddRange(new object[] {
            "GET",
            "POST",
            "PUT",
            "DELETE"});
            this.MethodBox.Location = new System.Drawing.Point(3, 3);
            this.MethodBox.Name = "MethodBox";
            this.MethodBox.Size = new System.Drawing.Size(129, 47);
            this.MethodBox.TabIndex = 2;
            this.MethodBox.ValueMember = "0";
            // 
            // HTTPContent
            // 
            this.HTTPContent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HTTPContent.Controls.Add(this.ResultRequestBox);
            this.HTTPContent.Controls.Add(this.label2);
            this.HTTPContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HTTPContent.Location = new System.Drawing.Point(799, 386);
            this.HTTPContent.Name = "HTTPContent";
            this.HTTPContent.Size = new System.Drawing.Size(791, 377);
            this.HTTPContent.TabIndex = 1;
            // 
            // ResultRequestBox
            // 
            this.ResultRequestBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultRequestBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultRequestBox.Location = new System.Drawing.Point(0, 37);
            this.ResultRequestBox.Name = "ResultRequestBox";
            this.ResultRequestBox.Size = new System.Drawing.Size(791, 340);
            this.ResultRequestBox.TabIndex = 2;
            this.ResultRequestBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Response content";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.HTTPContent, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.HTTPRequest, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1593, 766);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // textUrl
            // 
            this.textUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textUrl.Location = new System.Drawing.Point(138, 3);
            this.textUrl.Name = "textUrl";
            this.textUrl.Size = new System.Drawing.Size(1326, 44);
            this.textUrl.TabIndex = 1;
            this.textUrl.Text = "https://";
            // 
            // sendRequest
            // 
            this.sendRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendRequest.Location = new System.Drawing.Point(1470, 3);
            this.sendRequest.Name = "sendRequest";
            this.sendRequest.Size = new System.Drawing.Size(120, 53);
            this.sendRequest.TabIndex = 0;
            this.sendRequest.Text = "SEND";
            this.sendRequest.UseVisualStyleBackColor = true;
            this.sendRequest.Click += new System.EventHandler(this.SendRequest_Click);
            // 
            // bottomTable
            // 
            this.bottomTable.ColumnCount = 3;
            this.bottomTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.52543F));
            this.bottomTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.64781F));
            this.bottomTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.826759F));
            this.bottomTable.Controls.Add(this.textUrl, 1, 0);
            this.bottomTable.Controls.Add(this.MethodBox, 0, 0);
            this.bottomTable.Controls.Add(this.sendRequest, 2, 0);
            this.bottomTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomTable.Location = new System.Drawing.Point(0, 766);
            this.bottomTable.Name = "bottomTable";
            this.bottomTable.RowCount = 1;
            this.bottomTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottomTable.Size = new System.Drawing.Size(1593, 59);
            this.bottomTable.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1593, 825);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.bottomTable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.HTTPRequest.ResumeLayout(false);
            this.HTTPRequest.PerformLayout();
            this.HTTPContent.ResumeLayout(false);
            this.HTTPContent.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.bottomTable.ResumeLayout(false);
            this.bottomTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel HTTPRequest;
        private System.Windows.Forms.RichTextBox RequestBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel HTTPContent;
        private System.Windows.Forms.RichTextBox ResultRequestBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textUrl;
        private System.Windows.Forms.Button sendRequest;
        private System.Windows.Forms.Button AddParam;
        private System.Windows.Forms.Button AddHeader;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelParam;
        private System.Windows.Forms.TableLayoutPanel bottomTable;
        private System.Windows.Forms.ComboBox MethodBox;
    }
}

