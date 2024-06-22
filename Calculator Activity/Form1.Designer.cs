namespace Calculator_Activity
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            output = new TextBox();
            resetBtn = new Button();
            clearBtn = new Button();
            sevenBtn = new Button();
            eightBtn = new Button();
            nineBtn = new Button();
            fourBtn = new Button();
            fiveBtn = new Button();
            sixBtn = new Button();
            oneBtn = new Button();
            twoBtn = new Button();
            threeBtn = new Button();
            zeroBtn = new Button();
            deciBtn = new Button();
            mulBtn = new Button();
            subBtn = new Button();
            addBtn = new Button();
            equalBtn = new Button();
            divBtn = new Button();
            zerosBtn = new Button();
            SuspendLayout();
            // 
            // output
            // 
            output.BackColor = Color.FromArgb(243, 238, 234);
            output.BorderStyle = BorderStyle.None;
            output.Enabled = false;
            output.Font = new Font("Segoe UI Semibold", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            output.ForeColor = Color.FromArgb(89, 69, 69);
            output.Location = new Point(14, 14);
            output.Multiline = true;
            output.Name = "output";
            output.Size = new Size(370, 62);
            output.TabIndex = 0;
            output.Text = "0";
            output.TextAlign = HorizontalAlignment.Right;
            // 
            // resetBtn
            // 
            resetBtn.BackColor = Color.FromArgb(228, 211, 207);
            resetBtn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            resetBtn.ForeColor = Color.FromArgb(89, 69, 69);
            resetBtn.Location = new Point(14, 96);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(86, 62);
            resetBtn.TabIndex = 2;
            resetBtn.Text = "C";
            resetBtn.UseVisualStyleBackColor = false;
            resetBtn.MouseClick += resetBtn_MouseClick;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = Color.FromArgb(228, 211, 207);
            clearBtn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            clearBtn.ForeColor = Color.FromArgb(89, 69, 69);
            clearBtn.Location = new Point(107, 96);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(177, 62);
            clearBtn.TabIndex = 3;
            clearBtn.Text = "Del";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.MouseClick += clearBtn_MouseClick;
            // 
            // sevenBtn
            // 
            sevenBtn.BackColor = Color.FromArgb(226, 188, 183);
            sevenBtn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            sevenBtn.ForeColor = Color.FromArgb(89, 69, 69);
            sevenBtn.Location = new Point(14, 162);
            sevenBtn.Name = "sevenBtn";
            sevenBtn.Size = new Size(86, 62);
            sevenBtn.TabIndex = 4;
            sevenBtn.Text = "7";
            sevenBtn.UseVisualStyleBackColor = false;
            sevenBtn.MouseClick += numClick;
            // 
            // eightBtn
            // 
            eightBtn.BackColor = Color.FromArgb(226, 188, 183);
            eightBtn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            eightBtn.ForeColor = Color.FromArgb(89, 69, 69);
            eightBtn.Location = new Point(106, 162);
            eightBtn.Name = "eightBtn";
            eightBtn.Size = new Size(86, 62);
            eightBtn.TabIndex = 5;
            eightBtn.Text = "8";
            eightBtn.UseVisualStyleBackColor = false;
            eightBtn.MouseClick += numClick;
            // 
            // nineBtn
            // 
            nineBtn.BackColor = Color.FromArgb(226, 188, 183);
            nineBtn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            nineBtn.ForeColor = Color.FromArgb(89, 69, 69);
            nineBtn.Location = new Point(199, 162);
            nineBtn.Name = "nineBtn";
            nineBtn.Size = new Size(86, 62);
            nineBtn.TabIndex = 6;
            nineBtn.Text = "9";
            nineBtn.UseVisualStyleBackColor = false;
            nineBtn.MouseClick += numClick;
            // 
            // fourBtn
            // 
            fourBtn.BackColor = Color.FromArgb(226, 188, 183);
            fourBtn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            fourBtn.ForeColor = Color.FromArgb(89, 69, 69);
            fourBtn.Location = new Point(14, 231);
            fourBtn.Name = "fourBtn";
            fourBtn.Size = new Size(86, 62);
            fourBtn.TabIndex = 7;
            fourBtn.Text = "4";
            fourBtn.UseVisualStyleBackColor = false;
            fourBtn.MouseClick += numClick;
            // 
            // fiveBtn
            // 
            fiveBtn.BackColor = Color.FromArgb(226, 188, 183);
            fiveBtn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            fiveBtn.ForeColor = Color.FromArgb(89, 69, 69);
            fiveBtn.Location = new Point(106, 231);
            fiveBtn.Name = "fiveBtn";
            fiveBtn.Size = new Size(86, 62);
            fiveBtn.TabIndex = 8;
            fiveBtn.Text = "5";
            fiveBtn.UseVisualStyleBackColor = false;
            fiveBtn.MouseClick += numClick;
            // 
            // sixBtn
            // 
            sixBtn.BackColor = Color.FromArgb(226, 188, 183);
            sixBtn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            sixBtn.ForeColor = Color.FromArgb(89, 69, 69);
            sixBtn.Location = new Point(199, 231);
            sixBtn.Name = "sixBtn";
            sixBtn.Size = new Size(86, 62);
            sixBtn.TabIndex = 9;
            sixBtn.Text = "6";
            sixBtn.UseVisualStyleBackColor = false;
            sixBtn.MouseClick += numClick;
            // 
            // oneBtn
            // 
            oneBtn.BackColor = Color.FromArgb(226, 188, 183);
            oneBtn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            oneBtn.ForeColor = Color.FromArgb(89, 69, 69);
            oneBtn.Location = new Point(14, 300);
            oneBtn.Name = "oneBtn";
            oneBtn.Size = new Size(86, 62);
            oneBtn.TabIndex = 10;
            oneBtn.Text = "1";
            oneBtn.UseVisualStyleBackColor = false;
            oneBtn.MouseClick += numClick;
            // 
            // twoBtn
            // 
            twoBtn.BackColor = Color.FromArgb(226, 188, 183);
            twoBtn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            twoBtn.ForeColor = Color.FromArgb(89, 69, 69);
            twoBtn.Location = new Point(106, 300);
            twoBtn.Name = "twoBtn";
            twoBtn.Size = new Size(86, 62);
            twoBtn.TabIndex = 11;
            twoBtn.Text = "2";
            twoBtn.UseVisualStyleBackColor = false;
            twoBtn.MouseClick += numClick;
            // 
            // threeBtn
            // 
            threeBtn.BackColor = Color.FromArgb(226, 188, 183);
            threeBtn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            threeBtn.ForeColor = Color.FromArgb(89, 69, 69);
            threeBtn.Location = new Point(199, 300);
            threeBtn.Name = "threeBtn";
            threeBtn.Size = new Size(86, 62);
            threeBtn.TabIndex = 12;
            threeBtn.Text = "3";
            threeBtn.UseVisualStyleBackColor = false;
            threeBtn.MouseClick += numClick;
            // 
            // zeroBtn
            // 
            zeroBtn.BackColor = Color.FromArgb(226, 188, 183);
            zeroBtn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            zeroBtn.ForeColor = Color.FromArgb(89, 69, 69);
            zeroBtn.Location = new Point(106, 369);
            zeroBtn.Name = "zeroBtn";
            zeroBtn.Size = new Size(86, 62);
            zeroBtn.TabIndex = 13;
            zeroBtn.Text = "0";
            zeroBtn.UseVisualStyleBackColor = false;
            zeroBtn.MouseClick += numClick;
            // 
            // deciBtn
            // 
            deciBtn.BackColor = Color.FromArgb(226, 188, 183);
            deciBtn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            deciBtn.ForeColor = Color.FromArgb(89, 69, 69);
            deciBtn.Location = new Point(198, 369);
            deciBtn.Name = "deciBtn";
            deciBtn.Size = new Size(86, 62);
            deciBtn.TabIndex = 15;
            deciBtn.Text = ".";
            deciBtn.UseVisualStyleBackColor = false;
            deciBtn.MouseClick += deciClick;
            // 
            // mulBtn
            // 
            mulBtn.BackColor = Color.FromArgb(228, 211, 207);
            mulBtn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            mulBtn.ForeColor = Color.FromArgb(89, 69, 69);
            mulBtn.Location = new Point(298, 164);
            mulBtn.Name = "mulBtn";
            mulBtn.Size = new Size(86, 62);
            mulBtn.TabIndex = 16;
            mulBtn.Text = "*";
            mulBtn.UseVisualStyleBackColor = false;
            mulBtn.MouseClick += operatorClick;
            // 
            // subBtn
            // 
            subBtn.BackColor = Color.FromArgb(228, 211, 207);
            subBtn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            subBtn.ForeColor = Color.FromArgb(89, 69, 69);
            subBtn.Location = new Point(298, 232);
            subBtn.Name = "subBtn";
            subBtn.Size = new Size(86, 62);
            subBtn.TabIndex = 17;
            subBtn.Text = "-";
            subBtn.UseVisualStyleBackColor = false;
            subBtn.MouseClick += operatorClick;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.FromArgb(228, 211, 207);
            addBtn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            addBtn.ForeColor = Color.FromArgb(89, 69, 69);
            addBtn.Location = new Point(298, 300);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(86, 62);
            addBtn.TabIndex = 18;
            addBtn.Text = "+";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.MouseClick += operatorClick;
            // 
            // equalBtn
            // 
            equalBtn.BackColor = Color.FromArgb(89, 69, 69);
            equalBtn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            equalBtn.ForeColor = Color.FromArgb(226, 188, 183);
            equalBtn.Location = new Point(298, 368);
            equalBtn.Name = "equalBtn";
            equalBtn.Size = new Size(86, 62);
            equalBtn.TabIndex = 19;
            equalBtn.Text = "=";
            equalBtn.UseVisualStyleBackColor = false;
            equalBtn.MouseClick += equalBtn_MouseClick;
            // 
            // divBtn
            // 
            divBtn.BackColor = Color.FromArgb(228, 211, 207);
            divBtn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            divBtn.ForeColor = Color.FromArgb(89, 69, 69);
            divBtn.Location = new Point(298, 96);
            divBtn.Name = "divBtn";
            divBtn.Size = new Size(86, 62);
            divBtn.TabIndex = 21;
            divBtn.Text = "/";
            divBtn.UseVisualStyleBackColor = false;
            divBtn.MouseClick += operatorClick;
            // 
            // zerosBtn
            // 
            zerosBtn.BackColor = Color.FromArgb(226, 188, 183);
            zerosBtn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            zerosBtn.ForeColor = Color.FromArgb(89, 69, 69);
            zerosBtn.Location = new Point(14, 368);
            zerosBtn.Name = "zerosBtn";
            zerosBtn.Size = new Size(86, 62);
            zerosBtn.TabIndex = 22;
            zerosBtn.Text = "00";
            zerosBtn.UseVisualStyleBackColor = false;
            zerosBtn.MouseClick += numClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(158, 157, 137);
            ClientSize = new Size(398, 442);
            Controls.Add(zerosBtn);
            Controls.Add(divBtn);
            Controls.Add(equalBtn);
            Controls.Add(addBtn);
            Controls.Add(subBtn);
            Controls.Add(mulBtn);
            Controls.Add(deciBtn);
            Controls.Add(zeroBtn);
            Controls.Add(threeBtn);
            Controls.Add(twoBtn);
            Controls.Add(oneBtn);
            Controls.Add(sixBtn);
            Controls.Add(fiveBtn);
            Controls.Add(fourBtn);
            Controls.Add(nineBtn);
            Controls.Add(eightBtn);
            Controls.Add(sevenBtn);
            Controls.Add(clearBtn);
            Controls.Add(resetBtn);
            Controls.Add(output);
            Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(158, 157, 137);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox output;
        private Button rest;
        private Button clearBtn;
        private Button button4;
        private Button eightBtn;
        private Button nineBtn;
        private Button fourBtn;
        private Button fiveBtn;
        private Button sixBtn;
        private Button oneBtn;
        private Button twoBtn;
        private Button threeBtn;
        private Button zeroBtn;
        private Button button13;
        private Button deciBtn;
        private Button mulBtn;
        private Button subBtn;
        private Button addBtn;
        private Button equalBtn;
        private Button button19;
        private Button button20;
        private Button resetBtn;
        private Button sevenBtn;
        private Button divBtn;
        private Button zerosBtn;
    }
}
