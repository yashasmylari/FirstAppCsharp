
namespace FirstAppCsharp
{
    partial class FrmFirstApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFirstApp));
            this.label1 = new System.Windows.Forms.Label();
            this.PicOne = new System.Windows.Forms.PictureBox();
            this.PicTwo = new System.Windows.Forms.PictureBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.BtnHello = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.GrpMood = new System.Windows.Forms.GroupBox();
            this.RdConfused = new System.Windows.Forms.RadioButton();
            this.RdBalance = new System.Windows.Forms.RadioButton();
            this.RdSuccess = new System.Windows.Forms.RadioButton();
            this.RdPath = new System.Windows.Forms.RadioButton();
            this.LblQuestion = new System.Windows.Forms.Label();
            this.LblAnswer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicTwo)).BeginInit();
            this.GrpMood.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(211, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to My first Program ";
            // 
            // PicOne
            // 
            this.PicOne.Image = ((System.Drawing.Image)(resources.GetObject("PicOne.Image")));
            this.PicOne.Location = new System.Drawing.Point(12, 118);
            this.PicOne.Name = "PicOne";
            this.PicOne.Size = new System.Drawing.Size(382, 260);
            this.PicOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicOne.TabIndex = 1;
            this.PicOne.TabStop = false;
            this.PicOne.Visible = false;
            // 
            // PicTwo
            // 
            this.PicTwo.Image = global::FirstAppCsharp.Properties.Resources._38d7957be5c7f4372b0185d2490aefea;
            this.PicTwo.Location = new System.Drawing.Point(406, 118);
            this.PicTwo.Name = "PicTwo";
            this.PicTwo.Size = new System.Drawing.Size(382, 260);
            this.PicTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicTwo.TabIndex = 2;
            this.PicTwo.TabStop = false;
            this.PicTwo.Visible = false;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(301, 89);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(204, 23);
            this.TxtName.TabIndex = 3;
            // 
            // BtnHello
            // 
            this.BtnHello.Location = new System.Drawing.Point(12, 89);
            this.BtnHello.Name = "BtnHello";
            this.BtnHello.Size = new System.Drawing.Size(86, 23);
            this.BtnHello.TabIndex = 4;
            this.BtnHello.Text = "Hello";
            this.BtnHello.UseVisualStyleBackColor = true;
            this.BtnHello.Click += new System.EventHandler(this.BtnHello_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(713, 403);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // GrpMood
            // 
            this.GrpMood.Controls.Add(this.RdConfused);
            this.GrpMood.Controls.Add(this.RdBalance);
            this.GrpMood.Controls.Add(this.RdSuccess);
            this.GrpMood.Controls.Add(this.RdPath);
            this.GrpMood.Location = new System.Drawing.Point(12, 384);
            this.GrpMood.Name = "GrpMood";
            this.GrpMood.Size = new System.Drawing.Size(639, 42);
            this.GrpMood.TabIndex = 6;
            this.GrpMood.TabStop = false;
            this.GrpMood.Text = "PickOne";
            // 
            // RdConfused
            // 
            this.RdConfused.AutoSize = true;
            this.RdConfused.Location = new System.Drawing.Point(520, 19);
            this.RdConfused.Name = "RdConfused";
            this.RdConfused.Size = new System.Drawing.Size(76, 19);
            this.RdConfused.TabIndex = 3;
            this.RdConfused.TabStop = true;
            this.RdConfused.Text = "Confused";
            this.RdConfused.UseVisualStyleBackColor = true;
            this.RdConfused.CheckedChanged += new System.EventHandler(this.RdConfused_CheckedChanged);
            // 
            // RdBalance
            // 
            this.RdBalance.AutoSize = true;
            this.RdBalance.Location = new System.Drawing.Point(356, 19);
            this.RdBalance.Name = "RdBalance";
            this.RdBalance.Size = new System.Drawing.Size(94, 19);
            this.RdBalance.TabIndex = 2;
            this.RdBalance.TabStop = true;
            this.RdBalance.Text = "Balance both";
            this.RdBalance.UseVisualStyleBackColor = true;
            this.RdBalance.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // RdSuccess
            // 
            this.RdSuccess.AutoSize = true;
            this.RdSuccess.Location = new System.Drawing.Point(199, 19);
            this.RdSuccess.Name = "RdSuccess";
            this.RdSuccess.Size = new System.Drawing.Size(66, 19);
            this.RdSuccess.TabIndex = 1;
            this.RdSuccess.TabStop = true;
            this.RdSuccess.Text = "Success";
            this.RdSuccess.UseVisualStyleBackColor = true;
            this.RdSuccess.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // RdPath
            // 
            this.RdPath.AutoSize = true;
            this.RdPath.Location = new System.Drawing.Point(7, 19);
            this.RdPath.Name = "RdPath";
            this.RdPath.Size = new System.Drawing.Size(107, 19);
            this.RdPath.TabIndex = 0;
            this.RdPath.TabStop = true;
            this.RdPath.Text = "Path to Success";
            this.RdPath.UseVisualStyleBackColor = true;
            this.RdPath.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // LblQuestion
            // 
            this.LblQuestion.AutoSize = true;
            this.LblQuestion.Font = new System.Drawing.Font("Bernard MT Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblQuestion.Location = new System.Drawing.Point(241, 182);
            this.LblQuestion.Name = "LblQuestion";
            this.LblQuestion.Size = new System.Drawing.Size(325, 44);
            this.LblQuestion.TabIndex = 7;
            this.LblQuestion.Text = "What do want in Life?";
            // 
            // LblAnswer
            // 
            this.LblAnswer.AutoSize = true;
            this.LblAnswer.Font = new System.Drawing.Font("Bernard MT Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblAnswer.Location = new System.Drawing.Point(105, 273);
            this.LblAnswer.Name = "LblAnswer";
            this.LblAnswer.Size = new System.Drawing.Size(621, 57);
            this.LblAnswer.TabIndex = 8;
            this.LblAnswer.Text = "Decide before making any move";
            // 
            // FrmFirstApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblAnswer);
            this.Controls.Add(this.LblQuestion);
            this.Controls.Add(this.GrpMood);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnHello);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.PicTwo);
            this.Controls.Add(this.PicOne);
            this.Controls.Add(this.label1);
            this.Name = "FrmFirstApp";
            this.Text = "FirstApp";
            ((System.ComponentModel.ISupportInitialize)(this.PicOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicTwo)).EndInit();
            this.GrpMood.ResumeLayout(false);
            this.GrpMood.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PicOne;
        private System.Windows.Forms.PictureBox PicTwo;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Button BtnHello;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.GroupBox GrpMood;
        private System.Windows.Forms.RadioButton RdSuccess;
        private System.Windows.Forms.RadioButton RdPath;
        private System.Windows.Forms.RadioButton RdBalance;
        private System.Windows.Forms.Label LblQuestion;
        private System.Windows.Forms.RadioButton RdConfused;
        private System.Windows.Forms.Label LblAnswer;
    }
}

