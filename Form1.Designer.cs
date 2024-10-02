namespace GUI
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
            this.Add = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.AddTextBox = new System.Windows.Forms.TextBox();
            this.GetIndextextBox = new System.Windows.Forms.TextBox();
            this.ShowTextBox = new System.Windows.Forms.TextBox();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.GetIndex = new System.Windows.Forms.Button();
            this.Set = new System.Windows.Forms.Button();
            this.NameAllListBox = new System.Windows.Forms.ListBox();
            this.ShowAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(318, 12);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(139, 65);
            this.Add.TabIndex = 1;
            this.Add.Text = "เพิ่มชื่อ";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(608, 12);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(139, 65);
            this.Search.TabIndex = 2;
            this.Search.Text = "ค้นหาชื่อ";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(463, 12);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(139, 65);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "ลบชื่อ";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // AddTextBox
            // 
            this.AddTextBox.Location = new System.Drawing.Point(73, 55);
            this.AddTextBox.Name = "AddTextBox";
            this.AddTextBox.Size = new System.Drawing.Size(219, 22);
            this.AddTextBox.TabIndex = 4;
            // 
            // GetIndextextBox
            // 
            this.GetIndextextBox.Location = new System.Drawing.Point(126, 159);
            this.GetIndextextBox.Name = "GetIndextextBox";
            this.GetIndextextBox.Size = new System.Drawing.Size(100, 22);
            this.GetIndextextBox.TabIndex = 5;
            // 
            // ShowTextBox
            // 
            this.ShowTextBox.Location = new System.Drawing.Point(416, 159);
            this.ShowTextBox.Name = "ShowTextBox";
            this.ShowTextBox.Size = new System.Drawing.Size(147, 22);
            this.ShowTextBox.TabIndex = 6;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(669, 423);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(65, 16);
            this.QuantityLabel.TabIndex = 7;
            this.QuantityLabel.Text = "จำนวน 0 คน";
            // 
            // GetIndex
            // 
            this.GetIndex.Location = new System.Drawing.Point(246, 126);
            this.GetIndex.Name = "GetIndex";
            this.GetIndex.Size = new System.Drawing.Size(150, 55);
            this.GetIndex.TabIndex = 8;
            this.GetIndex.Text = "ค้นหาชื่อจากลำดับที่";
            this.GetIndex.UseVisualStyleBackColor = true;
            this.GetIndex.Click += new System.EventHandler(this.GetIndex_Click);
            // 
            // Set
            // 
            this.Set.Location = new System.Drawing.Point(608, 126);
            this.Set.Name = "Set";
            this.Set.Size = new System.Drawing.Size(139, 55);
            this.Set.TabIndex = 9;
            this.Set.Text = "แก้ไข";
            this.Set.UseVisualStyleBackColor = true;
            this.Set.Click += new System.EventHandler(this.Set_Click);
            // 
            // NameAllListBox
            // 
            this.NameAllListBox.FormattingEnabled = true;
            this.NameAllListBox.ItemHeight = 16;
            this.NameAllListBox.Location = new System.Drawing.Point(297, 252);
            this.NameAllListBox.Name = "NameAllListBox";
            this.NameAllListBox.Size = new System.Drawing.Size(283, 148);
            this.NameAllListBox.TabIndex = 10;
            // 
            // ShowAll
            // 
            this.ShowAll.Location = new System.Drawing.Point(110, 252);
            this.ShowAll.Name = "ShowAll";
            this.ShowAll.Size = new System.Drawing.Size(116, 110);
            this.ShowAll.TabIndex = 11;
            this.ShowAll.Text = "แสดงรายชื่อทั้งหมด";
            this.ShowAll.UseVisualStyleBackColor = true;
            this.ShowAll.Click += new System.EventHandler(this.ShowAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowAll);
            this.Controls.Add(this.NameAllListBox);
            this.Controls.Add(this.Set);
            this.Controls.Add(this.GetIndex);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.ShowTextBox);
            this.Controls.Add(this.GetIndextextBox);
            this.Controls.Add(this.AddTextBox);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "รายชื่อและลำดับ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox AddTextBox;
        private System.Windows.Forms.TextBox GetIndextextBox;
        private System.Windows.Forms.TextBox ShowTextBox;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Button GetIndex;
        private System.Windows.Forms.Button Set;
        private System.Windows.Forms.ListBox NameAllListBox;
        private System.Windows.Forms.Button ShowAll;
    }
}
