namespace Pokemon112
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbPokemonName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelSpecies;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelHP;
        private System.Windows.Forms.Label labelAttack;
        private System.Windows.Forms.Label labelDefense;
        private System.Windows.Forms.Label labelSpecialAttack;
        private System.Windows.Forms.Label labelSpecialDefense;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelTotal;

        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbPokemonName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelSpecies = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelHP = new System.Windows.Forms.Label();
            this.labelAttack = new System.Windows.Forms.Label();
            this.labelDefense = new System.Windows.Forms.Label();
            this.labelSpecialAttack = new System.Windows.Forms.Label();
            this.labelSpecialDefense = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(279, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 278);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbPokemonName
            // 
            this.lbPokemonName.AutoSize = true;
            this.lbPokemonName.Location = new System.Drawing.Point(414, 366);
            this.lbPokemonName.Name = "lbPokemonName";
            this.lbPokemonName.Size = new System.Drawing.Size(0, 13);
            this.lbPokemonName.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(683, 55);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(683, 94);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(31, 13);
            this.labelType.TabIndex = 3;
            this.labelType.Text = "Type";
            // 
            // labelSpecies
            // 
            this.labelSpecies.AutoSize = true;
            this.labelSpecies.Location = new System.Drawing.Point(696, 130);
            this.labelSpecies.Name = "labelSpecies";
            this.labelSpecies.Size = new System.Drawing.Size(0, 13);
            this.labelSpecies.TabIndex = 4;
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(683, 130);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(38, 13);
            this.labelHeight.TabIndex = 5;
            this.labelHeight.Text = "Height";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(683, 170);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(41, 13);
            this.labelWeight.TabIndex = 6;
            this.labelWeight.Text = "Weight";
            // 
            // labelHP
            // 
            this.labelHP.AutoSize = true;
            this.labelHP.Location = new System.Drawing.Point(683, 210);
            this.labelHP.Name = "labelHP";
            this.labelHP.Size = new System.Drawing.Size(22, 13);
            this.labelHP.TabIndex = 7;
            this.labelHP.Text = "HP";
            // 
            // labelAttack
            // 
            this.labelAttack.AutoSize = true;
            this.labelAttack.Location = new System.Drawing.Point(683, 244);
            this.labelAttack.Name = "labelAttack";
            this.labelAttack.Size = new System.Drawing.Size(38, 13);
            this.labelAttack.TabIndex = 8;
            this.labelAttack.Text = "Attack";
            // 
            // labelDefense
            // 
            this.labelDefense.AutoSize = true;
            this.labelDefense.Location = new System.Drawing.Point(683, 283);
            this.labelDefense.Name = "labelDefense";
            this.labelDefense.Size = new System.Drawing.Size(47, 13);
            this.labelDefense.TabIndex = 9;
            this.labelDefense.Text = "Defense";
            this.labelDefense.Click += new System.EventHandler(this.labelDefense_Click);
            // 
            // labelSpecialAttack
            // 
            this.labelSpecialAttack.AutoSize = true;
            this.labelSpecialAttack.Location = new System.Drawing.Point(696, 250);
            this.labelSpecialAttack.Name = "labelSpecialAttack";
            this.labelSpecialAttack.Size = new System.Drawing.Size(0, 13);
            this.labelSpecialAttack.TabIndex = 10;
            // 
            // labelSpecialDefense
            // 
            this.labelSpecialDefense.AutoSize = true;
            this.labelSpecialDefense.Location = new System.Drawing.Point(696, 270);
            this.labelSpecialDefense.Name = "labelSpecialDefense";
            this.labelSpecialDefense.Size = new System.Drawing.Size(0, 13);
            this.labelSpecialDefense.TabIndex = 11;
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(696, 257);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(0, 13);
            this.labelSpeed.TabIndex = 12;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(683, 326);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(31, 13);
            this.labelTotal.TabIndex = 13;
            this.labelTotal.Text = "Total";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 54);
            this.button1.TabIndex = 14;
            this.button1.Text = "Pikachu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 52);
            this.button2.TabIndex = 15;
            this.button2.Text = "Charmeleon";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(28, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 51);
            this.button3.TabIndex = 16;
            this.button3.Text = "Nidorina";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(28, 225);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(178, 53);
            this.button4.TabIndex = 17;
            this.button4.Text = "Sandslash";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(28, 283);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(178, 48);
            this.button5.TabIndex = 18;
            this.button5.Text = "Snorlax";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(28, 337);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(178, 51);
            this.button6.TabIndex = 19;
            this.button6.Text = "Clefairy";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(741, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(745, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(745, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(745, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Weight";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(745, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "HP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(745, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Attack";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(745, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Defense";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(745, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 526);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbPokemonName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelSpecies);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelHP);
            this.Controls.Add(this.labelAttack);
            this.Controls.Add(this.labelDefense);
            this.Controls.Add(this.labelSpecialAttack);
            this.Controls.Add(this.labelSpecialDefense);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.labelTotal);
            this.Name = "Form1";
            this.Text = "Pokemon";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

