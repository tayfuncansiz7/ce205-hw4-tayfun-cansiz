namespace ce205_hw4_application_cs
{
    partial class knuth_form
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
            this.patternRichTextBox = new System.Windows.Forms.RichTextBox();
            this.resultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.randomButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputRichTextBox
            // 
            this.inputRichTextBox.Location = new System.Drawing.Point(45, 57);
            this.inputRichTextBox.Name = "inputRichTextBox";
            this.inputRichTextBox.Size = new System.Drawing.Size(229, 148);
            this.inputRichTextBox.TabIndex = 0;
            this.inputRichTextBox.Text = "";
            this.inputRichTextBox.TextChanged += new System.EventHandler(this.inputRichTextBox_TextChanged);
            // 
            // patternRichTextBox
            // 
            this.patternRichTextBox.Location = new System.Drawing.Point(45, 237);
            this.patternRichTextBox.Name = "patternRichTextBox";
            this.patternRichTextBox.Size = new System.Drawing.Size(229, 56);
            this.patternRichTextBox.TabIndex = 1;
            this.patternRichTextBox.Text = "";
            this.patternRichTextBox.TextChanged += new System.EventHandler(this.patternRichTextBox_TextChanged);
            // 
            // resultRichTextBox
            // 
            this.resultRichTextBox.Location = new System.Drawing.Point(332, 219);
            this.resultRichTextBox.Name = "resultRichTextBox";
            this.resultRichTextBox.Size = new System.Drawing.Size(405, 195);
            this.resultRichTextBox.TabIndex = 2;
            this.resultRichTextBox.Text = "";
            this.resultRichTextBox.TextChanged += new System.EventHandler(this.resultRichTextBox_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Bahnschrift", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.searchButton.Location = new System.Drawing.Point(332, 139);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(405, 66);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(42, 312);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 16);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.Click += new System.EventHandler(this.resultLabel_Click);
            // 
            // randomButton
            // 
            this.randomButton.Font = new System.Drawing.Font("Bahnschrift", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.randomButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.randomButton.Location = new System.Drawing.Point(332, 57);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(405, 66);
            this.randomButton.TabIndex = 5;
            this.randomButton.Text = "Random Text";
            this.randomButton.UseVisualStyleBackColor = true;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(46, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Input";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(46, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pattern";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // knuth_form
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
            this.Name = "knuth_form";
            this.Text = "knuth_form";
            this.Load += new System.EventHandler(this.knuth_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox inputRichTextBox;
        private System.Windows.Forms.RichTextBox patternRichTextBox;
        private System.Windows.Forms.RichTextBox resultRichTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button randomButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}