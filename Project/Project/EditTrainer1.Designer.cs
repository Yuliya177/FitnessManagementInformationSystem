namespace Project
{
    partial class EditTrainer1
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
            this.EditName = new System.Windows.Forms.TextBox();
            this.EditSurname = new System.Windows.Forms.TextBox();
            this.SaveChanges = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ChooseTrId = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Редактиране на данните на треньор";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Въведи име на треньора";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Въведи фамилия на треньора";
            // 
            // EditName
            // 
            this.EditName.Location = new System.Drawing.Point(331, 138);
            this.EditName.Name = "EditName";
            this.EditName.Size = new System.Drawing.Size(164, 20);
            this.EditName.TabIndex = 4;
            // 
            // EditSurname
            // 
            this.EditSurname.Location = new System.Drawing.Point(331, 198);
            this.EditSurname.Name = "EditSurname";
            this.EditSurname.Size = new System.Drawing.Size(164, 20);
            this.EditSurname.TabIndex = 5;
            // 
            // SaveChanges
            // 
            this.SaveChanges.Location = new System.Drawing.Point(194, 245);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(144, 37);
            this.SaveChanges.TabIndex = 6;
            this.SaveChanges.Text = "Запиши промени";
            this.SaveChanges.UseVisualStyleBackColor = true;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Въведи номер на треньора";
            // 
            // ChooseTrId
            // 
            this.ChooseTrId.FormattingEnabled = true;
            this.ChooseTrId.Location = new System.Drawing.Point(331, 78);
            this.ChooseTrId.Name = "ChooseTrId";
            this.ChooseTrId.Size = new System.Drawing.Size(161, 21);
            this.ChooseTrId.TabIndex = 8;
            this.ChooseTrId.SelectedIndexChanged += new System.EventHandler(this.ChooseTrId_SelectedIndexChanged);
            // 
            // EditTrainer1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 294);
            this.Controls.Add(this.ChooseTrId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SaveChanges);
            this.Controls.Add(this.EditSurname);
            this.Controls.Add(this.EditName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditTrainer1";
            this.Text = "EditTrainer1";
            this.Load += new System.EventHandler(this.EditTrainer1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EditName;
        private System.Windows.Forms.TextBox EditSurname;
        private System.Windows.Forms.Button SaveChanges;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ChooseTrId;
    }
}