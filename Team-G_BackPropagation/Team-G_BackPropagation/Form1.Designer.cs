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
            this.age = new System.Windows.Forms.TextBox();
            this.weight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.Label();
            this.neck = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.abdomen = new System.Windows.Forms.TextBox();
            this.thigh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.forearm = new System.Windows.Forms.TextBox();
            this.wrist = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
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
            // age
            // 
            this.age.Location = new System.Drawing.Point(164, 201);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(163, 20);
            this.age.TabIndex = 4;
            this.age.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // weight
            // 
            this.weight.Location = new System.Drawing.Point(164, 228);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(163, 20);
            this.weight.TabIndex = 5;
            this.weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.weight.TextChanged += new System.EventHandler(this.bathroom_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Housing Pricinng";
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
            this.output.Location = new System.Drawing.Point(54, 428);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(277, 61);
            this.output.TabIndex = 8;
            this.output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // neck
            // 
            this.neck.Location = new System.Drawing.Point(164, 255);
            this.neck.Name = "neck";
            this.neck.Size = new System.Drawing.Size(163, 20);
            this.neck.TabIndex = 9;
            this.neck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Weight";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Neck";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "Possible House Price:";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(253, 497);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(110, 41);
            this.clear.TabIndex = 18;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // abdomen
            // 
            this.abdomen.Location = new System.Drawing.Point(164, 282);
            this.abdomen.Name = "abdomen";
            this.abdomen.Size = new System.Drawing.Size(163, 20);
            this.abdomen.TabIndex = 10;
            this.abdomen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // thigh
            // 
            this.thigh.Location = new System.Drawing.Point(164, 309);
            this.thigh.Name = "thigh";
            this.thigh.Size = new System.Drawing.Size(163, 20);
            this.thigh.TabIndex = 11;
            this.thigh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Abdomen";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Thigh";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 366);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Wrist";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 339);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Forearm";
            // 
            // forearm
            // 
            this.forearm.Location = new System.Drawing.Point(164, 336);
            this.forearm.Name = "forearm";
            this.forearm.Size = new System.Drawing.Size(163, 20);
            this.forearm.TabIndex = 21;
            this.forearm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // wrist
            // 
            this.wrist.Location = new System.Drawing.Point(164, 366);
            this.wrist.Name = "wrist";
            this.wrist.Size = new System.Drawing.Size(163, 20);
            this.wrist.TabIndex = 22;
            this.wrist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 550);
            this.Controls.Add(this.wrist);
            this.Controls.Add(this.forearm);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.thigh);
            this.Controls.Add(this.abdomen);
            this.Controls.Add(this.neck);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.age);
            this.Controls.Add(this.epochs);
            this.Controls.Add(this.test);
            this.Controls.Add(this.train);
            this.Controls.Add(this.create);
            this.Name = "Form1";
            this.Text = "Team-G_BackPropagation";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button train;
        private System.Windows.Forms.Button test;
        private System.Windows.Forms.TextBox epochs;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.TextBox neck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button clear;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox wrist;
        private System.Windows.Forms.TextBox forearm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox thigh;
        private System.Windows.Forms.TextBox abdomen;
    }
}

