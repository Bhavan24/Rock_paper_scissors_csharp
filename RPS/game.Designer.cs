namespace RPS
{
    partial class game
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.userscore = new System.Windows.Forms.TextBox();
            this.comscore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.compic = new System.Windows.Forms.PictureBox();
            this.userpic = new System.Windows.Forms.PictureBox();
            this.rock = new System.Windows.Forms.Button();
            this.paper = new System.Windows.Forms.Button();
            this.scissors = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userpic)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.rock);
            this.flowLayoutPanel1.Controls.Add(this.paper);
            this.flowLayoutPanel1.Controls.Add(this.scissors);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(132, 390);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // userscore
            // 
            this.userscore.Enabled = false;
            this.userscore.Location = new System.Drawing.Point(251, 140);
            this.userscore.Name = "userscore";
            this.userscore.Size = new System.Drawing.Size(24, 20);
            this.userscore.TabIndex = 3;
            // 
            // comscore
            // 
            this.comscore.Enabled = false;
            this.comscore.Location = new System.Drawing.Point(261, 311);
            this.comscore.Name = "comscore";
            this.comscore.Size = new System.Drawing.Size(24, 20);
            this.comscore.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Simpleness-Regular", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Computer";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("PRIMETIME", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(165, 343);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(18, 27);
            this.status.TabIndex = 5;
            this.status.Text = " ";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Simpleness-Regular", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(179, 135);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(57, 25);
            this.username.TabIndex = 2;
            this.username.Text = " USER";
            // 
            // compic
            // 
            this.compic.Location = new System.Drawing.Point(168, 180);
            this.compic.Name = "compic";
            this.compic.Size = new System.Drawing.Size(121, 116);
            this.compic.TabIndex = 1;
            this.compic.TabStop = false;
            // 
            // userpic
            // 
            this.userpic.Location = new System.Drawing.Point(168, 12);
            this.userpic.Name = "userpic";
            this.userpic.Size = new System.Drawing.Size(121, 116);
            this.userpic.TabIndex = 1;
            this.userpic.TabStop = false;
            // 
            // rock
            // 
            this.rock.Image = global::RPS.Properties.Resources.rock;
            this.rock.Location = new System.Drawing.Point(3, 3);
            this.rock.Name = "rock";
            this.rock.Size = new System.Drawing.Size(124, 121);
            this.rock.TabIndex = 1;
            this.rock.Text = " ";
            this.rock.UseVisualStyleBackColor = true;
            this.rock.Click += new System.EventHandler(this.rock_Click);
            // 
            // paper
            // 
            this.paper.Image = global::RPS.Properties.Resources.paper;
            this.paper.Location = new System.Drawing.Point(3, 130);
            this.paper.Name = "paper";
            this.paper.Size = new System.Drawing.Size(124, 125);
            this.paper.TabIndex = 1;
            this.paper.Text = " ";
            this.paper.UseVisualStyleBackColor = true;
            this.paper.Click += new System.EventHandler(this.paper_Click);
            // 
            // scissors
            // 
            this.scissors.Image = global::RPS.Properties.Resources.scissors;
            this.scissors.Location = new System.Drawing.Point(3, 261);
            this.scissors.Name = "scissors";
            this.scissors.Size = new System.Drawing.Size(124, 125);
            this.scissors.TabIndex = 1;
            this.scissors.Text = " ";
            this.scissors.UseVisualStyleBackColor = true;
            this.scissors.Click += new System.EventHandler(this.scissors_Click);
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(310, 390);
            this.Controls.Add(this.status);
            this.Controls.Add(this.comscore);
            this.Controls.Add(this.userscore);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.compic);
            this.Controls.Add(this.userpic);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "game";
            this.Text = "GAME";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.compic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button rock;
        private System.Windows.Forms.Button paper;
        private System.Windows.Forms.Button scissors;
        private System.Windows.Forms.PictureBox userpic;
        private System.Windows.Forms.PictureBox compic;
        private System.Windows.Forms.TextBox userscore;
        private System.Windows.Forms.TextBox comscore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label username;
    }
}