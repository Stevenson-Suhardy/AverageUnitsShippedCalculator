
namespace AverageUnitsShippedCalculator
{
    partial class formAverageUnitsShipped
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelUnitsPrompt = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxUnitsInput = new System.Windows.Forms.TextBox();
            this.textBoxPastEntries = new System.Windows.Forms.TextBox();
            this.labelAverage = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labelUnitsPrompt
            // 
            this.labelUnitsPrompt.AutoSize = true;
            this.labelUnitsPrompt.Location = new System.Drawing.Point(52, 29);
            this.labelUnitsPrompt.Name = "labelUnitsPrompt";
            this.labelUnitsPrompt.Size = new System.Drawing.Size(37, 15);
            this.labelUnitsPrompt.TabIndex = 0;
            this.labelUnitsPrompt.Text = "&Units:";
            this.labelUnitsPrompt.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Location = new System.Drawing.Point(203, 29);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(36, 15);
            this.labelDay.TabIndex = 2;
            this.labelDay.Text = "Day 1";
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(12, 277);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(75, 23);
            this.buttonEnter.TabIndex = 5;
            this.buttonEnter.Text = "&Enter";
            this.toolTip.SetToolTip(this.buttonEnter, "Click to attempt to enter the current units shipped");
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(107, 277);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "&Reset";
            this.toolTip.SetToolTip(this.buttonReset, "Click to reset the form");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(203, 277);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "E&xit";
            this.toolTip.SetToolTip(this.buttonExit, "Click to exit the application");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxUnitsInput
            // 
            this.textBoxUnitsInput.Location = new System.Drawing.Point(95, 26);
            this.textBoxUnitsInput.Name = "textBoxUnitsInput";
            this.textBoxUnitsInput.Size = new System.Drawing.Size(100, 23);
            this.textBoxUnitsInput.TabIndex = 1;
            this.toolTip.SetToolTip(this.textBoxUnitsInput, "Enter the day\'s number of units shipped");
            this.textBoxUnitsInput.TextChanged += new System.EventHandler(this.textBoxUnitsInput_TextChanged);
            // 
            // textBoxPastEntries
            // 
            this.textBoxPastEntries.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxPastEntries.Location = new System.Drawing.Point(52, 55);
            this.textBoxPastEntries.Multiline = true;
            this.textBoxPastEntries.Name = "textBoxPastEntries";
            this.textBoxPastEntries.ReadOnly = true;
            this.textBoxPastEntries.Size = new System.Drawing.Size(187, 187);
            this.textBoxPastEntries.TabIndex = 3;
            this.toolTip.SetToolTip(this.textBoxPastEntries, "Displays the units shipped for each day");
            // 
            // labelAverage
            // 
            this.labelAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAverage.Location = new System.Drawing.Point(52, 245);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(187, 29);
            this.labelAverage.TabIndex = 4;
            this.labelAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.labelAverage, "Displays the average of units shipped");
            this.labelAverage.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // formAverageUnitsShipped
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonReset;
            this.ClientSize = new System.Drawing.Size(302, 312);
            this.Controls.Add(this.labelAverage);
            this.Controls.Add(this.textBoxPastEntries);
            this.Controls.Add(this.textBoxUnitsInput);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.labelUnitsPrompt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formAverageUnitsShipped";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Average Units Shipped";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUnitsPrompt;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxUnitsInput;
        private System.Windows.Forms.TextBox textBoxPastEntries;
        private System.Windows.Forms.Label labelAverage;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

