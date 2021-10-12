namespace ElectroEnergy
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.currentTextBox = new System.Windows.Forms.TextBox();
            this.prevTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prev:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // currentTextBox
            // 
            this.currentTextBox.Location = new System.Drawing.Point(114, 70);
            this.currentTextBox.Name = "currentTextBox";
            this.currentTextBox.Size = new System.Drawing.Size(144, 20);
            this.currentTextBox.TabIndex = 2;
            this.currentTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // prevTextBox
            // 
            this.prevTextBox.Location = new System.Drawing.Point(114, 37);
            this.prevTextBox.Name = "prevTextBox";
            this.prevTextBox.Size = new System.Drawing.Size(144, 20);
            this.prevTextBox.TabIndex = 3;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(114, 119);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(144, 20);
            this.priceTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price: Uz/kvt:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Count";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // resultLabel
            // 
            this.resultLabel.Location = new System.Drawing.Point(18, 206);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(240, 47);
            this.resultLabel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 265);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prevTextBox);
            this.Controls.Add(this.currentTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Electroenergy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox currentTextBox;
        private System.Windows.Forms.TextBox prevTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label resultLabel;
    }
}

