namespace CSharpAssessment
{
    partial class NewTreeDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewTreeDialog));
            this.newTreeDialogOkButton = new System.Windows.Forms.Button();
            this.compositeDropBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.compositeDropBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.decoratorDropBox1 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.decoratorDropBox2 = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.leafDropBox1 = new System.Windows.Forms.ComboBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.leafDropBox2 = new System.Windows.Forms.ComboBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.leafDropBox3 = new System.Windows.Forms.ComboBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.leafDropBox4 = new System.Windows.Forms.ComboBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.leafDropBox5 = new System.Windows.Forms.ComboBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.leafDropBox6 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // newTreeDialogOkButton
            // 
            this.newTreeDialogOkButton.Location = new System.Drawing.Point(374, 267);
            this.newTreeDialogOkButton.Name = "newTreeDialogOkButton";
            this.newTreeDialogOkButton.Size = new System.Drawing.Size(124, 42);
            this.newTreeDialogOkButton.TabIndex = 0;
            this.newTreeDialogOkButton.Text = "Ok";
            this.newTreeDialogOkButton.UseVisualStyleBackColor = true;
            this.newTreeDialogOkButton.Click += new System.EventHandler(this.newTreeDialogOkButton_Click);
            // 
            // compositeDropBox1
            // 
            this.compositeDropBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.compositeDropBox1.FormattingEnabled = true;
            this.compositeDropBox1.Items.AddRange(new object[] {
            "",
            "Sequence",
            "Selector"});
            this.compositeDropBox1.Location = new System.Drawing.Point(118, 24);
            this.compositeDropBox1.Name = "compositeDropBox1";
            this.compositeDropBox1.Size = new System.Drawing.Size(121, 21);
            this.compositeDropBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 24);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Composite Node";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // compositeDropBox2
            // 
            this.compositeDropBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.compositeDropBox2.FormattingEnabled = true;
            this.compositeDropBox2.Items.AddRange(new object[] {
            "Sequence",
            "Selector"});
            this.compositeDropBox2.Location = new System.Drawing.Point(118, 66);
            this.compositeDropBox2.Name = "compositeDropBox2";
            this.compositeDropBox2.Size = new System.Drawing.Size(121, 21);
            this.compositeDropBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Composite Node";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(273, 25);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "Decorator Node";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // decoratorDropBox1
            // 
            this.decoratorDropBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.decoratorDropBox1.FormattingEnabled = true;
            this.decoratorDropBox1.Items.AddRange(new object[] {
            "",
            "Repeater",
            "Maximum"});
            this.decoratorDropBox1.Location = new System.Drawing.Point(379, 24);
            this.decoratorDropBox1.Name = "decoratorDropBox1";
            this.decoratorDropBox1.Size = new System.Drawing.Size(121, 21);
            this.decoratorDropBox1.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(273, 67);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "Decorator Node";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // decoratorDropBox2
            // 
            this.decoratorDropBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.decoratorDropBox2.FormattingEnabled = true;
            this.decoratorDropBox2.Items.AddRange(new object[] {
            "",
            "Repeater",
            "Maximum"});
            this.decoratorDropBox2.Location = new System.Drawing.Point(379, 66);
            this.decoratorDropBox2.Name = "decoratorDropBox2";
            this.decoratorDropBox2.Size = new System.Drawing.Size(121, 21);
            this.decoratorDropBox2.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 115);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 11;
            this.textBox5.Text = "Leaf Node";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // leafDropBox1
            // 
            this.leafDropBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.leafDropBox1.FormattingEnabled = true;
            this.leafDropBox1.Items.AddRange(new object[] {
            "",
            "Walk",
            "Open Door",
            "Run",
            "Find Entrance",
            "Wander",
            "Attack",
            "Flee"});
            this.leafDropBox1.Location = new System.Drawing.Point(118, 115);
            this.leafDropBox1.Name = "leafDropBox1";
            this.leafDropBox1.Size = new System.Drawing.Size(121, 21);
            this.leafDropBox1.TabIndex = 10;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(12, 150);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 13;
            this.textBox6.Text = "Leaf Node";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // leafDropBox2
            // 
            this.leafDropBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.leafDropBox2.FormattingEnabled = true;
            this.leafDropBox2.Items.AddRange(new object[] {
            "",
            "Walk",
            "Open Door",
            "Run",
            "Find Entrance",
            "Wander",
            "Attack",
            "Flee"});
            this.leafDropBox2.Location = new System.Drawing.Point(118, 149);
            this.leafDropBox2.Name = "leafDropBox2";
            this.leafDropBox2.Size = new System.Drawing.Size(121, 21);
            this.leafDropBox2.TabIndex = 12;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(12, 186);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 15;
            this.textBox7.Text = "Leaf Node";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // leafDropBox3
            // 
            this.leafDropBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.leafDropBox3.FormattingEnabled = true;
            this.leafDropBox3.Items.AddRange(new object[] {
            "",
            "Walk",
            "Open Door",
            "Run",
            "Find Entrance",
            "Wander",
            "Attack",
            "Flee"});
            this.leafDropBox3.Location = new System.Drawing.Point(118, 185);
            this.leafDropBox3.Name = "leafDropBox3";
            this.leafDropBox3.Size = new System.Drawing.Size(121, 21);
            this.leafDropBox3.TabIndex = 14;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(12, 223);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 17;
            this.textBox8.Text = "Leaf Node";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // leafDropBox4
            // 
            this.leafDropBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.leafDropBox4.FormattingEnabled = true;
            this.leafDropBox4.Items.AddRange(new object[] {
            "",
            "Walk",
            "Open Door",
            "Run",
            "Find Entrance",
            "Wander",
            "Attack",
            "Flee"});
            this.leafDropBox4.Location = new System.Drawing.Point(118, 221);
            this.leafDropBox4.Name = "leafDropBox4";
            this.leafDropBox4.Size = new System.Drawing.Size(121, 21);
            this.leafDropBox4.TabIndex = 16;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(12, 258);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 19;
            this.textBox9.Text = "Leaf Node";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // leafDropBox5
            // 
            this.leafDropBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.leafDropBox5.FormattingEnabled = true;
            this.leafDropBox5.Items.AddRange(new object[] {
            "",
            "Walk",
            "Open Door",
            "Run",
            "Find Entrance",
            "Wander",
            "Attack",
            "Flee"});
            this.leafDropBox5.Location = new System.Drawing.Point(118, 257);
            this.leafDropBox5.Name = "leafDropBox5";
            this.leafDropBox5.Size = new System.Drawing.Size(121, 21);
            this.leafDropBox5.TabIndex = 18;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(12, 289);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 21;
            this.textBox10.Text = "Leaf Node";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // leafDropBox6
            // 
            this.leafDropBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.leafDropBox6.FormattingEnabled = true;
            this.leafDropBox6.Items.AddRange(new object[] {
            "",
            "Walk",
            "Open Door",
            "Run",
            "Find Entrance",
            "Wander",
            "Attack",
            "Flee"});
            this.leafDropBox6.Location = new System.Drawing.Point(118, 288);
            this.leafDropBox6.Name = "leafDropBox6";
            this.leafDropBox6.Size = new System.Drawing.Size(121, 21);
            this.leafDropBox6.TabIndex = 20;
            // 
            // NewTreeDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 316);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.leafDropBox6);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.leafDropBox5);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.leafDropBox4);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.leafDropBox3);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.leafDropBox2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.leafDropBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.decoratorDropBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.decoratorDropBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.compositeDropBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.compositeDropBox1);
            this.Controls.Add(this.newTreeDialogOkButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(526, 355);
            this.MinimumSize = new System.Drawing.Size(526, 355);
            this.Name = "NewTreeDialog";
            this.Text = "New Tree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newTreeDialogOkButton;
        private System.Windows.Forms.ComboBox compositeDropBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox compositeDropBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox decoratorDropBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox decoratorDropBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox leafDropBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox leafDropBox2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ComboBox leafDropBox3;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.ComboBox leafDropBox4;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.ComboBox leafDropBox5;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.ComboBox leafDropBox6;
    }
}