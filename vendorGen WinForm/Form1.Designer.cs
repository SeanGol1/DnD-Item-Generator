namespace vendorGen_WinForm
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
            this.currentgp = new System.Windows.Forms.Label();
            this.btnGen = new System.Windows.Forms.Button();
            this.totalRolled = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxAttune = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxDesc = new System.Windows.Forms.TextBox();
            this.btnFullList = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Attunement = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // currentgp
            // 
            this.currentgp.AutoSize = true;
            this.currentgp.Location = new System.Drawing.Point(332, 36);
            this.currentgp.Name = "currentgp";
            this.currentgp.Size = new System.Drawing.Size(0, 26);
            this.currentgp.TabIndex = 1;
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(318, 68);
            this.btnGen.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(91, 58);
            this.btnGen.TabIndex = 3;
            this.btnGen.Text = "Generate";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // totalRolled
            // 
            this.totalRolled.Location = new System.Drawing.Point(111, 80);
            this.totalRolled.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.totalRolled.MaxLength = 300;
            this.totalRolled.Name = "totalRolled";
            this.totalRolled.Size = new System.Drawing.Size(100, 29);
            this.totalRolled.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Number:";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(162, 160);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(230, 29);
            this.tbxName.TabIndex = 7;
            // 
            // tbxAttune
            // 
            this.tbxAttune.Location = new System.Drawing.Point(162, 196);
            this.tbxAttune.Name = "tbxAttune";
            this.tbxAttune.Size = new System.Drawing.Size(230, 29);
            this.tbxAttune.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 26);
            this.label3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Attunement";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "Description";
            // 
            // tbxDesc
            // 
            this.tbxDesc.Location = new System.Drawing.Point(162, 230);
            this.tbxDesc.Multiline = true;
            this.tbxDesc.Name = "tbxDesc";
            this.tbxDesc.Size = new System.Drawing.Size(355, 140);
            this.tbxDesc.TabIndex = 14;
            this.tbxDesc.TabStop = false;
            // 
            // btnFullList
            // 
            this.btnFullList.Location = new System.Drawing.Point(426, 67);
            this.btnFullList.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnFullList.Name = "btnFullList";
            this.btnFullList.Size = new System.Drawing.Size(91, 58);
            this.btnFullList.TabIndex = 16;
            this.btnFullList.Text = "View All";
            this.btnFullList.UseVisualStyleBackColor = true;
            this.btnFullList.Click += new System.EventHandler(this.BtnFullList_Click);
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Number,
            this.itemName,
            this.Description,
            this.Attunement});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(37, 408);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(515, 534);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.UseWaitCursor = true;
            // 
            // Number
            // 
            this.Number.Text = "Number";
            this.Number.Width = 50;
            // 
            // itemName
            // 
            this.itemName.Text = "Name";
            this.itemName.Width = 100;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 250;
            // 
            // Attunement
            // 
            this.Attunement.Text = "Attunement";
            this.Attunement.Width = 100;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnGen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 1050);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnFullList);
            this.Controls.Add(this.tbxDesc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxAttune);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalRolled);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.currentgp);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label currentgp;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.TextBox totalRolled;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxAttune;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxDesc;
        private System.Windows.Forms.Button btnFullList;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader itemName;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader Attunement;
        private System.Windows.Forms.ColumnHeader Number;
    }
}

