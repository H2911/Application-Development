namespace Assignment2
{
    partial class AdminManagementForm
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
            this.bnt_Logout = new System.Windows.Forms.Button();
            this.bntModifyEvent = new System.Windows.Forms.Button();
            this.bntCreateNewEvent = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_adminID = new System.Windows.Forms.Label();
            this.Admin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(212, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 46);
            this.label2.TabIndex = 4;
            this.label2.Text = "Admin Management";
            // 
            // bnt_Logout
            // 
            this.bnt_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_Logout.Location = new System.Drawing.Point(606, 362);
            this.bnt_Logout.Name = "bnt_Logout";
            this.bnt_Logout.Size = new System.Drawing.Size(108, 42);
            this.bnt_Logout.TabIndex = 3;
            this.bnt_Logout.Text = "Logout";
            this.bnt_Logout.UseVisualStyleBackColor = true;
            this.bnt_Logout.Click += new System.EventHandler(this.bnt_Logout_Click);
            // 
            // bntModifyEvent
            // 
            this.bntModifyEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntModifyEvent.Location = new System.Drawing.Point(296, 279);
            this.bntModifyEvent.Name = "bntModifyEvent";
            this.bntModifyEvent.Size = new System.Drawing.Size(212, 63);
            this.bntModifyEvent.TabIndex = 2;
            this.bntModifyEvent.Text = "Modify Event";
            this.bntModifyEvent.UseVisualStyleBackColor = true;
            this.bntModifyEvent.Click += new System.EventHandler(this.bntModifyEvent_Click);
            // 
            // bntCreateNewEvent
            // 
            this.bntCreateNewEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCreateNewEvent.Location = new System.Drawing.Point(296, 180);
            this.bntCreateNewEvent.Name = "bntCreateNewEvent";
            this.bntCreateNewEvent.Size = new System.Drawing.Size(212, 63);
            this.bntCreateNewEvent.TabIndex = 1;
            this.bntCreateNewEvent.Text = "Create New Event";
            this.bntCreateNewEvent.UseVisualStyleBackColor = true;
            this.bntCreateNewEvent.Click += new System.EventHandler(this.bntCreateNewEvent_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_adminID);
            this.panel1.Controls.Add(this.Admin);
            this.panel1.Location = new System.Drawing.Point(568, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 43);
            this.panel1.TabIndex = 8;
            // 
            // lb_adminID
            // 
            this.lb_adminID.AutoSize = true;
            this.lb_adminID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_adminID.Location = new System.Drawing.Point(90, 11);
            this.lb_adminID.Name = "lb_adminID";
            this.lb_adminID.Size = new System.Drawing.Size(75, 20);
            this.lb_adminID.TabIndex = 6;
            this.lb_adminID.Text = "admin ID";
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Admin.Location = new System.Drawing.Point(23, 11);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(61, 20);
            this.Admin.TabIndex = 5;
            this.Admin.Text = "Admin:";
            // 
            // AdminManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bntModifyEvent);
            this.Controls.Add(this.bntCreateNewEvent);
            this.Controls.Add(this.bnt_Logout);
            this.Controls.Add(this.label2);
            this.Name = "AdminManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminManagementForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bnt_Logout;
        private System.Windows.Forms.Button bntModifyEvent;
        private System.Windows.Forms.Button bntCreateNewEvent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_adminID;
        private System.Windows.Forms.Label Admin;
    }
}

