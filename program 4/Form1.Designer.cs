namespace program_4
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
            this.details_button = new System.Windows.Forms.Button();
            this.Check_button = new System.Windows.Forms.Button();
            this.return_button = new System.Windows.Forms.Button();
            this.booklistBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.title_textBox = new System.Windows.Forms.TextBox();
            this.author_textBox = new System.Windows.Forms.TextBox();
            this.publisher_textBox = new System.Windows.Forms.TextBox();
            this.year_textBox = new System.Windows.Forms.TextBox();
            this.number_textBox = new System.Windows.Forms.TextBox();
            this.add_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // details_button
            // 
            this.details_button.Location = new System.Drawing.Point(273, 252);
            this.details_button.Name = "details_button";
            this.details_button.Size = new System.Drawing.Size(75, 23);
            this.details_button.TabIndex = 1;
            this.details_button.Text = "Details";
            this.details_button.UseVisualStyleBackColor = true;
            this.details_button.Click += new System.EventHandler(this.details_button_Click);
            // 
            // Check_button
            // 
            this.Check_button.Location = new System.Drawing.Point(392, 252);
            this.Check_button.Name = "Check_button";
            this.Check_button.Size = new System.Drawing.Size(88, 23);
            this.Check_button.TabIndex = 2;
            this.Check_button.Text = "Check Out";
            this.Check_button.UseVisualStyleBackColor = true;
            this.Check_button.Click += new System.EventHandler(this.Check_button_Click);
            // 
            // return_button
            // 
            this.return_button.Location = new System.Drawing.Point(512, 252);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(75, 23);
            this.return_button.TabIndex = 3;
            this.return_button.Text = "Return";
            this.return_button.UseVisualStyleBackColor = true;
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
            // 
            // booklistBox
            // 
            this.booklistBox.FormattingEnabled = true;
            this.booklistBox.ItemHeight = 16;
            this.booklistBox.Location = new System.Drawing.Point(273, 12);
            this.booklistBox.Name = "booklistBox";
            this.booklistBox.Size = new System.Drawing.Size(314, 228);
            this.booklistBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Publisher ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Copyright year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Call number ";
            // 
            // title_textBox
            // 
            this.title_textBox.Location = new System.Drawing.Point(148, 31);
            this.title_textBox.Name = "title_textBox";
            this.title_textBox.Size = new System.Drawing.Size(100, 22);
            this.title_textBox.TabIndex = 10;
            // 
            // author_textBox
            // 
            this.author_textBox.Location = new System.Drawing.Point(148, 70);
            this.author_textBox.Name = "author_textBox";
            this.author_textBox.Size = new System.Drawing.Size(100, 22);
            this.author_textBox.TabIndex = 11;
            // 
            // publisher_textBox
            // 
            this.publisher_textBox.Location = new System.Drawing.Point(148, 108);
            this.publisher_textBox.Name = "publisher_textBox";
            this.publisher_textBox.Size = new System.Drawing.Size(100, 22);
            this.publisher_textBox.TabIndex = 12;
            // 
            // year_textBox
            // 
            this.year_textBox.Location = new System.Drawing.Point(148, 148);
            this.year_textBox.Name = "year_textBox";
            this.year_textBox.Size = new System.Drawing.Size(100, 22);
            this.year_textBox.TabIndex = 13;
            // 
            // number_textBox
            // 
            this.number_textBox.Location = new System.Drawing.Point(148, 188);
            this.number_textBox.Name = "number_textBox";
            this.number_textBox.Size = new System.Drawing.Size(100, 22);
            this.number_textBox.TabIndex = 14;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(36, 251);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 15;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(148, 251);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(75, 23);
            this.exit_button.TabIndex = 16;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 301);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.number_textBox);
            this.Controls.Add(this.year_textBox);
            this.Controls.Add(this.publisher_textBox);
            this.Controls.Add(this.author_textBox);
            this.Controls.Add(this.title_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.booklistBox);
            this.Controls.Add(this.return_button);
            this.Controls.Add(this.Check_button);
            this.Controls.Add(this.details_button);
            this.Name = "Form1";
            this.Text = "program4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button details_button;
        private System.Windows.Forms.Button Check_button;
        private System.Windows.Forms.Button return_button;
        private System.Windows.Forms.ListBox booklistBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox title_textBox;
        private System.Windows.Forms.TextBox author_textBox;
        private System.Windows.Forms.TextBox publisher_textBox;
        private System.Windows.Forms.TextBox year_textBox;
        private System.Windows.Forms.TextBox number_textBox;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button exit_button;
    }
}

