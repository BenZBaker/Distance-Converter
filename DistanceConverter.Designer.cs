
namespace BenBakerAssessment1
{
    partial class DistanceConverter
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
            this.lbl_Enter = new System.Windows.Forms.Label();
            this.txt_Enter = new System.Windows.Forms.TextBox();
            this.lbl_Type = new System.Windows.Forms.Label();
            this.btn_InchToCM = new System.Windows.Forms.Button();
            this.btn_FeetToMetres = new System.Windows.Forms.Button();
            this.btn_YardToMetres = new System.Windows.Forms.Button();
            this.btn_MilesToKMs = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.txt_ConvertedValue = new System.Windows.Forms.TextBox();
            this.lbl_EnterUnits = new System.Windows.Forms.Label();
            this.lbl_ConvertedValueUnits = new System.Windows.Forms.Label();
            this.lbl_Intro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Enter
            // 
            this.lbl_Enter.AutoSize = true;
            this.lbl_Enter.Location = new System.Drawing.Point(55, 61);
            this.lbl_Enter.Name = "lbl_Enter";
            this.lbl_Enter.Size = new System.Drawing.Size(157, 13);
            this.lbl_Enter.TabIndex = 0;
            this.lbl_Enter.Text = "Enter the value to be converted";
            // 
            // txt_Enter
            // 
            this.txt_Enter.Location = new System.Drawing.Point(58, 81);
            this.txt_Enter.Name = "txt_Enter";
            this.txt_Enter.Size = new System.Drawing.Size(100, 20);
            this.txt_Enter.TabIndex = 1;
            this.txt_Enter.Enter += new System.EventHandler(this.txt_Enter_Enter);
            // 
            // lbl_Type
            // 
            this.lbl_Type.AutoSize = true;
            this.lbl_Type.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Type.Location = new System.Drawing.Point(55, 198);
            this.lbl_Type.Name = "lbl_Type";
            this.lbl_Type.Size = new System.Drawing.Size(98, 13);
            this.lbl_Type.TabIndex = 2;
            this.lbl_Type.Text = "Type of conversion";
            // 
            // btn_InchToCM
            // 
            this.btn_InchToCM.Location = new System.Drawing.Point(58, 235);
            this.btn_InchToCM.Name = "btn_InchToCM";
            this.btn_InchToCM.Size = new System.Drawing.Size(140, 30);
            this.btn_InchToCM.TabIndex = 2;
            this.btn_InchToCM.Text = "&Inches to Centimetres";
            this.btn_InchToCM.UseVisualStyleBackColor = true;
            this.btn_InchToCM.Click += new System.EventHandler(this.btn_InchToCM_Click);
            // 
            // btn_FeetToMetres
            // 
            this.btn_FeetToMetres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_FeetToMetres.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_FeetToMetres.FlatAppearance.BorderSize = 3;
            this.btn_FeetToMetres.Location = new System.Drawing.Point(58, 271);
            this.btn_FeetToMetres.Name = "btn_FeetToMetres";
            this.btn_FeetToMetres.Size = new System.Drawing.Size(140, 30);
            this.btn_FeetToMetres.TabIndex = 3;
            this.btn_FeetToMetres.Text = "&Feet To Metres";
            this.btn_FeetToMetres.UseVisualStyleBackColor = true;
            this.btn_FeetToMetres.Click += new System.EventHandler(this.btn_FeetToMetres_Click);
            // 
            // btn_YardToMetres
            // 
            this.btn_YardToMetres.Location = new System.Drawing.Point(58, 307);
            this.btn_YardToMetres.Name = "btn_YardToMetres";
            this.btn_YardToMetres.Size = new System.Drawing.Size(140, 30);
            this.btn_YardToMetres.TabIndex = 4;
            this.btn_YardToMetres.Text = "&Yards to Metres";
            this.btn_YardToMetres.UseVisualStyleBackColor = true;
            this.btn_YardToMetres.Click += new System.EventHandler(this.btn_YardToMetres_Click);
            // 
            // btn_MilesToKMs
            // 
            this.btn_MilesToKMs.Location = new System.Drawing.Point(58, 343);
            this.btn_MilesToKMs.Name = "btn_MilesToKMs";
            this.btn_MilesToKMs.Size = new System.Drawing.Size(140, 30);
            this.btn_MilesToKMs.TabIndex = 5;
            this.btn_MilesToKMs.Text = "&Miles to Kilometres";
            this.btn_MilesToKMs.UseVisualStyleBackColor = true;
            this.btn_MilesToKMs.Click += new System.EventHandler(this.btn_MilesToKMs_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(576, 400);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(133, 29);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "E&xit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // txt_ConvertedValue
            // 
            this.txt_ConvertedValue.Location = new System.Drawing.Point(418, 81);
            this.txt_ConvertedValue.Name = "txt_ConvertedValue";
            this.txt_ConvertedValue.Size = new System.Drawing.Size(126, 20);
            this.txt_ConvertedValue.TabIndex = 7;
            this.txt_ConvertedValue.Visible = false;
            // 
            // lbl_EnterUnits
            // 
            this.lbl_EnterUnits.AutoSize = true;
            this.lbl_EnterUnits.Location = new System.Drawing.Point(198, 86);
            this.lbl_EnterUnits.Name = "lbl_EnterUnits";
            this.lbl_EnterUnits.Size = new System.Drawing.Size(72, 13);
            this.lbl_EnterUnits.TabIndex = 8;
            this.lbl_EnterUnits.Text = "lbl_EnterUnits";
            this.lbl_EnterUnits.Visible = false;
            // 
            // lbl_ConvertedValueUnits
            // 
            this.lbl_ConvertedValueUnits.AutoSize = true;
            this.lbl_ConvertedValueUnits.Location = new System.Drawing.Point(573, 86);
            this.lbl_ConvertedValueUnits.Name = "lbl_ConvertedValueUnits";
            this.lbl_ConvertedValueUnits.Size = new System.Drawing.Size(123, 13);
            this.lbl_ConvertedValueUnits.TabIndex = 9;
            this.lbl_ConvertedValueUnits.Text = "lbl_ConvertedValueUnits";
            this.lbl_ConvertedValueUnits.Visible = false;
            // 
            // lbl_Intro
            // 
            this.lbl_Intro.AutoSize = true;
            this.lbl_Intro.Location = new System.Drawing.Point(11, 8);
            this.lbl_Intro.Name = "lbl_Intro";
            this.lbl_Intro.Size = new System.Drawing.Size(340, 13);
            this.lbl_Intro.TabIndex = 10;
            this.lbl_Intro.Text = "This application will convert distances from Imperial units to metric units";
            // 
            // DistanceConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Intro);
            this.Controls.Add(this.lbl_ConvertedValueUnits);
            this.Controls.Add(this.lbl_EnterUnits);
            this.Controls.Add(this.txt_ConvertedValue);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_MilesToKMs);
            this.Controls.Add(this.btn_YardToMetres);
            this.Controls.Add(this.btn_FeetToMetres);
            this.Controls.Add(this.btn_InchToCM);
            this.Controls.Add(this.lbl_Type);
            this.Controls.Add(this.txt_Enter);
            this.Controls.Add(this.lbl_Enter);
            this.KeyPreview = true;
            this.Name = "DistanceConverter";
            this.Text = "Distance Converter";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DistanceConverter_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Enter;
        private System.Windows.Forms.TextBox txt_Enter;
        private System.Windows.Forms.Label lbl_Type;
        private System.Windows.Forms.Button btn_InchToCM;
        private System.Windows.Forms.Button btn_FeetToMetres;
        private System.Windows.Forms.Button btn_YardToMetres;
        private System.Windows.Forms.Button btn_MilesToKMs;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.TextBox txt_ConvertedValue;
        private System.Windows.Forms.Label lbl_EnterUnits;
        private System.Windows.Forms.Label lbl_ConvertedValueUnits;
        private System.Windows.Forms.Label lbl_Intro;
    }
}

