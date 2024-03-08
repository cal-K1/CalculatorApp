namespace CalculatorApp
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
            gpbCalcMain = new GroupBox();
            btnDelete = new Button();
            btnDecimal = new Button();
            btnEquals = new Button();
            btnPi = new Button();
            btnSquared = new Button();
            btnDivide = new Button();
            buttonMultiply = new Button();
            btnMinus = new Button();
            btnAdd = new Button();
            btnZero = new Button();
            btnThree = new Button();
            btnTwo = new Button();
            btnOne = new Button();
            btnSix = new Button();
            btnFive = new Button();
            btnFour = new Button();
            btnNine = new Button();
            btnEight = new Button();
            btnSeven = new Button();
            btnAC = new Button();
            btnCalcOnOff = new Button();
            richTextBox1 = new RichTextBox();
            gpbCalcMain.SuspendLayout();
            SuspendLayout();
            // 
            // gpbCalcMain
            // 
            gpbCalcMain.Controls.Add(btnDelete);
            gpbCalcMain.Controls.Add(btnDecimal);
            gpbCalcMain.Controls.Add(btnEquals);
            gpbCalcMain.Controls.Add(btnPi);
            gpbCalcMain.Controls.Add(btnSquared);
            gpbCalcMain.Controls.Add(btnDivide);
            gpbCalcMain.Controls.Add(buttonMultiply);
            gpbCalcMain.Controls.Add(btnMinus);
            gpbCalcMain.Controls.Add(btnAdd);
            gpbCalcMain.Controls.Add(btnZero);
            gpbCalcMain.Controls.Add(btnThree);
            gpbCalcMain.Controls.Add(btnTwo);
            gpbCalcMain.Controls.Add(btnOne);
            gpbCalcMain.Controls.Add(btnSix);
            gpbCalcMain.Controls.Add(btnFive);
            gpbCalcMain.Controls.Add(btnFour);
            gpbCalcMain.Controls.Add(btnNine);
            gpbCalcMain.Controls.Add(btnEight);
            gpbCalcMain.Controls.Add(btnSeven);
            gpbCalcMain.Controls.Add(btnAC);
            gpbCalcMain.Controls.Add(btnCalcOnOff);
            gpbCalcMain.Controls.Add(richTextBox1);
            gpbCalcMain.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpbCalcMain.ForeColor = SystemColors.ButtonHighlight;
            gpbCalcMain.Location = new Point(12, 12);
            gpbCalcMain.Name = "gpbCalcMain";
            gpbCalcMain.Size = new Size(1073, 629);
            gpbCalcMain.TabIndex = 0;
            gpbCalcMain.TabStop = false;
            gpbCalcMain.Text = "Calculator ";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 128, 0);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.FloralWhite;
            btnDelete.Location = new Point(407, 513);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(151, 101);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "DEL";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.BackColor = Color.DarkCyan;
            btnDecimal.FlatStyle = FlatStyle.Flat;
            btnDecimal.Font = new Font("Arial", 48F);
            btnDecimal.ForeColor = Color.FloralWhite;
            btnDecimal.Location = new Point(31, 513);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(151, 101);
            btnDecimal.TabIndex = 20;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = false;
            btnDecimal.Click += btnDecimal_Click;
            // 
            // btnEquals
            // 
            btnEquals.BackColor = Color.Gold;
            btnEquals.DialogResult = DialogResult.OK;
            btnEquals.FlatStyle = FlatStyle.Flat;
            btnEquals.Font = new Font("Arial", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEquals.ForeColor = SystemColors.ButtonFace;
            btnEquals.Location = new Point(811, 488);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(242, 126);
            btnEquals.TabIndex = 19;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = false;
            // 
            // btnPi
            // 
            btnPi.BackColor = Color.CadetBlue;
            btnPi.FlatStyle = FlatStyle.Flat;
            btnPi.Font = new Font("Arial", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPi.ForeColor = SystemColors.ButtonFace;
            btnPi.Location = new Point(849, 363);
            btnPi.Name = "btnPi";
            btnPi.Size = new Size(174, 103);
            btnPi.TabIndex = 18;
            btnPi.Text = "π";
            btnPi.UseVisualStyleBackColor = false;
            btnPi.Click += btnPi_Click;
            // 
            // btnSquared
            // 
            btnSquared.BackColor = Color.CadetBlue;
            btnSquared.FlatStyle = FlatStyle.Flat;
            btnSquared.Font = new Font("Arial", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSquared.ForeColor = SystemColors.ButtonFace;
            btnSquared.Location = new Point(849, 241);
            btnSquared.Name = "btnSquared";
            btnSquared.Size = new Size(174, 103);
            btnSquared.TabIndex = 17;
            btnSquared.Text = "^2";
            btnSquared.UseVisualStyleBackColor = false;
            btnSquared.Click += btnSquared_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.SeaGreen;
            btnDivide.FlatStyle = FlatStyle.Flat;
            btnDivide.Font = new Font("Arial", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDivide.Location = new Point(605, 130);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(180, 112);
            btnDivide.TabIndex = 16;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.BackColor = Color.SeaGreen;
            buttonMultiply.FlatStyle = FlatStyle.Flat;
            buttonMultiply.Font = new Font("Bahnschrift", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonMultiply.ForeColor = SystemColors.ButtonHighlight;
            buttonMultiply.Image = (Image)resources.GetObject("buttonMultiply.Image");
            buttonMultiply.Location = new Point(605, 254);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(180, 112);
            buttonMultiply.TabIndex = 15;
            buttonMultiply.UseVisualStyleBackColor = false;
            buttonMultiply.Click += buttonMultiply_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.SeaGreen;
            btnMinus.FlatStyle = FlatStyle.Flat;
            btnMinus.Font = new Font("Arial", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMinus.Location = new Point(605, 379);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(180, 112);
            btnMinus.TabIndex = 14;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SeaGreen;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Arial", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(605, 502);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(180, 112);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnZero
            // 
            btnZero.BackColor = Color.DeepSkyBlue;
            btnZero.FlatStyle = FlatStyle.Flat;
            btnZero.Font = new Font("Arial", 48F);
            btnZero.ForeColor = Color.FloralWhite;
            btnZero.Location = new Point(218, 513);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(151, 101);
            btnZero.TabIndex = 12;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = false;
            btnZero.Click += NumberButton_Click;
            // 
            // btnThree
            // 
            btnThree.BackColor = Color.DeepSkyBlue;
            btnThree.FlatStyle = FlatStyle.Flat;
            btnThree.Font = new Font("Arial", 48F);
            btnThree.ForeColor = Color.FloralWhite;
            btnThree.Location = new Point(407, 390);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(151, 101);
            btnThree.TabIndex = 11;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = false;
            btnThree.Click += NumberButton_Click;
            // 
            // btnTwo
            // 
            btnTwo.BackColor = Color.DeepSkyBlue;
            btnTwo.FlatStyle = FlatStyle.Flat;
            btnTwo.Font = new Font("Arial", 48F);
            btnTwo.ForeColor = Color.FloralWhite;
            btnTwo.Location = new Point(218, 390);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(151, 101);
            btnTwo.TabIndex = 10;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = false;
            btnTwo.Click += NumberButton_Click;
            // 
            // btnOne
            // 
            btnOne.BackColor = Color.DeepSkyBlue;
            btnOne.FlatStyle = FlatStyle.Flat;
            btnOne.Font = new Font("Arial", 48F);
            btnOne.ForeColor = Color.FloralWhite;
            btnOne.Location = new Point(31, 390);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(151, 101);
            btnOne.TabIndex = 9;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = false;
            btnOne.Click += NumberButton_Click;
            // 
            // btnSix
            // 
            btnSix.BackColor = Color.DeepSkyBlue;
            btnSix.FlatStyle = FlatStyle.Flat;
            btnSix.Font = new Font("Arial", 48F);
            btnSix.ForeColor = Color.FloralWhite;
            btnSix.Location = new Point(407, 265);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(151, 101);
            btnSix.TabIndex = 8;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = false;
            btnSix.Click += NumberButton_Click;
            // 
            // btnFive
            // 
            btnFive.BackColor = Color.DeepSkyBlue;
            btnFive.FlatStyle = FlatStyle.Flat;
            btnFive.Font = new Font("Arial", 48F);
            btnFive.ForeColor = Color.FloralWhite;
            btnFive.Location = new Point(218, 265);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(151, 101);
            btnFive.TabIndex = 7;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = false;
            btnFive.Click += NumberButton_Click;
            // 
            // btnFour
            // 
            btnFour.BackColor = Color.DeepSkyBlue;
            btnFour.FlatStyle = FlatStyle.Flat;
            btnFour.Font = new Font("Arial", 48F);
            btnFour.ForeColor = Color.FloralWhite;
            btnFour.Location = new Point(31, 265);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(151, 101);
            btnFour.TabIndex = 6;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = false;
            btnFour.Click += NumberButton_Click;
            // 
            // btnNine
            // 
            btnNine.BackColor = Color.DeepSkyBlue;
            btnNine.FlatStyle = FlatStyle.Flat;
            btnNine.Font = new Font("Arial", 48F);
            btnNine.ForeColor = Color.FloralWhite;
            btnNine.Location = new Point(407, 141);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(151, 101);
            btnNine.TabIndex = 5;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = false;
            btnNine.Click += NumberButton_Click;
            // 
            // btnEight
            // 
            btnEight.BackColor = Color.DeepSkyBlue;
            btnEight.FlatStyle = FlatStyle.Flat;
            btnEight.Font = new Font("Arial", 48F);
            btnEight.ForeColor = Color.FloralWhite;
            btnEight.Location = new Point(218, 141);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(151, 101);
            btnEight.TabIndex = 4;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = false;
            btnEight.Click += NumberButton_Click;
            // 
            // btnSeven
            // 
            btnSeven.BackColor = Color.DeepSkyBlue;
            btnSeven.FlatStyle = FlatStyle.Flat;
            btnSeven.Font = new Font("Arial", 48F);
            btnSeven.ForeColor = Color.FloralWhite;
            btnSeven.Location = new Point(31, 141);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(151, 101);
            btnSeven.TabIndex = 3;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = false;
            btnSeven.Click += NumberButton_Click;
            // 
            // btnAC
            // 
            btnAC.BackColor = Color.FromArgb(255, 128, 0);
            btnAC.BackgroundImageLayout = ImageLayout.Center;
            btnAC.FlatStyle = FlatStyle.Popup;
            btnAC.Font = new Font("Corbel", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAC.ForeColor = SystemColors.ControlLightLight;
            btnAC.Location = new Point(928, 129);
            btnAC.Name = "btnAC";
            btnAC.Size = new Size(125, 90);
            btnAC.TabIndex = 2;
            btnAC.Text = "AC";
            btnAC.UseVisualStyleBackColor = false;
            btnAC.Click += btnAC_Click;
            // 
            // btnCalcOnOff
            // 
            btnCalcOnOff.BackColor = Color.Red;
            btnCalcOnOff.BackgroundImage = (Image)resources.GetObject("btnCalcOnOff.BackgroundImage");
            btnCalcOnOff.BackgroundImageLayout = ImageLayout.Center;
            btnCalcOnOff.FlatStyle = FlatStyle.Popup;
            btnCalcOnOff.ForeColor = SystemColors.ControlLightLight;
            btnCalcOnOff.Location = new Point(928, 20);
            btnCalcOnOff.Name = "btnCalcOnOff";
            btnCalcOnOff.Size = new Size(125, 90);
            btnCalcOnOff.TabIndex = 1;
            btnCalcOnOff.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(113, 25);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(751, 72);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1095, 652);
            Controls.Add(gpbCalcMain);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            gpbCalcMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpbCalcMain;
        private RichTextBox richTextBox1;
        private Button btnCalcOnOff;
        private Button btnAC;
        private Button btnSeven;
        private Button btnZero;
        private Button btnThree;
        private Button btnTwo;
        private Button btnOne;
        private Button btnSix;
        private Button btnFive;
        private Button btnFour;
        private Button btnNine;
        private Button btnEight;
        private Button btnMinus;
        private Button btnAdd;
        private Button btnDivide;
        private Button buttonMultiply;
        private Button btnPi;
        private Button btnSquared;
        private Button btnEquals;
        private Button btnDecimal;
        private Button btnDelete;
    }
}