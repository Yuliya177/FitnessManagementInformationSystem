namespace Project
{
    partial class DeleteTrainer1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.DeleteTrainer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Избери треньор, който ще премахнеш";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(139, 99);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // DeleteTrainer
            // 
            this.DeleteTrainer.Location = new System.Drawing.Point(156, 180);
            this.DeleteTrainer.Name = "DeleteTrainer";
            this.DeleteTrainer.Size = new System.Drawing.Size(172, 46);
            this.DeleteTrainer.TabIndex = 3;
            this.DeleteTrainer.Text = "Премахни";
            this.DeleteTrainer.UseVisualStyleBackColor = true;
            this.DeleteTrainer.Click += new System.EventHandler(this.DeleteTrainer_Click);
            // 
            // DeleteTrainer1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 264);
            this.Controls.Add(this.DeleteTrainer);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "DeleteTrainer1";
            this.Text = "DeleteTrainer1";
            this.Load += new System.EventHandler(this.DeleteTrainer1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button DeleteTrainer;
    }
}