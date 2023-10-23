using System;

namespace Assignment2
{
    partial class CreateNewEventForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.newEventGB = new System.Windows.Forms.GroupBox();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_EventPrice = new System.Windows.Forms.TextBox();
            this.tb_Capacity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_EventName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bnt_CreateEvent = new System.Windows.Forms.Button();
            this.bnt_Cancel = new System.Windows.Forms.Button();
            this.newEventGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 46);
            this.label2.TabIndex = 6;
            this.label2.Text = "Create New Event";
            // 
            // newEventGB
            // 
            this.newEventGB.Controls.Add(this.timePicker);
            this.newEventGB.Controls.Add(this.label7);
            this.newEventGB.Controls.Add(this.label6);
            this.newEventGB.Controls.Add(this.datePicker);
            this.newEventGB.Controls.Add(this.label5);
            this.newEventGB.Controls.Add(this.tb_EventPrice);
            this.newEventGB.Controls.Add(this.tb_Capacity);
            this.newEventGB.Controls.Add(this.label4);
            this.newEventGB.Controls.Add(this.label3);
            this.newEventGB.Controls.Add(this.tb_EventName);
            this.newEventGB.Controls.Add(this.label1);
            this.newEventGB.Location = new System.Drawing.Point(125, 93);
            this.newEventGB.Name = "newEventGB";
            this.newEventGB.Size = new System.Drawing.Size(532, 257);
            this.newEventGB.TabIndex = 1;
            this.newEventGB.TabStop = false;
            this.newEventGB.Text = "New Event";
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "HH:mm";
            this.timePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(141, 201);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(173, 27);
            this.timePicker.TabIndex = 19;
            this.timePicker.TabStop = false;
            this.timePicker.Value = DateTime.Now.Date;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(65, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(221, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "AUD$";
            // 
            // datePicker
            // 
            this.datePicker.CustomFormat = "dd-mm-yyyy";
            this.datePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Location = new System.Drawing.Point(141, 147);
            this.datePicker.MinDate = new System.DateTime(2023, 10, 22, 17, 32, 9, 792);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(345, 27);
            this.datePicker.TabIndex = 16;
            this.datePicker.TabStop = false;
            this.datePicker.Value = DateTime.Now;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Date:";
            // 
            // tb_EventPrice
            // 
            this.tb_EventPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_EventPrice.Location = new System.Drawing.Point(140, 93);
            this.tb_EventPrice.Name = "tb_EventPrice";
            this.tb_EventPrice.Size = new System.Drawing.Size(75, 27);
            this.tb_EventPrice.TabIndex = 2;
            this.tb_EventPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lb_Price_KeyPress);
            // 
            // tb_Capacity
            // 
            this.tb_Capacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Capacity.Location = new System.Drawing.Point(406, 93);
            this.tb_Capacity.Name = "tb_Capacity";
            this.tb_Capacity.Size = new System.Drawing.Size(80, 27);
            this.tb_Capacity.TabIndex = 3;
            this.tb_Capacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(308, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Capacity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Price:";
            // 
            // tb_EventName
            // 
            this.tb_EventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_EventName.Location = new System.Drawing.Point(141, 49);
            this.tb_EventName.Name = "tb_EventName";
            this.tb_EventName.Size = new System.Drawing.Size(345, 27);
            this.tb_EventName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Event Name:";
            // 
            // bnt_CreateEvent
            // 
            this.bnt_CreateEvent.AutoSize = true;
            this.bnt_CreateEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_CreateEvent.Location = new System.Drawing.Point(228, 373);
            this.bnt_CreateEvent.Name = "bnt_CreateEvent";
            this.bnt_CreateEvent.Size = new System.Drawing.Size(140, 44);
            this.bnt_CreateEvent.TabIndex = 4;
            this.bnt_CreateEvent.Text = "Create Event";
            this.bnt_CreateEvent.UseVisualStyleBackColor = true;
            this.bnt_CreateEvent.Click += new System.EventHandler(this.bnt_CreateEvent_Click);
            // 
            // bnt_Cancel
            // 
            this.bnt_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_Cancel.Location = new System.Drawing.Point(428, 373);
            this.bnt_Cancel.Name = "bnt_Cancel";
            this.bnt_Cancel.Size = new System.Drawing.Size(140, 44);
            this.bnt_Cancel.TabIndex = 5;
            this.bnt_Cancel.Text = "Cancel";
            this.bnt_Cancel.UseVisualStyleBackColor = true;
            this.bnt_Cancel.Click += new System.EventHandler(this.bnt_Cancel_Click);
            // 
            // CreateNewEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bnt_Cancel);
            this.Controls.Add(this.bnt_CreateEvent);
            this.Controls.Add(this.newEventGB);
            this.Controls.Add(this.label2);
            this.Name = "CreateNewEventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Event";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateNewEventForm_FormClosed);
            this.newEventGB.ResumeLayout(false);
            this.newEventGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox newEventGB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_EventPrice;
        private System.Windows.Forms.TextBox tb_Capacity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_EventName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bnt_CreateEvent;
        private System.Windows.Forms.Button bnt_Cancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DateTimePicker datePicker;
        public System.Windows.Forms.DateTimePicker timePicker;
    }
}