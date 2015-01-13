namespace Stocks_
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.createBtn = new System.Windows.Forms.Button();
            this.shareVauleTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stkNameTxt = new System.Windows.Forms.TextBox();
            this.colurComboBx = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.label4 = new System.Windows.Forms.Label();
            this.numOfSharesTxt = new System.Windows.Forms.TextBox();
            this.buyBtn = new System.Windows.Forms.Button();
            this.stocksComboBx = new System.Windows.Forms.ComboBox();
            this.buyTxtBx = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.stkValueTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cashTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.userNameBx = new System.Windows.Forms.TextBox();
            this.sellTxtBx = new System.Windows.Forms.TextBox();
            this.sellBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.availSharesTxt = new System.Windows.Forms.TextBox();
            this.totalStkValueTxt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(214, 132);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 23);
            this.createBtn.TabIndex = 1;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click_1);
            // 
            // StkVauleTxt
            // 
            this.shareVauleTxt.Location = new System.Drawing.Point(106, 66);
            this.shareVauleTxt.Name = "StkVauleTxt";
            this.shareVauleTxt.Size = new System.Drawing.Size(100, 20);
            this.shareVauleTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Stock Value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Stock Name:";
            // 
            // stkNameTxt
            // 
            this.stkNameTxt.Location = new System.Drawing.Point(106, 40);
            this.stkNameTxt.Name = "stkNameTxt";
            this.stkNameTxt.Size = new System.Drawing.Size(100, 20);
            this.stkNameTxt.TabIndex = 4;
            // 
            // colurComboBx
            // 
            this.colurComboBx.FormattingEnabled = true;
            this.colurComboBx.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Green",
            "Yellow",
            "Purple"});
            this.colurComboBx.Location = new System.Drawing.Point(106, 13);
            this.colurComboBx.Name = "colurComboBx";
            this.colurComboBx.Size = new System.Drawing.Size(100, 21);
            this.colurComboBx.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Colour:";
            // 
            // zedGraph
            // 
            this.zedGraph.AutoScroll = true;
            this.zedGraph.AutoSize = true;
            this.zedGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zedGraph.Location = new System.Drawing.Point(12, 12);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(651, 367);
            this.zedGraph.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Number of stocks:";
            // 
            // stockNumberTxt
            // 
            this.numOfSharesTxt.Location = new System.Drawing.Point(106, 92);
            this.numOfSharesTxt.Name = "stockNumberTxt";
            this.numOfSharesTxt.Size = new System.Drawing.Size(100, 20);
            this.numOfSharesTxt.TabIndex = 11;
            // 
            // buyBtn
            // 
            this.buyBtn.Location = new System.Drawing.Point(390, 428);
            this.buyBtn.Name = "buyBtn";
            this.buyBtn.Size = new System.Drawing.Size(75, 23);
            this.buyBtn.TabIndex = 13;
            this.buyBtn.Text = "Buy!";
            this.buyBtn.UseVisualStyleBackColor = true;
            this.buyBtn.Click += new System.EventHandler(this.buyBtn_Click);
            // 
            // stocksComboBx
            // 
            this.stocksComboBx.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.stocksComboBx.FormattingEnabled = true;
            this.stocksComboBx.Location = new System.Drawing.Point(120, 15);
            this.stocksComboBx.Name = "stocksComboBx";
            this.stocksComboBx.Size = new System.Drawing.Size(100, 21);
            this.stocksComboBx.TabIndex = 14;
            this.stocksComboBx.SelectedIndexChanged += new System.EventHandler(this.stocksComboBx_SelectedIndexChanged);
            // 
            // buyTxtBx
            // 
            this.buyTxtBx.Location = new System.Drawing.Point(287, 430);
            this.buyTxtBx.Name = "buyTxtBx";
            this.buyTxtBx.Size = new System.Drawing.Size(100, 20);
            this.buyTxtBx.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.stkValueTxt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cashTxt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.userNameBx);
            this.panel1.Location = new System.Drawing.Point(752, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 136);
            this.panel1.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Stock value:";
            // 
            // stkValueTxt
            // 
            this.stkValueTxt.Location = new System.Drawing.Point(76, 97);
            this.stkValueTxt.Name = "stkValueTxt";
            this.stkValueTxt.ReadOnly = true;
            this.stkValueTxt.Size = new System.Drawing.Size(91, 20);
            this.stkValueTxt.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cash:";
            // 
            // cashTxt
            // 
            this.cashTxt.Location = new System.Drawing.Point(76, 58);
            this.cashTxt.Name = "cashTxt";
            this.cashTxt.ReadOnly = true;
            this.cashTxt.Size = new System.Drawing.Size(91, 20);
            this.cashTxt.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Username:";
            // 
            // userNameBx
            // 
            this.userNameBx.Location = new System.Drawing.Point(76, 21);
            this.userNameBx.Name = "userNameBx";
            this.userNameBx.ReadOnly = true;
            this.userNameBx.Size = new System.Drawing.Size(91, 20);
            this.userNameBx.TabIndex = 6;
            // 
            // sellTxtBx
            // 
            this.sellTxtBx.Location = new System.Drawing.Point(287, 475);
            this.sellTxtBx.Name = "sellTxtBx";
            this.sellTxtBx.Size = new System.Drawing.Size(100, 20);
            this.sellTxtBx.TabIndex = 19;
            // 
            // sellBtn
            // 
            this.sellBtn.Location = new System.Drawing.Point(390, 473);
            this.sellBtn.Name = "sellBtn";
            this.sellBtn.Size = new System.Drawing.Size(75, 23);
            this.sellBtn.TabIndex = 17;
            this.sellBtn.Text = "Sell!";
            this.sellBtn.UseVisualStyleBackColor = true;
            this.sellBtn.Click += new System.EventHandler(this.sellBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Available shares:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Total value of shares:";
            // 
            // availSharesTxt
            // 
            this.availSharesTxt.Location = new System.Drawing.Point(120, 84);
            this.availSharesTxt.Name = "availSharesTxt";
            this.availSharesTxt.ReadOnly = true;
            this.availSharesTxt.Size = new System.Drawing.Size(100, 20);
            this.availSharesTxt.TabIndex = 22;
            // 
            // totalStkValueTxt
            // 
            this.totalStkValueTxt.Location = new System.Drawing.Point(120, 47);
            this.totalStkValueTxt.Name = "totalStkValueTxt";
            this.totalStkValueTxt.ReadOnly = true;
            this.totalStkValueTxt.Size = new System.Drawing.Size(100, 20);
            this.totalStkValueTxt.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.stocksComboBx);
            this.panel2.Controls.Add(this.totalStkValueTxt);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.availSharesTxt);
            this.panel2.Location = new System.Drawing.Point(12, 389);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 193);
            this.panel2.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.colurComboBx);
            this.panel3.Controls.Add(this.createBtn);
            this.panel3.Controls.Add(this.shareVauleTxt);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.stkNameTxt);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.numOfSharesTxt);
            this.panel3.Location = new System.Drawing.Point(650, 427);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 167);
            this.panel3.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 606);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.sellTxtBx);
            this.Controls.Add(this.sellBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buyTxtBx);
            this.Controls.Add(this.buyBtn);
            this.Controls.Add(this.zedGraph);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.TextBox shareVauleTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stkNameTxt;
        private System.Windows.Forms.ComboBox colurComboBx;
        private System.Windows.Forms.Label label3;
        private ZedGraph.ZedGraphControl zedGraph;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numOfSharesTxt;
        private System.Windows.Forms.Button buyBtn;
        private System.Windows.Forms.ComboBox stocksComboBx;
        private System.Windows.Forms.TextBox buyTxtBx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cashTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox userNameBx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox stkValueTxt;
        private System.Windows.Forms.TextBox sellTxtBx;
        private System.Windows.Forms.Button sellBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox availSharesTxt;
        private System.Windows.Forms.TextBox totalStkValueTxt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;

    }
}

