namespace Project
{
    partial class FitnessCentre
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
            this.Trainers = new System.Windows.Forms.Button();
            this.Clients = new System.Windows.Forms.Button();
            this.Classes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fitness centre ";
            // 
            // Trainers
            // 
            this.Trainers.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trainers.Location = new System.Drawing.Point(745, 114);
            this.Trainers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Trainers.Name = "Trainers";
            this.Trainers.Size = new System.Drawing.Size(212, 62);
            this.Trainers.TabIndex = 2;
            this.Trainers.Text = "Trainers";
            this.Trainers.UseVisualStyleBackColor = true;
            this.Trainers.Click += new System.EventHandler(this.Trainers_Click);
            // 
            // Clients
            // 
            this.Clients.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clients.Location = new System.Drawing.Point(745, 260);
            this.Clients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Clients.Name = "Clients";
            this.Clients.Size = new System.Drawing.Size(212, 64);
            this.Clients.TabIndex = 3;
            this.Clients.Text = "Clients";
            this.Clients.UseVisualStyleBackColor = true;
            this.Clients.Click += new System.EventHandler(this.Clients_Click);
            // 
            // Classes
            // 
            this.Classes.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Classes.Location = new System.Drawing.Point(745, 410);
            this.Classes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Classes.Name = "Classes";
            this.Classes.Size = new System.Drawing.Size(212, 64);
            this.Classes.TabIndex = 4;
            this.Classes.Text = "Classes";
            this.Classes.UseVisualStyleBackColor = true;
            this.Classes.Click += new System.EventHandler(this.Classes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project.Properties.Resources.gym_logo_template_design_04d583c8ca3558ea0ea21763a57e7ba6_screen;
            this.pictureBox1.Location = new System.Drawing.Point(51, 114);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(591, 395);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Close
            // 
            this.Close.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(847, 513);
            this.Close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(212, 64);
            this.Close.TabIndex = 5;
            this.Close.Text = "Exit";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // FitnessCentre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 592);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Classes);
            this.Controls.Add(this.Clients);
            this.Controls.Add(this.Trainers);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FitnessCentre";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FitnessCentre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Trainers;
        private System.Windows.Forms.Button Clients;
        private System.Windows.Forms.Button Classes;
        private System.Windows.Forms.Button Close;
    }
}

