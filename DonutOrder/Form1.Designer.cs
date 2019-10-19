namespace DonutOrder
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
            this.plainBox = new System.Windows.Forms.TextBox();
            this.jellyBox = new System.Windows.Forms.TextBox();
            this.glazeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.sprinkleJellyCheck = new System.Windows.Forms.CheckBox();
            this.sprinkleGlazeCheck = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lable5 = new System.Windows.Forms.Label();
            this.totalCost = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // plainBox
            // 
            this.plainBox.Location = new System.Drawing.Point(24, 138);
            this.plainBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.plainBox.Name = "plainBox";
            this.plainBox.Size = new System.Drawing.Size(196, 31);
            this.plainBox.TabIndex = 0;
            this.plainBox.Text = "0";
            // 
            // jellyBox
            // 
            this.jellyBox.Location = new System.Drawing.Point(24, 226);
            this.jellyBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.jellyBox.Name = "jellyBox";
            this.jellyBox.Size = new System.Drawing.Size(196, 31);
            this.jellyBox.TabIndex = 1;
            this.jellyBox.Text = "0";
            // 
            // glazeBox
            // 
            this.glazeBox.Location = new System.Drawing.Point(24, 347);
            this.glazeBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.glazeBox.Name = "glazeBox";
            this.glazeBox.Size = new System.Drawing.Size(196, 31);
            this.glazeBox.TabIndex = 2;
            this.glazeBox.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Donut Order- 10% discount per a dozen*";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(458, 82);
            this.calcButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(212, 44);
            this.calcButton.TabIndex = 4;
            this.calcButton.Text = "Calculate Total";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // sprinkleJellyCheck
            // 
            this.sprinkleJellyCheck.AutoSize = true;
            this.sprinkleJellyCheck.Location = new System.Drawing.Point(274, 228);
            this.sprinkleJellyCheck.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.sprinkleJellyCheck.Name = "sprinkleJellyCheck";
            this.sprinkleJellyCheck.Size = new System.Drawing.Size(224, 29);
            this.sprinkleJellyCheck.TabIndex = 5;
            this.sprinkleJellyCheck.Text = "Add Sprinkles $0.25";
            this.sprinkleJellyCheck.UseVisualStyleBackColor = true;
            // 
            // sprinkleGlazeCheck
            // 
            this.sprinkleGlazeCheck.AutoSize = true;
            this.sprinkleGlazeCheck.Location = new System.Drawing.Point(274, 347);
            this.sprinkleGlazeCheck.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.sprinkleGlazeCheck.Name = "sprinkleGlazeCheck";
            this.sprinkleGlazeCheck.Size = new System.Drawing.Size(224, 29);
            this.sprinkleGlazeCheck.TabIndex = 6;
            this.sprinkleGlazeCheck.Text = "Add Sprinkles $0.25";
            this.sprinkleGlazeCheck.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Plain Donuts ($1)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Jelly Donuts ($1.50)";
            // 
            // lable5
            // 
            this.lable5.AutoSize = true;
            this.lable5.Location = new System.Drawing.Point(19, 316);
            this.lable5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lable5.Name = "lable5";
            this.lable5.Size = new System.Drawing.Size(216, 25);
            this.lable5.TabIndex = 9;
            this.lable5.Text = "Glaze Donuts ($1.25)";
            // 
            // totalCost
            // 
            this.totalCost.AutoSize = true;
            this.totalCost.Location = new System.Drawing.Point(453, 155);
            this.totalCost.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.totalCost.Name = "totalCost";
            this.totalCost.Size = new System.Drawing.Size(110, 25);
            this.totalCost.TabIndex = 10;
            this.totalCost.Text = "Total Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(158, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "*only applies to donuts of the same type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 426);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.totalCost);
            this.Controls.Add(this.lable5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sprinkleGlazeCheck);
            this.Controls.Add(this.sprinkleJellyCheck);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.glazeBox);
            this.Controls.Add(this.jellyBox);
            this.Controls.Add(this.plainBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox plainBox;
        private System.Windows.Forms.TextBox jellyBox;
        private System.Windows.Forms.TextBox glazeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.CheckBox sprinkleJellyCheck;
        private System.Windows.Forms.CheckBox sprinkleGlazeCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lable5;
        private System.Windows.Forms.Label totalCost;
        private System.Windows.Forms.Label label4;
    }
}

