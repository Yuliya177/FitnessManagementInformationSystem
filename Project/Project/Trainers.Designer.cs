namespace Project
{
    partial class Trainers
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ShowData = new System.Windows.Forms.Button();
            this.AddTrainer = new System.Windows.Forms.Button();
            this.EditData = new System.Windows.Forms.Button();
            this.DeleteTrainer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trainers";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 134);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(536, 353);
            this.dataGridView1.TabIndex = 1;
            // 
            // ShowData
            // 
            this.ShowData.Location = new System.Drawing.Point(669, 134);
            this.ShowData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShowData.Name = "ShowData";
            this.ShowData.Size = new System.Drawing.Size(183, 53);
            this.ShowData.TabIndex = 2;
            this.ShowData.Text = "Изведи данни";
            this.ShowData.UseVisualStyleBackColor = true;
            this.ShowData.Click += new System.EventHandler(this.ShowData_Click);
            // 
            // AddTrainer
            // 
            this.AddTrainer.Location = new System.Drawing.Point(669, 230);
            this.AddTrainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddTrainer.Name = "AddTrainer";
            this.AddTrainer.Size = new System.Drawing.Size(183, 53);
            this.AddTrainer.TabIndex = 3;
            this.AddTrainer.Text = "Добави треньор";
            this.AddTrainer.UseVisualStyleBackColor = true;
            this.AddTrainer.Click += new System.EventHandler(this.AddTrainer_Click);
            // 
            // EditData
            // 
            this.EditData.Location = new System.Drawing.Point(669, 331);
            this.EditData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditData.Name = "EditData";
            this.EditData.Size = new System.Drawing.Size(183, 53);
            this.EditData.TabIndex = 4;
            this.EditData.Text = "Редактирай треньор";
            this.EditData.UseVisualStyleBackColor = true;
            this.EditData.Click += new System.EventHandler(this.EditData_Click);
            // 
            // DeleteTrainer
            // 
            this.DeleteTrainer.Location = new System.Drawing.Point(669, 434);
            this.DeleteTrainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteTrainer.Name = "DeleteTrainer";
            this.DeleteTrainer.Size = new System.Drawing.Size(183, 53);
            this.DeleteTrainer.TabIndex = 5;
            this.DeleteTrainer.Text = "Премахни треньор";
            this.DeleteTrainer.UseVisualStyleBackColor = true;
            this.DeleteTrainer.Click += new System.EventHandler(this.DeleteTrainer_Click);
            // 
            // Trainers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 554);
            this.Controls.Add(this.DeleteTrainer);
            this.Controls.Add(this.EditData);
            this.Controls.Add(this.AddTrainer);
            this.Controls.Add(this.ShowData);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Trainers";
            this.Text = "Trainers";
            this.Load += new System.EventHandler(this.Trainers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ShowData;
        private System.Windows.Forms.Button AddTrainer;
        private System.Windows.Forms.Button EditData;
        private System.Windows.Forms.Button DeleteTrainer;
    }
}