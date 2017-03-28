namespace ReservationAdmin
{
    partial class MainForm
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
            this.reservationView1 = new ReservationSystemControl.ReservationView();
            this.SuspendLayout();
            // 
            // reservationView1
            // 
            this.reservationView1.Location = new System.Drawing.Point(12, 12);
            this.reservationView1.Name = "reservationView1";
            this.reservationView1.Size = new System.Drawing.Size(1007, 444);
            this.reservationView1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 474);
            this.Controls.Add(this.reservationView1);
            this.Name = "MainForm";
            this.Text = "Reservation Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private ReservationSystemControl.ReservationView reservationView1;
    }
}

