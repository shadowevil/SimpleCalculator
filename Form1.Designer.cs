namespace Calculator
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
            btnClearAll = new Button();
            btnClearLast = new Button();
            btnDivide = new Button();
            btnMultiply = new Button();
            btnSeven = new Button();
            btnEight = new Button();
            btnNine = new Button();
            btnMinus = new Button();
            btnFour = new Button();
            btnFive = new Button();
            btnSix = new Button();
            btnPlus = new Button();
            btnOne = new Button();
            btnTwo = new Button();
            btnThree = new Button();
            BtnPlusMinus = new Button();
            btnZero = new Button();
            btnDecimal = new Button();
            btnEquals = new Button();
            txtBuffer = new TextBox();
            SuspendLayout();
            // 
            // btnClearAll
            // 
            btnClearAll.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnClearAll.Location = new Point(12, 65);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(50, 50);
            btnClearAll.TabIndex = 0;
            btnClearAll.Text = "CE";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // btnClearLast
            // 
            btnClearLast.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnClearLast.Location = new Point(68, 65);
            btnClearLast.Name = "btnClearLast";
            btnClearLast.Size = new Size(50, 50);
            btnClearLast.TabIndex = 1;
            btnClearLast.Text = "C";
            btnClearLast.UseVisualStyleBackColor = true;
            btnClearLast.Click += btnClearLast_Click;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnDivide.Location = new Point(124, 65);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(50, 50);
            btnDivide.TabIndex = 2;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnMultiply.Location = new Point(180, 65);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(50, 50);
            btnMultiply.TabIndex = 3;
            btnMultiply.Text = "X";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnSeven
            // 
            btnSeven.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnSeven.Location = new Point(12, 121);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(50, 50);
            btnSeven.TabIndex = 4;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = true;
            btnSeven.Click += btnSeven_Click;
            // 
            // btnEight
            // 
            btnEight.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnEight.Location = new Point(68, 121);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(50, 50);
            btnEight.TabIndex = 5;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = true;
            btnEight.Click += btnEight_Click;
            // 
            // btnNine
            // 
            btnNine.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnNine.Location = new Point(124, 121);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(50, 50);
            btnNine.TabIndex = 6;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = true;
            btnNine.Click += btnNine_Click;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnMinus.Location = new Point(180, 121);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(50, 50);
            btnMinus.TabIndex = 7;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnFour
            // 
            btnFour.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnFour.Location = new Point(12, 177);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(50, 50);
            btnFour.TabIndex = 8;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = true;
            btnFour.Click += btnFour_Click;
            // 
            // btnFive
            // 
            btnFive.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnFive.Location = new Point(68, 177);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(50, 50);
            btnFive.TabIndex = 9;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = true;
            btnFive.Click += btnFive_Click;
            // 
            // btnSix
            // 
            btnSix.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnSix.Location = new Point(124, 177);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(50, 50);
            btnSix.TabIndex = 10;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = true;
            btnSix.Click += btnSix_Click;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnPlus.Location = new Point(180, 177);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(50, 50);
            btnPlus.TabIndex = 11;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnOne
            // 
            btnOne.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnOne.Location = new Point(12, 233);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(50, 50);
            btnOne.TabIndex = 12;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = true;
            btnOne.Click += btnOne_Click;
            // 
            // btnTwo
            // 
            btnTwo.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnTwo.Location = new Point(68, 233);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(50, 50);
            btnTwo.TabIndex = 13;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = true;
            btnTwo.Click += btnTwo_Click;
            // 
            // btnThree
            // 
            btnThree.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnThree.Location = new Point(124, 233);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(50, 50);
            btnThree.TabIndex = 14;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = true;
            btnThree.Click += btnThree_Click;
            // 
            // BtnPlusMinus
            // 
            BtnPlusMinus.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            BtnPlusMinus.Location = new Point(12, 289);
            BtnPlusMinus.Name = "BtnPlusMinus";
            BtnPlusMinus.Size = new Size(50, 50);
            BtnPlusMinus.TabIndex = 16;
            BtnPlusMinus.Text = "±";
            BtnPlusMinus.UseVisualStyleBackColor = true;
            BtnPlusMinus.Click += BtnPlusMinus_Click;
            // 
            // btnZero
            // 
            btnZero.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnZero.Location = new Point(68, 289);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(50, 50);
            btnZero.TabIndex = 17;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnDecimal.Location = new Point(124, 289);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(50, 50);
            btnDecimal.TabIndex = 18;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = true;
            btnDecimal.Click += btnDecimal_Click;
            // 
            // btnEquals
            // 
            btnEquals.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnEquals.Location = new Point(180, 233);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(50, 106);
            btnEquals.TabIndex = 0;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // txtBuffer
            // 
            txtBuffer.BorderStyle = BorderStyle.FixedSingle;
            txtBuffer.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuffer.Location = new Point(12, 12);
            txtBuffer.Name = "txtBuffer";
            txtBuffer.Size = new Size(218, 47);
            txtBuffer.TabIndex = 20;
            txtBuffer.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 351);
            Controls.Add(txtBuffer);
            Controls.Add(btnEquals);
            Controls.Add(btnDecimal);
            Controls.Add(btnZero);
            Controls.Add(BtnPlusMinus);
            Controls.Add(btnThree);
            Controls.Add(btnTwo);
            Controls.Add(btnOne);
            Controls.Add(btnPlus);
            Controls.Add(btnSix);
            Controls.Add(btnFive);
            Controls.Add(btnFour);
            Controls.Add(btnMinus);
            Controls.Add(btnNine);
            Controls.Add(btnEight);
            Controls.Add(btnSeven);
            Controls.Add(btnMultiply);
            Controls.Add(btnDivide);
            Controls.Add(btnClearLast);
            Controls.Add(btnClearAll);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(260, 390);
            MinimumSize = new Size(260, 390);
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClearAll;
        private Button btnClearLast;
        private Button btnDivide;
        private Button btnMultiply;
        private Button btnSeven;
        private Button btnEight;
        private Button btnNine;
        private Button btnMinus;
        private Button btnFour;
        private Button btnFive;
        private Button btnSix;
        private Button btnPlus;
        private Button btnOne;
        private Button btnTwo;
        private Button btnThree;
        private Button BtnPlusMinus;
        private Button btnZero;
        private Button btnDecimal;
        private Button btnEquals;
        private TextBox txtBuffer;
    }
}
