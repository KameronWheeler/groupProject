namespace groupProject
{
    partial class EditEvents
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
            this.timeBox = new System.Windows.Forms.TextBox();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dismissButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.locationBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(125, 87);
            this.timeBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(246, 22);
            this.timeBox.TabIndex = 17;
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(125, 59);
            this.dateBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(246, 22);
            this.dateBox.TabIndex = 16;
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(125, 30);
            this.titleBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(246, 22);
            this.titleBox.TabIndex = 15;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(125, 431);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(123, 38);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save Changes";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click_1);
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(125, 178);
            this.descriptionBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(246, 249);
            this.descriptionBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Time: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Date: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Event Title: ";
            // 
            // dismissButton
            // 
            this.dismissButton.Location = new System.Drawing.Point(248, 431);
            this.dismissButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dismissButton.Name = "dismissButton";
            this.dismissButton.Size = new System.Drawing.Size(123, 38);
            this.dismissButton.TabIndex = 18;
            this.dismissButton.Text = "Dismiss";
            this.dismissButton.UseVisualStyleBackColor = true;
            this.dismissButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Location:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // locationBox
            // 
            this.locationBox.Location = new System.Drawing.Point(125, 115);
            this.locationBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(246, 22);
            this.locationBox.TabIndex = 20;
            // 
            // EditEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 487);
            this.Controls.Add(this.locationBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dismissButton);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EditEvents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditEvents";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.TextBox dateBox;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button dismissButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox locationBox;
    }
}