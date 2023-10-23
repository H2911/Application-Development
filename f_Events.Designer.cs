using System;
using System.Collections.Generic;

namespace Assignment2
{
    partial class Events
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
            this.grSearching = new System.Windows.Forms.GroupBox();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_EventName = new System.Windows.Forms.ComboBox();
            this.gbEvents = new System.Windows.Forms.GroupBox();
            this.lv_events = new System.Windows.Forms.ListView();
            this.colEventName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCapacity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bnt_Back = new System.Windows.Forms.Button();
            this.grSearching.SuspendLayout();
            this.gbEvents.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Events";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grSearching
            // 
            this.grSearching.Controls.Add(this.timePicker);
            this.grSearching.Controls.Add(this.label4);
            this.grSearching.Controls.Add(this.datePicker);
            this.grSearching.Controls.Add(this.label3);
            this.grSearching.Controls.Add(this.label2);
            this.grSearching.Controls.Add(this.cbb_EventName);
            this.grSearching.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grSearching.Location = new System.Drawing.Point(60, 58);
            this.grSearching.Name = "grSearching";
            this.grSearching.Size = new System.Drawing.Size(663, 126);
            this.grSearching.TabIndex = 5;
            this.grSearching.TabStop = false;
            this.grSearching.Text = "Searching";
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "hh:mm";
            this.timePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(412, 79);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(121, 24);
            this.timePicker.TabIndex = 10;
            this.timePicker.Value = new System.DateTime(2023, 10, 23, 0, 0, 0, 0);
            this.timePicker.ValueChanged += new System.EventHandler(this.timePicker_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(352, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Time:";
            // 
            // datePicker
            // 
            this.datePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(191, 79);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(137, 24);
            this.datePicker.TabIndex = 8;
            this.datePicker.Value = new System.DateTime(2023, 10, 23, 17, 22, 31, 177);
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Event Name: ";
            // 
            // cbb_EventName
            // 
            this.cbb_EventName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbb_EventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_EventName.FormattingEnabled = true;
            this.cbb_EventName.Location = new System.Drawing.Point(191, 39);
            this.cbb_EventName.Name = "cbb_EventName";
            this.cbb_EventName.Size = new System.Drawing.Size(342, 26);
            this.cbb_EventName.TabIndex = 5;
            this.cbb_EventName.SelectedValueChanged += new System.EventHandler(this.cbb_EventName_SelectedValueChanged);
            // 
            // gbEvents
            // 
            this.gbEvents.Controls.Add(this.lv_events);
            this.gbEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEvents.Location = new System.Drawing.Point(60, 190);
            this.gbEvents.Name = "gbEvents";
            this.gbEvents.Size = new System.Drawing.Size(663, 191);
            this.gbEvents.TabIndex = 6;
            this.gbEvents.TabStop = false;
            this.gbEvents.Text = "Events";
            // 
            // lv_events
            // 
            this.lv_events.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colEventName,
            this.colPrice,
            this.colCapacity,
            this.colDate,
            this.colTime});
            this.lv_events.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_events.HideSelection = false;
            this.lv_events.Location = new System.Drawing.Point(18, 29);
            this.lv_events.Name = "lv_events";
            this.lv_events.Size = new System.Drawing.Size(629, 150);
            this.lv_events.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lv_events.TabIndex = 0;
            this.lv_events.UseCompatibleStateImageBehavior = false;
            this.lv_events.View = System.Windows.Forms.View.Details;
            // 
            // colEventName
            // 
            this.colEventName.Text = "Event Name";
            this.colEventName.Width = 200;
            // 
            // colPrice
            // 
            this.colPrice.Text = "Price ($AUD)";
            this.colPrice.Width = 120;
            // 
            // colCapacity
            // 
            this.colCapacity.Text = "Capacity";
            this.colCapacity.Width = 101;
            // 
            // colDate
            // 
            this.colDate.Text = "Date";
            this.colDate.Width = 128;
            // 
            // colTime
            // 
            this.colTime.Text = "Time";
            this.colTime.Width = 112;
            // 
            // bnt_Back
            // 
            this.bnt_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_Back.Location = new System.Drawing.Point(678, 398);
            this.bnt_Back.Name = "bnt_Back";
            this.bnt_Back.Size = new System.Drawing.Size(97, 40);
            this.bnt_Back.TabIndex = 7;
            this.bnt_Back.Text = "Back";
            this.bnt_Back.UseVisualStyleBackColor = true;
            this.bnt_Back.Click += new System.EventHandler(this.button1_Click);
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bnt_Back);
            this.Controls.Add(this.gbEvents);
            this.Controls.Add(this.grSearching);
            this.Controls.Add(this.label1);
            this.Name = "Events";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Events";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Events_FormClosed);
            this.Load += new System.EventHandler(this.Events_Load);
            this.grSearching.ResumeLayout(false);
            this.grSearching.PerformLayout();
            this.gbEvents.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grSearching;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbEvents;
        private System.Windows.Forms.Button bnt_Back;
        private System.Windows.Forms.ComboBox cbb_EventName;
        private System.Windows.Forms.ListView lv_events;
        private System.Windows.Forms.ColumnHeader colEventName;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.ColumnHeader colCapacity;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.ColumnHeader colTime;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Label label4;
    }
}