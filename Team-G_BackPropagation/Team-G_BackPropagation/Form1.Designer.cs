namespace Team_G_BackPropagation
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
            this.create = new System.Windows.Forms.Button();
            this.train = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.Button();
            this.epochs = new System.Windows.Forms.TextBox();
            this.bedroom = new System.Windows.Forms.TextBox();
            this.bathroom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.Label();
            this.living = new System.Windows.Forms.TextBox();
            this.lot = new System.Windows.Forms.TextBox();
            this.condition = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(26, 55);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(110, 40);
            this.create.TabIndex = 0;
            this.create.Text = "Create Model";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // train
            // 
            this.train.Location = new System.Drawing.Point(26, 101);
            this.train.Name = "train";
            this.train.Size = new System.Drawing.Size(110, 40);
            this.train.TabIndex = 1;
            this.train.Text = "Train";
            this.train.UseVisualStyleBackColor = true;
            this.train.Click += new System.EventHandler(this.train_Click);
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(26, 147);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(110, 40);
            this.test.TabIndex = 2;
            this.test.Text = "Test";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // epochs
            // 
            this.epochs.Location = new System.Drawing.Point(164, 121);
            this.epochs.Name = "epochs";
            this.epochs.Size = new System.Drawing.Size(163, 20);
            this.epochs.TabIndex = 3;
            this.epochs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bedroom
            // 
            this.bedroom.Location = new System.Drawing.Point(164, 201);
            this.bedroom.Name = "bedroom";
            this.bedroom.Size = new System.Drawing.Size(163, 20);
            this.bedroom.TabIndex = 4;
            this.bedroom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bathroom
            // 
            this.bathroom.Location = new System.Drawing.Point(164, 228);
            this.bathroom.Name = "bathroom";
            this.bathroom.Size = new System.Drawing.Size(163, 20);
            this.bathroom.TabIndex = 5;
            this.bathroom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Housing Pricing in Melbourne";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "How many epochs?";
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(40, 383);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(277, 61);
            this.output.TabIndex = 8;
            this.output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // living
            // 
            this.living.Location = new System.Drawing.Point(164, 255);
            this.living.Name = "living";
            this.living.Size = new System.Drawing.Size(163, 20);
            this.living.TabIndex = 9;
            this.living.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lot
            // 
            this.lot.Location = new System.Drawing.Point(164, 282);
            this.lot.Name = "lot";
            this.lot.Size = new System.Drawing.Size(163, 20);
            this.lot.TabIndex = 10;
            this.lot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // condition
            // 
            this.condition.Location = new System.Drawing.Point(164, 309);
            this.condition.Name = "condition";
            this.condition.Size = new System.Drawing.Size(163, 20);
            this.condition.TabIndex = 11;
            this.condition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.condition.TextChanged += new System.EventHandler(this.condition_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Number of Bedrooms";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Number of Bathrooms";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "SqFt_Living";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Lot";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Condition";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "Possible House Price:";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(239, 452);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(110, 41);
            this.clear.TabIndex = 18;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 504);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.condition);
            this.Controls.Add(this.lot);
            this.Controls.Add(this.living);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bathroom);
            this.Controls.Add(this.bedroom);
            this.Controls.Add(this.epochs);
            this.Controls.Add(this.test);
            this.Controls.Add(this.train);
            this.Controls.Add(this.create);
            this.Name = "Form1";
            this.Text = "Team-G_BackPropagation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button train;
        private System.Windows.Forms.Button test;
        private System.Windows.Forms.TextBox epochs;
        private System.Windows.Forms.TextBox bedroom;
        private System.Windows.Forms.TextBox bathroom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.TextBox living;
        private System.Windows.Forms.TextBox lot;
        private System.Windows.Forms.TextBox condition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button clear;
    }
}

