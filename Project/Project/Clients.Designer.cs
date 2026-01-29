namespace Project
{
    partial class Clients
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowData = new System.Windows.Forms.Button();
            this.ShowClient = new System.Windows.Forms.Button();
            this.DeleteClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(108, 87);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(572, 279);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clients";
            // 
            // ShowData
            // 
            this.ShowData.Location = new System.Drawing.Point(51, 400);
            this.ShowData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShowData.Name = "ShowData";
            this.ShowData.Size = new System.Drawing.Size(187, 49);
            this.ShowData.TabIndex = 2;
            this.ShowData.Text = "Изведи данни";
            this.ShowData.UseVisualStyleBackColor = true;
            this.ShowData.Click += new System.EventHandler(this.ShowData_Click);
            // 
            // ShowClient
            // 
            this.ShowClient.Location = new System.Drawing.Point(324, 400);
            this.ShowClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShowClient.Name = "ShowClient";
            this.ShowClient.Size = new System.Drawing.Size(187, 49);
            this.ShowClient.TabIndex = 3;
            this.ShowClient.Text = "Добави клиент";
            this.ShowClient.UseVisualStyleBackColor = true;
            this.ShowClient.Click += new System.EventHandler(this.ShowClient_Click);
            // 
            // DeleteClient
            // 
            this.DeleteClient.Location = new System.Drawing.Point(595, 400);
            this.DeleteClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteClient.Name = "DeleteClient";
            this.DeleteClient.Size = new System.Drawing.Size(187, 49);
            this.DeleteClient.TabIndex = 4;
            this.DeleteClient.Text = "Премахни клиент";
            this.DeleteClient.UseVisualStyleBackColor = true;
            this.DeleteClient.Click += new System.EventHandler(this.DeleteClient_Click);
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 494);
            this.Controls.Add(this.DeleteClient);
            this.Controls.Add(this.ShowClient);
            this.Controls.Add(this.ShowData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Clients";
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.Clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ShowData;
        private System.Windows.Forms.Button ShowClient;
        private System.Windows.Forms.Button DeleteClient;
    }
}