namespace FactoryPattern
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
            this.btnSelectCar = new System.Windows.Forms.Button();
            this.btnSelectBall = new System.Windows.Forms.Button();
            this.lblNext = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.btnSelectPresent = new System.Windows.Forms.Button();
            this.btnColorPresent = new System.Windows.Forms.Button();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnSelectCar
            // 
            this.btnSelectCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectCar.Location = new System.Drawing.Point(13, 13);
            this.btnSelectCar.Name = "btnSelectCar";
            this.btnSelectCar.Size = new System.Drawing.Size(78, 57);
            this.btnSelectCar.TabIndex = 0;
            this.btnSelectCar.Text = "CAR";
            this.btnSelectCar.UseVisualStyleBackColor = true;
            this.btnSelectCar.Click += new System.EventHandler(this.BtnSelectCar_Click);
            // 
            // btnSelectBall
            // 
            this.btnSelectBall.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectBall.Location = new System.Drawing.Point(117, 13);
            this.btnSelectBall.Name = "btnSelectBall";
            this.btnSelectBall.Size = new System.Drawing.Size(78, 59);
            this.btnSelectBall.TabIndex = 1;
            this.btnSelectBall.Text = "BALL";
            this.btnSelectBall.UseVisualStyleBackColor = true;
            this.btnSelectBall.Click += new System.EventHandler(this.BtnSelectBall_Click);
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNext.Location = new System.Drawing.Point(360, 13);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(82, 13);
            this.lblNext.TabIndex = 2;
            this.lblNext.Text = "Coming Next:";
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Blue;
            this.btnColor.Location = new System.Drawing.Point(117, 78);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(78, 34);
            this.btnColor.TabIndex = 3;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(-1, 166);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(833, 173);
            this.mainPanel.TabIndex = 4;
            // 
            // btnSelectPresent
            // 
            this.btnSelectPresent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectPresent.Location = new System.Drawing.Point(223, 14);
            this.btnSelectPresent.Name = "btnSelectPresent";
            this.btnSelectPresent.Size = new System.Drawing.Size(78, 57);
            this.btnSelectPresent.TabIndex = 5;
            this.btnSelectPresent.Text = "PRESENT";
            this.btnSelectPresent.UseVisualStyleBackColor = true;
            this.btnSelectPresent.Click += new System.EventHandler(this.BtnSelectPresent_Click);
            // 
            // btnColorPresent
            // 
            this.btnColorPresent.BackColor = System.Drawing.Color.Red;
            this.btnColorPresent.Location = new System.Drawing.Point(223, 78);
            this.btnColorPresent.Name = "btnColorPresent";
            this.btnColorPresent.Size = new System.Drawing.Size(78, 34);
            this.btnColorPresent.TabIndex = 6;
            this.btnColorPresent.UseVisualStyleBackColor = false;
            this.btnColorPresent.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.CreateTimer_Tick_1);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.ConveyorTimer_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 339);
            this.Controls.Add(this.btnColorPresent);
            this.Controls.Add(this.btnSelectPresent);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.lblNext);
            this.Controls.Add(this.btnSelectBall);
            this.Controls.Add(this.btnSelectCar);
            this.Name = "Form1";
            this.Text = "FactoryPattern";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectCar;
        private System.Windows.Forms.Button btnSelectBall;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btnSelectPresent;
        private System.Windows.Forms.Button btnColorPresent;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
    }
}

