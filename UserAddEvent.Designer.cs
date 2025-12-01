namespace groupProject
{
    partial class UserAddEvent
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.eventDescBox = new System.Windows.Forms.TextBox();
            this.eventDateBox = new System.Windows.Forms.TextBox();
            this.eventTitleBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.eventLocationBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(24, 386);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 23);
            this.button4.TabIndex = 32;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(24, 340);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 23);
            this.button3.TabIndex = 31;
            this.button3.Text = "Save event";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Description: ";
            // 
            // eventDescBox
            // 
            this.eventDescBox.Location = new System.Drawing.Point(183, 138);
            this.eventDescBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eventDescBox.Multiline = true;
            this.eventDescBox.Name = "eventDescBox";
            this.eventDescBox.Size = new System.Drawing.Size(193, 296);
            this.eventDescBox.TabIndex = 29;
            // 
            // eventDateBox
            // 
            this.eventDateBox.Location = new System.Drawing.Point(131, 39);
            this.eventDateBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eventDateBox.Name = "eventDateBox";
            this.eventDateBox.Size = new System.Drawing.Size(245, 22);
            this.eventDateBox.TabIndex = 37;
            this.eventDateBox.TextChanged += new System.EventHandler(this.dateBox_TextChanged);
            // 
            // eventTitleBox
            // 
            this.eventTitleBox.Location = new System.Drawing.Point(131, 11);
            this.eventTitleBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eventTitleBox.Name = "eventTitleBox";
            this.eventTitleBox.Size = new System.Drawing.Size(245, 22);
            this.eventTitleBox.TabIndex = 36;
            this.eventTitleBox.TextChanged += new System.EventHandler(this.eventTitleBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Time: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Date: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Event Title: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(131, 94);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(245, 22);
            this.dateTimePicker1.TabIndex = 39;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Location:";
            // 
            // eventLocationBox
            // 
            this.eventLocationBox.Location = new System.Drawing.Point(131, 66);
            this.eventLocationBox.Name = "eventLocationBox";
            this.eventLocationBox.Size = new System.Drawing.Size(245, 22);
            this.eventLocationBox.TabIndex = 40;
            // 
            // UserAddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eventLocationBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.eventDateBox);
            this.Controls.Add(this.eventTitleBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.eventDescBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserAddEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserAddEvent";
            this.Load += new System.EventHandler(this.UserAddEvent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox eventDescBox;
        private System.Windows.Forms.TextBox eventDateBox;
        private System.Windows.Forms.TextBox eventTitleBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox eventLocationBox;
    }
}