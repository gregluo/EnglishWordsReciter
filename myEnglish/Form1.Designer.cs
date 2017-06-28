namespace myEnglish
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.chkRandom = new System.Windows.Forms.CheckBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.btnNext = new System.Windows.Forms.Button();
            this.btnESC = new System.Windows.Forms.Button();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.chb_mouse = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.AutoWordSelection = true;
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1131, 49);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(12, 68);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(1131, 140);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 215);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(64, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(93, 213);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(79, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "50";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1077, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 3;
            // 
            // chkRandom
            // 
            this.chkRandom.AutoSize = true;
            this.chkRandom.Location = new System.Drawing.Point(432, 215);
            this.chkRandom.Name = "chkRandom";
            this.chkRandom.Size = new System.Drawing.Size(83, 21);
            this.chkRandom.TabIndex = 4;
            this.chkRandom.Text = "Random";
            this.chkRandom.UseVisualStyleBackColor = true;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 5000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 700;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(460, 257);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 24);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnESC
            // 
            this.btnESC.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnESC.Location = new System.Drawing.Point(564, 257);
            this.btnESC.Name = "btnESC";
            this.btnESC.Size = new System.Drawing.Size(75, 24);
            this.btnESC.TabIndex = 6;
            this.btnESC.Text = "Delete";
            this.btnESC.UseVisualStyleBackColor = true;
            this.btnESC.Click += new System.EventHandler(this.btnESC_Click);
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(296, 217);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(45, 21);
            this.chkAll.TabIndex = 4;
            this.chkAll.Text = "All";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chk_all_CheckedChanged);
            // 
            // chb_mouse
            // 
            this.chb_mouse.AutoSize = true;
            this.chb_mouse.Checked = true;
            this.chb_mouse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_mouse.Location = new System.Drawing.Point(1060, 217);
            this.chb_mouse.Name = "chb_mouse";
            this.chb_mouse.Size = new System.Drawing.Size(72, 21);
            this.chb_mouse.TabIndex = 4;
            this.chb_mouse.Text = "Mouse";
            this.chb_mouse.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnESC;
            this.ClientSize = new System.Drawing.Size(1155, 248);
            this.Controls.Add(this.btnESC);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.chkAll);
            this.Controls.Add(this.chb_mouse);
            this.Controls.Add(this.chkRandom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkRandom;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnESC;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.CheckBox chb_mouse;
    }
}

