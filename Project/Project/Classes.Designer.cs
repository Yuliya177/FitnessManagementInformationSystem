namespace Project
{
    partial class Classes
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
            this.EditClass = new System.Windows.Forms.Button();
            this.DeleteClass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Classes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(405, 252);
            this.dataGridView1.TabIndex = 1;
            // 
            // ShowData
            // 
            this.ShowData.Location = new System.Drawing.Point(480, 118);
            this.ShowData.Name = "ShowData";
            this.ShowData.Size = new System.Drawing.Size(91, 59);
            this.ShowData.TabIndex = 2;
            this.ShowData.Text = "Изведи данни";
            this.ShowData.UseVisualStyleBackColor = true;
            this.ShowData.Click += new System.EventHandler(this.ShowData_Click);
            // 
            // EditClass
            // 
            this.EditClass.Location = new System.Drawing.Point(480, 217);
            this.EditClass.Name = "EditClass";
            this.EditClass.Size = new System.Drawing.Size(91, 59);
            this.EditClass.TabIndex = 3;
            this.EditClass.Text = "Редактирай клас";
            this.EditClass.UseVisualStyleBackColor = true;
            this.EditClass.Click += new System.EventHandler(this.EditClass_Click);
            // 
            // DeleteClass
            // 
            this.DeleteClass.Location = new System.Drawing.Point(480, 311);
            this.DeleteClass.Name = "DeleteClass";
            this.DeleteClass.Size = new System.Drawing.Size(91, 59);
            this.DeleteClass.TabIndex = 4;
            this.DeleteClass.Text = "Премахни клас";
            this.DeleteClass.UseVisualStyleBackColor = true;
            this.DeleteClass.Click += new System.EventHandler(this.DeleteClass_Click);
            // 
            // Classes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 439);
            this.Controls.Add(this.DeleteClass);
            this.Controls.Add(this.EditClass);
            this.Controls.Add(this.ShowData);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Classes";
            this.Text = "Classes";
            this.Load += new System.EventHandler(this.Classes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ShowData;
        private System.Windows.Forms.Button EditClass;
        private System.Windows.Forms.Button DeleteClass;
    }
}