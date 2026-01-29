namespace Project
{
    partial class AddTrainer
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
            this.label3 = new System.Windows.Forms.Label();
            this.TrainerName = new System.Windows.Forms.TextBox();
            this.TrainerSurname = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добави треньор";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Въведи име на треньора";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Въведи фамилия на треньора";
            // 
            // TrainerName
            // 
            this.TrainerName.Location = new System.Drawing.Point(376, 122);
            this.TrainerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TrainerName.Name = "TrainerName";
            this.TrainerName.Size = new System.Drawing.Size(179, 22);
            this.TrainerName.TabIndex = 4;
            // 
            // TrainerSurname
            // 
            this.TrainerSurname.Location = new System.Drawing.Point(376, 218);
            this.TrainerSurname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TrainerSurname.Name = "TrainerSurname";
            this.TrainerSurname.Size = new System.Drawing.Size(179, 22);
            this.TrainerSurname.TabIndex = 5;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(191, 286);
            this.Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(229, 47);
            this.Add.TabIndex = 6;
            this.Add.Text = "Добави";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // AddTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 347);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.TrainerSurname);
            this.Controls.Add(this.TrainerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddTrainer";
            this.Text = "AddTrainer";
            this.Load += new System.EventHandler(this.AddTrainer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TrainerName;
        private System.Windows.Forms.TextBox TrainerSurname;
        private System.Windows.Forms.Button Add;
    }
}