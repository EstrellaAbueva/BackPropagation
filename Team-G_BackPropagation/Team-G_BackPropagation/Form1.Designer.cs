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
            this.train = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.Button();
            this.epochs = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.weight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.neck = new System.Windows.Forms.TextBox();
            this.chest = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.abdomen = new System.Windows.Forms.TextBox();
            this.wrist = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chooseFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.forearm = new System.Windows.Forms.TextBox();
            this.biceps = new System.Windows.Forms.TextBox();
            this.ankle = new System.Windows.Forms.TextBox();
            this.knee = new System.Windows.Forms.TextBox();
            this.thigh = new System.Windows.Forms.TextBox();
            this.hip = new System.Windows.Forms.TextBox();
            this.dens = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.density = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // train
            // 
            this.train.Location = new System.Drawing.Point(220, 89);
            this.train.Name = "train";
            this.train.Size = new System.Drawing.Size(110, 40);
            this.train.TabIndex = 1;
            this.train.Text = "Train";
            this.train.UseVisualStyleBackColor = true;
            this.train.Click += new System.EventHandler(this.train_Click);
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(220, 474);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(110, 40);
            this.test.TabIndex = 2;
            this.test.Text = "Test";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // epochs
            // 
            this.epochs.Location = new System.Drawing.Point(44, 110);
            this.epochs.Name = "epochs";
            this.epochs.Size = new System.Drawing.Size(163, 20);
            this.epochs.TabIndex = 3;
            this.epochs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(94, 186);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(69, 20);
            this.age.TabIndex = 4;
            this.age.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // weight
            // 
            this.weight.Location = new System.Drawing.Point(94, 213);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(69, 20);
            this.weight.TabIndex = 5;
            this.weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Body Fat Percentage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Number of Epochs :";
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(44, 396);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(286, 61);
            this.output.TabIndex = 8;
            this.output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(94, 240);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(69, 20);
            this.height.TabIndex = 9;
            this.height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Weight";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Height";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(245, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "Possible Body Fat Percentage :";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(44, 473);
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
            // neck
            // 
            this.neck.Location = new System.Drawing.Point(94, 268);
            this.neck.Name = "neck";
            this.neck.Size = new System.Drawing.Size(69, 20);
            this.neck.TabIndex = 10;
            this.neck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chest
            // 
            this.chest.Location = new System.Drawing.Point(94, 294);
            this.chest.Name = "chest";
            this.chest.Size = new System.Drawing.Size(69, 20);
            this.chest.TabIndex = 11;
            this.chest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Neck";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Chest";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(190, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Wrist";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 328);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Abdomen";
            // 
            // abdomen
            // 
            this.abdomen.Location = new System.Drawing.Point(94, 321);
            this.abdomen.Name = "abdomen";
            this.abdomen.Size = new System.Drawing.Size(69, 20);
            this.abdomen.TabIndex = 21;
            this.abdomen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // wrist
            // 
            this.wrist.Location = new System.Drawing.Point(261, 321);
            this.wrist.Name = "wrist";
            this.wrist.Size = new System.Drawing.Size(69, 20);
            this.wrist.TabIndex = 22;
            this.wrist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseFileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(375, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chooseFileToolStripMenuItem
            // 
            this.chooseFileToolStripMenuItem.Name = "chooseFileToolStripMenuItem";
            this.chooseFileToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.chooseFileToolStripMenuItem.Text = "Choose File";
            this.chooseFileToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // forearm
            // 
            this.forearm.Location = new System.Drawing.Point(261, 294);
            this.forearm.Name = "forearm";
            this.forearm.Size = new System.Drawing.Size(69, 20);
            this.forearm.TabIndex = 30;
            this.forearm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // biceps
            // 
            this.biceps.Location = new System.Drawing.Point(261, 270);
            this.biceps.Name = "biceps";
            this.biceps.Size = new System.Drawing.Size(69, 20);
            this.biceps.TabIndex = 29;
            this.biceps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ankle
            // 
            this.ankle.Location = new System.Drawing.Point(261, 240);
            this.ankle.Name = "ankle";
            this.ankle.Size = new System.Drawing.Size(69, 20);
            this.ankle.TabIndex = 28;
            this.ankle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // knee
            // 
            this.knee.Location = new System.Drawing.Point(261, 214);
            this.knee.Name = "knee";
            this.knee.Size = new System.Drawing.Size(69, 20);
            this.knee.TabIndex = 27;
            this.knee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // thigh
            // 
            this.thigh.Location = new System.Drawing.Point(261, 190);
            this.thigh.Name = "thigh";
            this.thigh.Size = new System.Drawing.Size(69, 20);
            this.thigh.TabIndex = 26;
            this.thigh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hip
            // 
            this.hip.Location = new System.Drawing.Point(261, 163);
            this.hip.Name = "hip";
            this.hip.Size = new System.Drawing.Size(69, 20);
            this.hip.TabIndex = 25;
            this.hip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dens
            // 
            this.dens.Location = new System.Drawing.Point(94, 160);
            this.dens.Name = "dens";
            this.dens.Size = new System.Drawing.Size(69, 20);
            this.dens.TabIndex = 24;
            this.dens.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(190, 301);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Forearm";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(190, 275);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Biceps";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(190, 248);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Ankle";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(190, 220);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "Knee";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(190, 193);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Thigh";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(190, 166);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Hip";
            // 
            // density
            // 
            this.density.AutoSize = true;
            this.density.Location = new System.Drawing.Point(26, 163);
            this.density.Name = "density";
            this.density.Size = new System.Drawing.Size(42, 13);
            this.density.TabIndex = 31;
            this.density.Text = "Density";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 550);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.density);
            this.Controls.Add(this.forearm);
            this.Controls.Add(this.biceps);
            this.Controls.Add(this.ankle);
            this.Controls.Add(this.knee);
            this.Controls.Add(this.thigh);
            this.Controls.Add(this.hip);
            this.Controls.Add(this.dens);
            this.Controls.Add(this.wrist);
            this.Controls.Add(this.abdomen);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chest);
            this.Controls.Add(this.neck);
            this.Controls.Add(this.height);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.age);
            this.Controls.Add(this.epochs);
            this.Controls.Add(this.test);
            this.Controls.Add(this.train);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Team-G_BackPropagation";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button train;
        private System.Windows.Forms.Button test;
        private System.Windows.Forms.TextBox epochs;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button clear;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox wrist;
        private System.Windows.Forms.TextBox abdomen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox chest;
        private System.Windows.Forms.TextBox neck;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chooseFileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label density;
        private System.Windows.Forms.TextBox forearm;
        private System.Windows.Forms.TextBox biceps;
        private System.Windows.Forms.TextBox ankle;
        private System.Windows.Forms.TextBox knee;
        private System.Windows.Forms.TextBox thigh;
        private System.Windows.Forms.TextBox hip;
        private System.Windows.Forms.TextBox dens;
    }
}

