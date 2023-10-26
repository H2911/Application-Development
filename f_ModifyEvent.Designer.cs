namespace Assignment2
{
    partial class f_ModifyEvent
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
            this.bnt_Discard = new System.Windows.Forms.Button();
            this.bnt_ConfirmChange = new System.Windows.Forms.Button();
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
            this.label2 = new System.Windows.Forms.Label();
            this.bnt_CancelEvent = new System.Windows.Forms.Button();
            this.lbID = new System.Windows.Forms.Label();
            this.lb_participants = new System.Windows.Forms.Label();
            this.newEventGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modify Event";
            // 
            // bnt_Discard
            // 
            this.bnt_Discard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_Discard.Location = new System.Drawing.Point(526, 372);
            this.bnt_Discard.Name = "bnt_Discard";
            this.bnt_Discard.Size = new System.Drawing.Size(140, 44);
            this.bnt_Discard.TabIndex = 9;
            this.bnt_Discard.Text = "Discard";
            this.bnt_Discard.UseVisualStyleBackColor = true;
            this.bnt_Discard.Click += new System.EventHandler(this.bnt_Discard_Click);
            // 
            // bnt_ConfirmChange
            // 
            this.bnt_ConfirmChange.AutoSize = true;
            this.bnt_ConfirmChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_ConfirmChange.Location = new System.Drawing.Point(165, 372);
            this.bnt_ConfirmChange.Name = "bnt_ConfirmChange";
            this.bnt_ConfirmChange.Size = new System.Drawing.Size(140, 44);
            this.bnt_ConfirmChange.TabIndex = 8;
            this.bnt_ConfirmChange.Text = "Confirm Change";
            this.bnt_ConfirmChange.UseVisualStyleBackColor = true;
            this.bnt_ConfirmChange.Click += new System.EventHandler(this.bnt_ConfirmChange_Click);
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
            this.newEventGB.Controls.Add(this.label2);
            this.newEventGB.Location = new System.Drawing.Point(134, 92);
            this.newEventGB.Name = "newEventGB";
            this.newEventGB.Size = new System.Drawing.Size(532, 257);
            this.newEventGB.TabIndex = 7;
            this.newEventGB.TabStop = false;
            this.newEventGB.Text = "Event";
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
            this.timePicker.Value = new System.DateTime(2023, 10, 25, 0, 0, 0, 0);
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
            this.datePicker.Value = new System.DateTime(2023, 10, 25, 6, 41, 54, 916);
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
            // 
            // tb_Capacity
            // 
            this.tb_Capacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Capacity.Location = new System.Drawing.Point(406, 93);
            this.tb_Capacity.Name = "tb_Capacity";
            this.tb_Capacity.Size = new System.Drawing.Size(80, 27);
            this.tb_Capacity.TabIndex = 3;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Event Name:";
            // 
            // bnt_CancelEvent
            // 
            this.bnt_CancelEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_CancelEvent.Location = new System.Drawing.Point(350, 372);
            this.bnt_CancelEvent.Name = "bnt_CancelEvent";
            this.bnt_CancelEvent.Size = new System.Drawing.Size(140, 44);
            this.bnt_CancelEvent.TabIndex = 10;
            this.bnt_CancelEvent.Text = "Cancel Event";
            this.bnt_CancelEvent.UseVisualStyleBackColor = true;
            this.bnt_CancelEvent.Click += new System.EventHandler(this.bnt_CancelEvent_Click);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(681, 36);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(20, 16);
            this.lbID.TabIndex = 11;
            this.lbID.Text = "ID";
            // 
            // lb_participants
            // 
            this.lb_participants.AutoSize = true;
            this.lb_participants.Location = new System.Drawing.Point(681, 61);
            this.lb_participants.Name = "lb_participants";
            this.lb_participants.Size = new System.Drawing.Size(79, 16);
            this.lb_participants.TabIndex = 12;
            this.lb_participants.Text = "participants:";
            // 
            // ModifyEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_participants);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.bnt_CancelEvent);
            this.Controls.Add(this.bnt_Discard);
            this.Controls.Add(this.bnt_ConfirmChange);
            this.Controls.Add(this.newEventGB);
            this.Controls.Add(this.label1);
            this.Name = "ModifyEvents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifyEvents";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ModifyEvents_FormClosed);
            this.newEventGB.ResumeLayout(false);
            this.newEventGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bnt_Discard;
        private System.Windows.Forms.Button bnt_ConfirmChange;
        private System.Windows.Forms.GroupBox newEventGB;
        public System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tb_EventPrice;
        public System.Windows.Forms.TextBox tb_Capacity;
        public System.Windows.Forms.TextBox tb_EventName;
        private System.Windows.Forms.Button bnt_CancelEvent;
        public System.Windows.Forms.Label lbID;
        public System.Windows.Forms.Label lb_participants;
    }
}