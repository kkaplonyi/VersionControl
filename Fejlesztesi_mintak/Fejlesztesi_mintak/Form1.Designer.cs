namespace Fejlesztesi_mintak
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.btnSelectCar = new System.Windows.Forms.Button();
            this.btnSelectBall = new System.Windows.Forms.Button();
            this.lblNext = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnSelectPresent = new System.Windows.Forms.Button();
            this.rbn_color = new System.Windows.Forms.Button();
            this.box_color = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(1, 201);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1281, 156);
            this.mainPanel.TabIndex = 0;
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // btnSelectCar
            // 
            this.btnSelectCar.Location = new System.Drawing.Point(27, 24);
            this.btnSelectCar.Name = "btnSelectCar";
            this.btnSelectCar.Size = new System.Drawing.Size(103, 23);
            this.btnSelectCar.TabIndex = 1;
            this.btnSelectCar.Text = "CAR";
            this.btnSelectCar.UseVisualStyleBackColor = true;
            this.btnSelectCar.Click += new System.EventHandler(this.btnSelectCar_Click);
            // 
            // btnSelectBall
            // 
            this.btnSelectBall.Location = new System.Drawing.Point(178, 24);
            this.btnSelectBall.Name = "btnSelectBall";
            this.btnSelectBall.Size = new System.Drawing.Size(103, 23);
            this.btnSelectBall.TabIndex = 1;
            this.btnSelectBall.Text = "BALL";
            this.btnSelectBall.UseVisualStyleBackColor = true;
            this.btnSelectBall.Click += new System.EventHandler(this.btnSelectBall_Click);
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Location = new System.Drawing.Point(492, 24);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(89, 17);
            this.lblNext.TabIndex = 2;
            this.lblNext.Text = "Coming next:";
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Lime;
            this.btnColor.Location = new System.Drawing.Point(178, 53);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(103, 23);
            this.btnColor.TabIndex = 3;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnSelectPresent
            // 
            this.btnSelectPresent.Location = new System.Drawing.Point(328, 24);
            this.btnSelectPresent.Name = "btnSelectPresent";
            this.btnSelectPresent.Size = new System.Drawing.Size(103, 23);
            this.btnSelectPresent.TabIndex = 4;
            this.btnSelectPresent.Text = "PRESENT";
            this.btnSelectPresent.UseVisualStyleBackColor = true;
            this.btnSelectPresent.Click += new System.EventHandler(this.btnSelectPresent_Click);
            // 
            // rbn_color
            // 
            this.rbn_color.BackColor = System.Drawing.Color.Lime;
            this.rbn_color.Location = new System.Drawing.Point(328, 82);
            this.rbn_color.Name = "rbn_color";
            this.rbn_color.Size = new System.Drawing.Size(103, 23);
            this.rbn_color.TabIndex = 3;
            this.rbn_color.UseVisualStyleBackColor = false;
            this.rbn_color.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // box_color
            // 
            this.box_color.BackColor = System.Drawing.Color.Lime;
            this.box_color.Location = new System.Drawing.Point(328, 53);
            this.box_color.Name = "box_color";
            this.box_color.Size = new System.Drawing.Size(103, 23);
            this.box_color.TabIndex = 3;
            this.box_color.UseVisualStyleBackColor = false;
            this.box_color.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 355);
            this.Controls.Add(this.btnSelectPresent);
            this.Controls.Add(this.box_color);
            this.Controls.Add(this.rbn_color);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.lblNext);
            this.Controls.Add(this.btnSelectBall);
            this.Controls.Add(this.btnSelectCar);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Button btnSelectCar;
        private System.Windows.Forms.Button btnSelectBall;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnSelectPresent;
        private System.Windows.Forms.Button rbn_color;
        private System.Windows.Forms.Button box_color;
    }
}

