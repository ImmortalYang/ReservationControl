namespace ReservationSystemControl
{
    partial class ReservationView
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.calendarPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSingleReserv = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.lblResource = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrevDay = new System.Windows.Forms.Button();
            this.btnNextDay = new System.Windows.Forms.Button();
            this.btnPrevWeek = new System.Windows.Forms.Button();
            this.btnNextWeek = new System.Windows.Forms.Button();
            this.dateTimeLabel1 = new ReservationSystemControl.DateTimeLabel();
            this.dateTimeLabel2 = new ReservationSystemControl.DateTimeLabel();
            this.dateTimeLabel3 = new ReservationSystemControl.DateTimeLabel();
            this.dateTimeLabel4 = new ReservationSystemControl.DateTimeLabel();
            this.dateTimeLabel5 = new ReservationSystemControl.DateTimeLabel();
            this.dateTimeLabel6 = new ReservationSystemControl.DateTimeLabel();
            this.dateTimeLabel7 = new ReservationSystemControl.DateTimeLabel();
            this.resourceLabel1 = new ReservationSystemControl.ResourceLabel();
            this.resourceLabel2 = new ReservationSystemControl.ResourceLabel();
            this.resourceLabel3 = new ReservationSystemControl.ResourceLabel();
            this.calendarPanel.SuspendLayout();
            this.pnlSingleReserv.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // calendarPanel
            // 
            this.calendarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calendarPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.calendarPanel.ColumnCount = 8;
            this.calendarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.calendarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.calendarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.calendarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.calendarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.calendarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.calendarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.calendarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.calendarPanel.Controls.Add(this.dateTimeLabel1, 7, 0);
            this.calendarPanel.Controls.Add(this.dateTimeLabel2, 6, 0);
            this.calendarPanel.Controls.Add(this.dateTimeLabel3, 5, 0);
            this.calendarPanel.Controls.Add(this.dateTimeLabel4, 4, 0);
            this.calendarPanel.Controls.Add(this.dateTimeLabel5, 3, 0);
            this.calendarPanel.Controls.Add(this.dateTimeLabel6, 2, 0);
            this.calendarPanel.Controls.Add(this.dateTimeLabel7, 1, 0);
            this.calendarPanel.Controls.Add(this.resourceLabel1, 0, 1);
            this.calendarPanel.Controls.Add(this.resourceLabel2, 0, 2);
            this.calendarPanel.Controls.Add(this.resourceLabel3, 0, 3);
            this.calendarPanel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarPanel.Location = new System.Drawing.Point(32, 33);
            this.calendarPanel.Name = "calendarPanel";
            this.calendarPanel.RowCount = 4;
            this.calendarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.calendarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.calendarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.calendarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.calendarPanel.Size = new System.Drawing.Size(2387, 369);
            this.calendarPanel.TabIndex = 0;
            this.calendarPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.calendarPanel_MouseClick);
            // 
            // pnlSingleReserv
            // 
            this.pnlSingleReserv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSingleReserv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSingleReserv.Controls.Add(this.btnDelete);
            this.pnlSingleReserv.Controls.Add(this.dateEnd);
            this.pnlSingleReserv.Controls.Add(this.dateStart);
            this.pnlSingleReserv.Controls.Add(this.txtCustomer);
            this.pnlSingleReserv.Controls.Add(this.lblResource);
            this.pnlSingleReserv.Controls.Add(this.btnSave);
            this.pnlSingleReserv.Controls.Add(this.label4);
            this.pnlSingleReserv.Controls.Add(this.label3);
            this.pnlSingleReserv.Controls.Add(this.label2);
            this.pnlSingleReserv.Controls.Add(this.label1);
            this.pnlSingleReserv.Location = new System.Drawing.Point(2436, 124);
            this.pnlSingleReserv.Name = "pnlSingleReserv";
            this.pnlSingleReserv.Size = new System.Drawing.Size(236, 278);
            this.pnlSingleReserv.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(135, 231);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dateEnd
            // 
            this.dateEnd.Enabled = false;
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEnd.Location = new System.Drawing.Point(100, 160);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(110, 20);
            this.dateEnd.TabIndex = 8;
            // 
            // dateStart
            // 
            this.dateStart.Enabled = false;
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStart.Location = new System.Drawing.Point(100, 120);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(110, 20);
            this.dateStart.TabIndex = 7;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Enabled = false;
            this.txtCustomer.Location = new System.Drawing.Point(100, 73);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(110, 20);
            this.txtCustomer.TabIndex = 6;
            // 
            // lblResource
            // 
            this.lblResource.Location = new System.Drawing.Point(97, 27);
            this.lblResource.Name = "lblResource";
            this.lblResource.Size = new System.Drawing.Size(113, 23);
            this.lblResource.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(22, 231);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "End Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resource";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(122, 15);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(114, 56);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnNextWeek);
            this.panel1.Controls.Add(this.btnPrevWeek);
            this.panel1.Controls.Add(this.btnNextDay);
            this.panel1.Controls.Add(this.btnPrevDay);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Location = new System.Drawing.Point(2436, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 85);
            this.panel1.TabIndex = 3;
            // 
            // btnPrevDay
            // 
            this.btnPrevDay.Location = new System.Drawing.Point(35, 15);
            this.btnPrevDay.Name = "btnPrevDay";
            this.btnPrevDay.Size = new System.Drawing.Size(21, 56);
            this.btnPrevDay.TabIndex = 3;
            this.btnPrevDay.Text = "<";
            this.btnPrevDay.UseVisualStyleBackColor = true;
            this.btnPrevDay.Click += new System.EventHandler(this.btnPrevDay_Click);
            // 
            // btnNextDay
            // 
            this.btnNextDay.Location = new System.Drawing.Point(54, 15);
            this.btnNextDay.Name = "btnNextDay";
            this.btnNextDay.Size = new System.Drawing.Size(22, 56);
            this.btnNextDay.TabIndex = 4;
            this.btnNextDay.Text = ">";
            this.btnNextDay.UseVisualStyleBackColor = true;
            this.btnNextDay.Click += new System.EventHandler(this.btnNextDay_Click);
            // 
            // btnPrevWeek
            // 
            this.btnPrevWeek.Location = new System.Drawing.Point(0, 15);
            this.btnPrevWeek.Name = "btnPrevWeek";
            this.btnPrevWeek.Size = new System.Drawing.Size(40, 56);
            this.btnPrevWeek.TabIndex = 5;
            this.btnPrevWeek.Text = "<<";
            this.btnPrevWeek.UseVisualStyleBackColor = true;
            this.btnPrevWeek.Click += new System.EventHandler(this.btnPrevWeek_Click);
            // 
            // btnNextWeek
            // 
            this.btnNextWeek.Location = new System.Drawing.Point(76, 15);
            this.btnNextWeek.Name = "btnNextWeek";
            this.btnNextWeek.Size = new System.Drawing.Size(40, 56);
            this.btnNextWeek.TabIndex = 6;
            this.btnNextWeek.Text = ">>";
            this.btnNextWeek.UseVisualStyleBackColor = true;
            this.btnNextWeek.Click += new System.EventHandler(this.btnNextWeek_Click);
            // 
            // dateTimeLabel1
            // 
            this.dateTimeLabel1.AutoSize = true;
            this.dateTimeLabel1.BackColor = System.Drawing.Color.Azure;
            this.dateTimeLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimeLabel1.Location = new System.Drawing.Point(2091, 2);
            this.dateTimeLabel1.Name = "dateTimeLabel1";
            this.dateTimeLabel1.Size = new System.Drawing.Size(291, 89);
            this.dateTimeLabel1.TabIndex = 0;
            this.dateTimeLabel1.Text = "dateTimeLabel1";
            this.dateTimeLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimeLabel2
            // 
            this.dateTimeLabel2.AutoSize = true;
            this.dateTimeLabel2.BackColor = System.Drawing.Color.Azure;
            this.dateTimeLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimeLabel2.Location = new System.Drawing.Point(1793, 2);
            this.dateTimeLabel2.Name = "dateTimeLabel2";
            this.dateTimeLabel2.Size = new System.Drawing.Size(290, 89);
            this.dateTimeLabel2.TabIndex = 1;
            this.dateTimeLabel2.Text = "dateTimeLabel2";
            this.dateTimeLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimeLabel3
            // 
            this.dateTimeLabel3.AutoSize = true;
            this.dateTimeLabel3.BackColor = System.Drawing.Color.Azure;
            this.dateTimeLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimeLabel3.Location = new System.Drawing.Point(1495, 2);
            this.dateTimeLabel3.Name = "dateTimeLabel3";
            this.dateTimeLabel3.Size = new System.Drawing.Size(290, 89);
            this.dateTimeLabel3.TabIndex = 2;
            this.dateTimeLabel3.Text = "dateTimeLabel3";
            this.dateTimeLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimeLabel4
            // 
            this.dateTimeLabel4.AutoSize = true;
            this.dateTimeLabel4.BackColor = System.Drawing.Color.Azure;
            this.dateTimeLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimeLabel4.Location = new System.Drawing.Point(1197, 2);
            this.dateTimeLabel4.Name = "dateTimeLabel4";
            this.dateTimeLabel4.Size = new System.Drawing.Size(290, 89);
            this.dateTimeLabel4.TabIndex = 3;
            this.dateTimeLabel4.Text = "dateTimeLabel4";
            this.dateTimeLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimeLabel5
            // 
            this.dateTimeLabel5.AutoSize = true;
            this.dateTimeLabel5.BackColor = System.Drawing.Color.Azure;
            this.dateTimeLabel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimeLabel5.Location = new System.Drawing.Point(899, 2);
            this.dateTimeLabel5.Name = "dateTimeLabel5";
            this.dateTimeLabel5.Size = new System.Drawing.Size(290, 89);
            this.dateTimeLabel5.TabIndex = 4;
            this.dateTimeLabel5.Text = "dateTimeLabel5";
            this.dateTimeLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimeLabel6
            // 
            this.dateTimeLabel6.AutoSize = true;
            this.dateTimeLabel6.BackColor = System.Drawing.Color.Azure;
            this.dateTimeLabel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimeLabel6.Location = new System.Drawing.Point(601, 2);
            this.dateTimeLabel6.Name = "dateTimeLabel6";
            this.dateTimeLabel6.Size = new System.Drawing.Size(290, 89);
            this.dateTimeLabel6.TabIndex = 5;
            this.dateTimeLabel6.Text = "dateTimeLabel6";
            this.dateTimeLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimeLabel7
            // 
            this.dateTimeLabel7.AutoSize = true;
            this.dateTimeLabel7.BackColor = System.Drawing.Color.Azure;
            this.dateTimeLabel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimeLabel7.Location = new System.Drawing.Point(303, 2);
            this.dateTimeLabel7.Name = "dateTimeLabel7";
            this.dateTimeLabel7.Size = new System.Drawing.Size(290, 89);
            this.dateTimeLabel7.TabIndex = 6;
            this.dateTimeLabel7.Text = "dateTimeLabel7";
            this.dateTimeLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resourceLabel1
            // 
            this.resourceLabel1.AutoSize = true;
            this.resourceLabel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.resourceLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resourceLabel1.Location = new System.Drawing.Point(5, 93);
            this.resourceLabel1.Name = "resourceLabel1";
            this.resourceLabel1.Size = new System.Drawing.Size(290, 89);
            this.resourceLabel1.TabIndex = 7;
            this.resourceLabel1.Text = "resourceLabel1";
            this.resourceLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resourceLabel2
            // 
            this.resourceLabel2.AutoSize = true;
            this.resourceLabel2.BackColor = System.Drawing.Color.NavajoWhite;
            this.resourceLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resourceLabel2.Location = new System.Drawing.Point(5, 184);
            this.resourceLabel2.Name = "resourceLabel2";
            this.resourceLabel2.Size = new System.Drawing.Size(290, 89);
            this.resourceLabel2.TabIndex = 8;
            this.resourceLabel2.Text = "resourceLabel2";
            this.resourceLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resourceLabel3
            // 
            this.resourceLabel3.AutoSize = true;
            this.resourceLabel3.BackColor = System.Drawing.Color.NavajoWhite;
            this.resourceLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resourceLabel3.Location = new System.Drawing.Point(5, 275);
            this.resourceLabel3.Name = "resourceLabel3";
            this.resourceLabel3.Size = new System.Drawing.Size(290, 92);
            this.resourceLabel3.TabIndex = 9;
            this.resourceLabel3.Text = "resourceLabel3";
            this.resourceLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReservationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlSingleReserv);
            this.Controls.Add(this.calendarPanel);
            this.Name = "ReservationView";
            this.Size = new System.Drawing.Size(2685, 444);
            this.calendarPanel.ResumeLayout(false);
            this.calendarPanel.PerformLayout();
            this.pnlSingleReserv.ResumeLayout(false);
            this.pnlSingleReserv.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label lblResource;
        private System.Windows.Forms.Panel pnlSingleReserv;
        private System.Windows.Forms.TableLayoutPanel calendarPanel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNextDay;
        private System.Windows.Forms.Button btnPrevDay;
        private DateTimeLabel dateTimeLabel1;
        private DateTimeLabel dateTimeLabel2;
        private DateTimeLabel dateTimeLabel3;
        private DateTimeLabel dateTimeLabel4;
        private DateTimeLabel dateTimeLabel5;
        private DateTimeLabel dateTimeLabel6;
        private DateTimeLabel dateTimeLabel7;
        private System.Windows.Forms.Button btnNextWeek;
        private System.Windows.Forms.Button btnPrevWeek;
        private ResourceLabel resourceLabel1;
        private ResourceLabel resourceLabel2;
        private ResourceLabel resourceLabel3;
    }
}
