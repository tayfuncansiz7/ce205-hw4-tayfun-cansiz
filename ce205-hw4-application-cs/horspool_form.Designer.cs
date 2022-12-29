namespace ce205_hw4_application_cs
{
    partial class horspool_form
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
            this.randomButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.resultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.patternRichTextBox = new System.Windows.Forms.RichTextBox();
            this.inputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // randomButton
            // 
            this.randomButton.Font = new System.Drawing.Font("Bahnschrift", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.randomButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.randomButton.Location = new System.Drawing.Point(343, 47);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(405, 66);
            this.randomButton.TabIndex = 11;
            this.randomButton.Text = "Random Text";
            this.randomButton.UseVisualStyleBackColor = true;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(23, 226);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 16);
            this.resultLabel.TabIndex = 10;
            this.resultLabel.Click += new System.EventHandler(this.resultLabel_Click);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Bahnschrift", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.searchButton.Location = new System.Drawing.Point(343, 129);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(405, 66);
            this.searchButton.TabIndex = 9;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // resultRichTextBox
            // 
            this.resultRichTextBox.Location = new System.Drawing.Point(343, 223);
            this.resultRichTextBox.Name = "resultRichTextBox";
            this.resultRichTextBox.Size = new System.Drawing.Size(405, 215);
            this.resultRichTextBox.TabIndex = 8;
            this.resultRichTextBox.Text = "";
            this.resultRichTextBox.TextChanged += new System.EventHandler(this.resultRichTextBox_TextChanged);
            // 
            // patternRichTextBox
            // 
            this.patternRichTextBox.Location = new System.Drawing.Point(12, 223);
            this.patternRichTextBox.Name = "patternRichTextBox";
            this.patternRichTextBox.Size = new System.Drawing.Size(229, 215);
            this.patternRichTextBox.TabIndex = 7;
            this.patternRichTextBox.Text = "";
            this.patternRichTextBox.TextChanged += new System.EventHandler(this.patternRichTextBox_TextChanged);
            // 
            // inputRichTextBox
            // 
            this.inputRichTextBox.Location = new System.Drawing.Point(12, 47);
            this.inputRichTextBox.Name = "inputRichTextBox";
            this.inputRichTextBox.Size = new System.Drawing.Size(229, 148);
            this.inputRichTextBox.TabIndex = 6;
            this.inputRichTextBox.Text = "";
            this.inputRichTextBox.TextChanged += new System.EventHandler(this.inputRichTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(12, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Pattern";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Input";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // horspool_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.randomButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.resultRichTextBox);
            this.Controls.Add(this.patternRichTextBox);
            this.Controls.Add(this.inputRichTextBox);
            this.Name = "horspool_form";
            this.Text = "horspool_form";
            this.Load += new System.EventHandler(this.horspool_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button randomButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.RichTextBox resultRichTextBox;
        private System.Windows.Forms.RichTextBox patternRichTextBox;
        private System.Windows.Forms.RichTextBox inputRichTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}