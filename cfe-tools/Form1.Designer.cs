namespace cfe_tools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxENV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCFEInput = new System.Windows.Forms.TextBox();
            this.buttonInBrowse = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.textBoxCFEOutput = new System.Windows.Forms.TextBox();
            this.buttonOutBrowse = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMAC = new System.Windows.Forms.TextBox();
            this.button64MBRamMod = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxPreset = new System.Windows.Forms.GroupBox();
            this.line2 = new cfe_tools.line();
            this.line1 = new cfe_tools.line();
            this.groupBoxPreset.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxENV
            // 
            this.textBoxENV.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxENV.Location = new System.Drawing.Point(13, 157);
            this.textBoxENV.Multiline = true;
            this.textBoxENV.Name = "textBoxENV";
            this.textBoxENV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxENV.Size = new System.Drawing.Size(690, 253);
            this.textBoxENV.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CFE Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CFE Output";
            // 
            // textBoxCFEInput
            // 
            this.textBoxCFEInput.Location = new System.Drawing.Point(70, 12);
            this.textBoxCFEInput.Name = "textBoxCFEInput";
            this.textBoxCFEInput.Size = new System.Drawing.Size(471, 20);
            this.textBoxCFEInput.TabIndex = 4;
            this.textBoxCFEInput.Text = "wrt54gl-cfe.bin";
            // 
            // buttonInBrowse
            // 
            this.buttonInBrowse.Location = new System.Drawing.Point(547, 11);
            this.buttonInBrowse.Name = "buttonInBrowse";
            this.buttonInBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonInBrowse.TabIndex = 5;
            this.buttonInBrowse.Text = "Browse";
            this.buttonInBrowse.UseVisualStyleBackColor = true;
            this.buttonInBrowse.Click += new System.EventHandler(this.buttonInBrowse_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(628, 11);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 6;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // textBoxCFEOutput
            // 
            this.textBoxCFEOutput.Location = new System.Drawing.Point(70, 52);
            this.textBoxCFEOutput.Name = "textBoxCFEOutput";
            this.textBoxCFEOutput.Size = new System.Drawing.Size(471, 20);
            this.textBoxCFEOutput.TabIndex = 7;
            this.textBoxCFEOutput.Text = "cfe-o.bin";
            // 
            // buttonOutBrowse
            // 
            this.buttonOutBrowse.Location = new System.Drawing.Point(547, 50);
            this.buttonOutBrowse.Name = "buttonOutBrowse";
            this.buttonOutBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonOutBrowse.TabIndex = 8;
            this.buttonOutBrowse.Text = "Browse";
            this.buttonOutBrowse.UseVisualStyleBackColor = true;
            this.buttonOutBrowse.Click += new System.EventHandler(this.buttonOutBrowse_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(628, 50);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "LAN MAC";
            // 
            // textBoxMAC
            // 
            this.textBoxMAC.Location = new System.Drawing.Point(70, 88);
            this.textBoxMAC.MaxLength = 17;
            this.textBoxMAC.Name = "textBoxMAC";
            this.textBoxMAC.Size = new System.Drawing.Size(150, 20);
            this.textBoxMAC.TabIndex = 13;
            this.textBoxMAC.Text = "00:00:00:00:00:00";
            this.textBoxMAC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button64MBRamMod
            // 
            this.button64MBRamMod.Location = new System.Drawing.Point(9, 22);
            this.button64MBRamMod.Name = "button64MBRamMod";
            this.button64MBRamMod.Size = new System.Drawing.Size(161, 23);
            this.button64MBRamMod.TabIndex = 14;
            this.button64MBRamMod.Text = "64MB RAM MOD";
            this.button64MBRamMod.UseVisualStyleBackColor = true;
            this.button64MBRamMod.Click += new System.EventHandler(this.button64MBRamMod_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(9, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Environment String";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "cfe.bin";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "cfe-out.bin";
            // 
            // groupBoxPreset
            // 
            this.groupBoxPreset.Controls.Add(this.button64MBRamMod);
            this.groupBoxPreset.Location = new System.Drawing.Point(226, 88);
            this.groupBoxPreset.Name = "groupBoxPreset";
            this.groupBoxPreset.Size = new System.Drawing.Size(477, 63);
            this.groupBoxPreset.TabIndex = 16;
            this.groupBoxPreset.TabStop = false;
            this.groupBoxPreset.Text = "Preset";
            // 
            // line2
            // 
            this.line2.Location = new System.Drawing.Point(7, 79);
            this.line2.MaximumSize = new System.Drawing.Size(2000, 2);
            this.line2.MinimumSize = new System.Drawing.Size(0, 2);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(700, 2);
            this.line2.TabIndex = 11;
            // 
            // line1
            // 
            this.line1.Location = new System.Drawing.Point(7, 42);
            this.line1.MaximumSize = new System.Drawing.Size(2000, 2);
            this.line1.MinimumSize = new System.Drawing.Size(0, 2);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(700, 2);
            this.line1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(715, 422);
            this.Controls.Add(this.groupBoxPreset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMAC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonOutBrowse);
            this.Controls.Add(this.textBoxCFEOutput);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonInBrowse);
            this.Controls.Add(this.textBoxCFEInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxENV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(731, 460);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(731, 460);
            this.Name = "Form1";
            this.Text = "Linksys WRT54GL CFE Tool By Sun89@electoday.com";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxPreset.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxENV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCFEInput;
        private System.Windows.Forms.Button buttonInBrowse;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.TextBox textBoxCFEOutput;
        private System.Windows.Forms.Button buttonOutBrowse;
        private System.Windows.Forms.Button buttonSave;
        private line line1;
        private line line2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMAC;
        private System.Windows.Forms.Button button64MBRamMod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBoxPreset;
    }
}

