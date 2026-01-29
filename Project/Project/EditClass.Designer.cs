namespace Project
{
    partial class EditClass
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ClassType = new System.Windows.Forms.TextBox();
            this.ClassPrice = new System.Windows.Forms.TextBox();
            this.ClassDate = new System.Windows.Forms.TextBox();
            this.TrainerId = new System.Windows.Forms.TextBox();
            this.SaveChanges = new System.Windows.Forms.Button();
            this.ClassesId = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Редактиране на класовете с тренировки ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Въведи номер на тренировката";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Въведи типа на тренировката";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Въведи цена";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Въведи дата";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Въведи номер на треньор";
            // 
            // ClassType
            // 
            this.ClassType.Location = new System.Drawing.Point(366, 145);
            this.ClassType.Name = "ClassType";
            this.ClassType.Size = new System.Drawing.Size(168, 20);
            this.ClassType.TabIndex = 14;
            // 
            // ClassPrice
            // 
            this.ClassPrice.Location = new System.Drawing.Point(366, 189);
            this.ClassPrice.Name = "ClassPrice";
            this.ClassPrice.Size = new System.Drawing.Size(168, 20);
            this.ClassPrice.TabIndex = 15;
            // 
            // ClassDate
            // 
            this.ClassDate.Location = new System.Drawing.Point(366, 232);
            this.ClassDate.Name = "ClassDate";
            this.ClassDate.Size = new System.Drawing.Size(168, 20);
            this.ClassDate.TabIndex = 16;
            // 
            // TrainerId
            // 
            this.TrainerId.Location = new System.Drawing.Point(366, 276);
            this.TrainerId.Name = "TrainerId";
            this.TrainerId.Size = new System.Drawing.Size(168, 20);
            this.TrainerId.TabIndex = 17;
            // 
            // SaveChanges
            // 
            this.SaveChanges.Location = new System.Drawing.Point(215, 322);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(176, 40);
            this.SaveChanges.TabIndex = 18;
            this.SaveChanges.Text = "Запиши Промеи";
            this.SaveChanges.UseVisualStyleBackColor = true;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // ClassesId
            // 
            this.ClassesId.FormattingEnabled = true;
            this.ClassesId.Location = new System.Drawing.Point(351, 97);
            this.ClassesId.Name = "ClassesId";
            this.ClassesId.Size = new System.Drawing.Size(183, 21);
            this.ClassesId.TabIndex = 19;
            // 
            // EditClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 374);
            this.Controls.Add(this.ClassesId);
            this.Controls.Add(this.SaveChanges);
            this.Controls.Add(this.TrainerId);
            this.Controls.Add(this.ClassDate);
            this.Controls.Add(this.ClassPrice);
            this.Controls.Add(this.ClassType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "EditClass";
            this.Text = "EditClass";
            this.Load += new System.EventHandler(this.EditClass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ClassType;
        private System.Windows.Forms.TextBox ClassPrice;
        private System.Windows.Forms.TextBox ClassDate;
        private System.Windows.Forms.TextBox TrainerId;
        private System.Windows.Forms.Button SaveChanges;
        private System.Windows.Forms.ComboBox ClassesId;
    }
}