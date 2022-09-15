namespace NuclearReactor
{
    partial class form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.titleLabel = new System.Windows.Forms.Label();
            this.reactor1Label = new System.Windows.Forms.Label();
            this.reactor2Label = new System.Windows.Forms.Label();
            this.reactor1StateLabel = new System.Windows.Forms.Label();
            this.reactor2StateLabel = new System.Windows.Forms.Label();
            this.reactorControlLabel = new System.Windows.Forms.Label();
            this.reactorStartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleLabel.BackColor = System.Drawing.Color.Lime;
            this.titleLabel.Font = new System.Drawing.Font("OCR A Extended", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(168, 35);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(477, 40);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Nuclear Reactor Control";
            // 
            // reactor1Label
            // 
            this.reactor1Label.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactor1Label.Location = new System.Drawing.Point(171, 125);
            this.reactor1Label.Name = "reactor1Label";
            this.reactor1Label.Size = new System.Drawing.Size(100, 23);
            this.reactor1Label.TabIndex = 1;
            this.reactor1Label.Text = "Reactor 1";
            this.reactor1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reactor2Label
            // 
            this.reactor2Label.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactor2Label.Location = new System.Drawing.Point(545, 125);
            this.reactor2Label.Name = "reactor2Label";
            this.reactor2Label.Size = new System.Drawing.Size(100, 23);
            this.reactor2Label.TabIndex = 2;
            this.reactor2Label.Text = "Reactor 2";
            this.reactor2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reactor1StateLabel
            // 
            this.reactor1StateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reactor1StateLabel.BackColor = System.Drawing.Color.Honeydew;
            this.reactor1StateLabel.Location = new System.Drawing.Point(147, 174);
            this.reactor1StateLabel.Name = "reactor1StateLabel";
            this.reactor1StateLabel.Size = new System.Drawing.Size(141, 115);
            this.reactor1StateLabel.TabIndex = 3;
            // 
            // reactor2StateLabel
            // 
            this.reactor2StateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reactor2StateLabel.BackColor = System.Drawing.Color.Honeydew;
            this.reactor2StateLabel.Location = new System.Drawing.Point(522, 174);
            this.reactor2StateLabel.Name = "reactor2StateLabel";
            this.reactor2StateLabel.Size = new System.Drawing.Size(141, 115);
            this.reactor2StateLabel.TabIndex = 4;
            // 
            // reactorControlLabel
            // 
            this.reactorControlLabel.BackColor = System.Drawing.Color.Honeydew;
            this.reactorControlLabel.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactorControlLabel.Location = new System.Drawing.Point(144, 416);
            this.reactorControlLabel.Name = "reactorControlLabel";
            this.reactorControlLabel.Size = new System.Drawing.Size(519, 34);
            this.reactorControlLabel.TabIndex = 5;
            this.reactorControlLabel.Text = "Reactors Stable";
            this.reactorControlLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.reactorControlLabel.Click += new System.EventHandler(this.reactorControlLabel_Click);
            // 
            // reactorStartButton
            // 
            this.reactorStartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.reactorStartButton.BackColor = System.Drawing.Color.Honeydew;
            this.reactorStartButton.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactorStartButton.Location = new System.Drawing.Point(323, 331);
            this.reactorStartButton.Name = "reactorStartButton";
            this.reactorStartButton.Size = new System.Drawing.Size(169, 41);
            this.reactorStartButton.TabIndex = 6;
            this.reactorStartButton.Text = "Start Reactors";
            this.reactorStartButton.UseVisualStyleBackColor = false;
            this.reactorStartButton.Click += new System.EventHandler(this.reactorStartButton_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.reactorStartButton);
            this.Controls.Add(this.reactorControlLabel);
            this.Controls.Add(this.reactor2StateLabel);
            this.Controls.Add(this.reactor1StateLabel);
            this.Controls.Add(this.reactor2Label);
            this.Controls.Add(this.reactor1Label);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form1";
            this.Text = "Nuclear Reactor State";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label reactor1Label;
        private System.Windows.Forms.Label reactor2Label;
        private System.Windows.Forms.Label reactor1StateLabel;
        private System.Windows.Forms.Label reactor2StateLabel;
        private System.Windows.Forms.Label reactorControlLabel;
        private System.Windows.Forms.Button reactorStartButton;
    }
}

