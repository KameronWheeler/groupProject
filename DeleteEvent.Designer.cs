namespace groupProject
{
    partial class DeleteEvent
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
            this.titleBox = new System.Windows.Forms.TextBox();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.locationBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // timeBox
            // 
            this.timeBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.timeBox.Location = new System.Drawing.Point(123, 89);
            this.timeBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timeBox.Name = "timeBox";
            this.timeBox.ReadOnly = true;
            this.timeBox.Size = new System.Drawing.Size(220, 22);
            this.timeBox.TabIndex = 30;
            // 
            // titleBox
            // 
            this.titleBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.titleBox.Location = new System.Drawing.Point(123, 33);
            this.titleBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.titleBox.Name = "titleBox";
            this.titleBox.ReadOnly = true;
            this.titleBox.Size = new System.Drawing.Size(220, 22);
            this.titleBox.TabIndex = 29;
            // 
            // dateBox
            // 
            this.dateBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.dateBox.Location = new System.Drawing.Point(123, 62);
            this.dateBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateBox.Name = "dateBox";
            this.dateBox.ReadOnly = true;
            this.dateBox.Size = new System.Drawing.Size(220, 22);
            this.dateBox.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Time: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Date: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Event Title:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "Confirm event deletion?";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 193);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 38);
            this.button1.TabIndex = 32;
            this.button1.Text = "Yes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 193);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 38);
            this.button2.TabIndex = 33;
            this.button2.Text = "No";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // descriptionBox
            // 
            this.descriptionBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.descriptionBox.Location = new System.Drawing.Point(516, 14);
            this.descriptionBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.ReadOnly = true;
            this.descriptionBox.Size = new System.Drawing.Size(253, 221);
            this.descriptionBox.TabIndex = 34;
            this.descriptionBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(395, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Description: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Location:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // locationBox
            // 
            this.locationBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.locationBox.Location = new System.Drawing.Point(123, 119);
            this.locationBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.locationBox.Name = "locationBox";
            this.locationBox.ReadOnly = true;
            this.locationBox.Size = new System.Drawing.Size(220, 22);
            this.locationBox.TabIndex = 37;
            // 
            // DeleteEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 409);
            this.Controls.Add(this.locationBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DeleteEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirm deletion?";
            this.Load += new System.EventHandler(this.DeleteEvent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox dateBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox locationBox;
    }
}