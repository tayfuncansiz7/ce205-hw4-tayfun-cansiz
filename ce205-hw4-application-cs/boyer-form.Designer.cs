namespace BoyerMooreGUI
{
    partial class boyer_form
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
            this.inputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.textRichTextBox = new System.Windows.Forms.RichTextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.RichTextBox();
            this.randomButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputRichTextBox
            // 
            this.inputRichTextBox.Location = new System.Drawing.Point(16, 49);
            this.inputRichTextBox.Name = "inputRichTextBox";
            this.inputRichTextBox.Size = new System.Drawing.Size(270, 151);
            this.inputRichTextBox.TabIndex = 8;
            this.inputRichTextBox.Text = "";
            this.inputRichTextBox.TextChanged += new System.EventHandler(this.inputRichTextBox_TextChanged_1);
            // 
            // textRichTextBox
            // 
            this.textRichTextBox.Location = new System.Drawing.Point(390, 188);
            this.textRichTextBox.Name = "textRichTextBox";
            this.textRichTextBox.Size = new System.Drawing.Size(360, 250);
            this.textRichTextBox.TabIndex = 9;
            this.textRichTextBox.Text = "";
            this.textRichTextBox.TextChanged += new System.EventHandler(this.textRichTextBox_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.searchButton.Location = new System.Drawing.Point(390, 124);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(360, 39);
            this.searchButton.TabIndex = 10;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click_1);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.addButton.Location = new System.Drawing.Point(390, 24);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(360, 40);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click1);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(26, 236);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 16);
            this.resultLabel.TabIndex = 13;
            this.resultLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(16, 255);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(270, 172);
            this.searchTextBox.TabIndex = 15;
            this.searchTextBox.Text = "";
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // randomButton
            // 
            this.randomButton.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.randomButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.randomButton.Location = new System.Drawing.Point(390, 70);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(360, 48);
            this.randomButton.TabIndex = 16;
            this.randomButton.Text = "Random Text";
            this.randomButton.UseVisualStyleBackColor = true;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(12, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Pattern";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SaddleBrown;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "Input";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // boyer_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.randomButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.textRichTextBox);
            this.Controls.Add(this.inputRichTextBox);
            this.Name = "boyer_form";
            this.Text = "Boyer Form";
            this.Load += new System.EventHandler(this.BoyerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox inputRichTextBox;
        private System.Windows.Forms.RichTextBox textRichTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.RichTextBox searchTextBox;
        private System.Windows.Forms.Button randomButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}