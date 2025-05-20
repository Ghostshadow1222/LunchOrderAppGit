namespace LunchOrderAppGit
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
            MainCourseGrp = new GroupBox();
            HamburgerGrp = new GroupBox();
            OrderTotalGrp = new GroupBox();
            OrderBtn = new Button();
            ExitBtn = new Button();
            PizzaGrp = new GroupBox();
            SaladGrp = new GroupBox();
            HamburgerRdo = new RadioButton();
            PizzaRdo = new RadioButton();
            SaladRdo = new RadioButton();
            HamburgerSide1Cbo = new CheckBox();
            HamburgerSide2Cbo = new CheckBox();
            HamburgerSide3Cbo = new CheckBox();
            PizzaSide1Cbo = new CheckBox();
            PizzaSide2Cbo = new CheckBox();
            PizzaSide3Cbo = new CheckBox();
            SaladSide1Cbo = new CheckBox();
            SaladSide2Cbo = new CheckBox();
            SaladSide3Cbo = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SubtotalTxt = new TextBox();
            TaxTxt = new TextBox();
            OrderTotalTxt = new TextBox();
            MainCourseGrp.SuspendLayout();
            HamburgerGrp.SuspendLayout();
            OrderTotalGrp.SuspendLayout();
            PizzaGrp.SuspendLayout();
            SaladGrp.SuspendLayout();
            SuspendLayout();
            // 
            // MainCourseGrp
            // 
            MainCourseGrp.Controls.Add(SaladRdo);
            MainCourseGrp.Controls.Add(PizzaRdo);
            MainCourseGrp.Controls.Add(HamburgerRdo);
            MainCourseGrp.Location = new Point(12, 12);
            MainCourseGrp.Name = "MainCourseGrp";
            MainCourseGrp.Size = new Size(200, 100);
            MainCourseGrp.TabIndex = 0;
            MainCourseGrp.TabStop = false;
            MainCourseGrp.Text = "Main Course";
            // 
            // HamburgerGrp
            // 
            HamburgerGrp.Controls.Add(HamburgerSide3Cbo);
            HamburgerGrp.Controls.Add(HamburgerSide2Cbo);
            HamburgerGrp.Controls.Add(HamburgerSide1Cbo);
            HamburgerGrp.Location = new Point(218, 12);
            HamburgerGrp.Name = "HamburgerGrp";
            HamburgerGrp.Size = new Size(200, 100);
            HamburgerGrp.TabIndex = 1;
            HamburgerGrp.TabStop = false;
            HamburgerGrp.Text = "Add-on items ($.75/each)";
            // 
            // OrderTotalGrp
            // 
            OrderTotalGrp.Controls.Add(OrderTotalTxt);
            OrderTotalGrp.Controls.Add(TaxTxt);
            OrderTotalGrp.Controls.Add(SubtotalTxt);
            OrderTotalGrp.Controls.Add(label3);
            OrderTotalGrp.Controls.Add(label2);
            OrderTotalGrp.Controls.Add(label1);
            OrderTotalGrp.Location = new Point(12, 118);
            OrderTotalGrp.Name = "OrderTotalGrp";
            OrderTotalGrp.Size = new Size(240, 118);
            OrderTotalGrp.TabIndex = 2;
            OrderTotalGrp.TabStop = false;
            OrderTotalGrp.Text = "groupBox3";
            // 
            // OrderBtn
            // 
            OrderBtn.Location = new Point(315, 127);
            OrderBtn.Name = "OrderBtn";
            OrderBtn.Size = new Size(103, 31);
            OrderBtn.TabIndex = 3;
            OrderBtn.Text = "Place Order";
            OrderBtn.UseVisualStyleBackColor = true;
            OrderBtn.Click += OrderBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(315, 192);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(103, 33);
            ExitBtn.TabIndex = 4;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // PizzaGrp
            // 
            PizzaGrp.Controls.Add(PizzaSide3Cbo);
            PizzaGrp.Controls.Add(PizzaSide2Cbo);
            PizzaGrp.Controls.Add(PizzaSide1Cbo);
            PizzaGrp.Location = new Point(424, 12);
            PizzaGrp.Name = "PizzaGrp";
            PizzaGrp.Size = new Size(200, 100);
            PizzaGrp.TabIndex = 5;
            PizzaGrp.TabStop = false;
            PizzaGrp.Text = "Add-on items ($.50/each)";
            // 
            // SaladGrp
            // 
            SaladGrp.Controls.Add(SaladSide3Cbo);
            SaladGrp.Controls.Add(SaladSide2Cbo);
            SaladGrp.Controls.Add(SaladSide1Cbo);
            SaladGrp.Location = new Point(630, 12);
            SaladGrp.Name = "SaladGrp";
            SaladGrp.Size = new Size(200, 100);
            SaladGrp.TabIndex = 6;
            SaladGrp.TabStop = false;
            SaladGrp.Text = "Add-on items ($.25/each)";
            // 
            // HamburgerRdo
            // 
            HamburgerRdo.AutoSize = true;
            HamburgerRdo.Location = new Point(6, 22);
            HamburgerRdo.Name = "HamburgerRdo";
            HamburgerRdo.Size = new Size(124, 19);
            HamburgerRdo.TabIndex = 0;
            HamburgerRdo.TabStop = true;
            HamburgerRdo.Text = "Hamburger - $6.95";
            HamburgerRdo.UseVisualStyleBackColor = true;
            // 
            // PizzaRdo
            // 
            PizzaRdo.AutoSize = true;
            PizzaRdo.Location = new Point(6, 47);
            PizzaRdo.Name = "PizzaRdo";
            PizzaRdo.Size = new Size(89, 19);
            PizzaRdo.TabIndex = 1;
            PizzaRdo.TabStop = true;
            PizzaRdo.Text = "Pizza - $5.95";
            PizzaRdo.UseVisualStyleBackColor = true;
            // 
            // SaladRdo
            // 
            SaladRdo.AutoSize = true;
            SaladRdo.Location = new Point(6, 72);
            SaladRdo.Name = "SaladRdo";
            SaladRdo.Size = new Size(91, 19);
            SaladRdo.TabIndex = 2;
            SaladRdo.TabStop = true;
            SaladRdo.Text = "Salad - $4.95";
            SaladRdo.UseVisualStyleBackColor = true;
            // 
            // HamburgerSide1Cbo
            // 
            HamburgerSide1Cbo.AutoSize = true;
            HamburgerSide1Cbo.Location = new Point(6, 23);
            HamburgerSide1Cbo.Name = "HamburgerSide1Cbo";
            HamburgerSide1Cbo.Size = new Size(175, 19);
            HamburgerSide1Cbo.TabIndex = 0;
            HamburgerSide1Cbo.Text = "Lettuce, tomato, and onions";
            HamburgerSide1Cbo.UseVisualStyleBackColor = true;
            // 
            // HamburgerSide2Cbo
            // 
            HamburgerSide2Cbo.AutoSize = true;
            HamburgerSide2Cbo.Location = new Point(6, 48);
            HamburgerSide2Cbo.Name = "HamburgerSide2Cbo";
            HamburgerSide2Cbo.Size = new Size(179, 19);
            HamburgerSide2Cbo.TabIndex = 1;
            HamburgerSide2Cbo.Text = "Ketchup, mustard, and mayo";
            HamburgerSide2Cbo.UseVisualStyleBackColor = true;
            // 
            // HamburgerSide3Cbo
            // 
            HamburgerSide3Cbo.AutoSize = true;
            HamburgerSide3Cbo.Location = new Point(6, 73);
            HamburgerSide3Cbo.Name = "HamburgerSide3Cbo";
            HamburgerSide3Cbo.Size = new Size(89, 19);
            HamburgerSide3Cbo.TabIndex = 2;
            HamburgerSide3Cbo.Text = "French Fries";
            HamburgerSide3Cbo.UseVisualStyleBackColor = true;
            // 
            // PizzaSide1Cbo
            // 
            PizzaSide1Cbo.AutoSize = true;
            PizzaSide1Cbo.Location = new Point(6, 23);
            PizzaSide1Cbo.Name = "PizzaSide1Cbo";
            PizzaSide1Cbo.Size = new Size(80, 19);
            PizzaSide1Cbo.TabIndex = 0;
            PizzaSide1Cbo.Text = "Pepperoni";
            PizzaSide1Cbo.UseVisualStyleBackColor = true;
            // 
            // PizzaSide2Cbo
            // 
            PizzaSide2Cbo.AutoSize = true;
            PizzaSide2Cbo.Location = new Point(6, 48);
            PizzaSide2Cbo.Name = "PizzaSide2Cbo";
            PizzaSide2Cbo.Size = new Size(69, 19);
            PizzaSide2Cbo.TabIndex = 1;
            PizzaSide2Cbo.Text = "Sausage";
            PizzaSide2Cbo.UseVisualStyleBackColor = true;
            // 
            // PizzaSide3Cbo
            // 
            PizzaSide3Cbo.AutoSize = true;
            PizzaSide3Cbo.Location = new Point(6, 73);
            PizzaSide3Cbo.Name = "PizzaSide3Cbo";
            PizzaSide3Cbo.Size = new Size(58, 19);
            PizzaSide3Cbo.TabIndex = 2;
            PizzaSide3Cbo.Text = "Olives";
            PizzaSide3Cbo.UseVisualStyleBackColor = true;
            // 
            // SaladSide1Cbo
            // 
            SaladSide1Cbo.AutoSize = true;
            SaladSide1Cbo.Location = new Point(6, 22);
            SaladSide1Cbo.Name = "SaladSide1Cbo";
            SaladSide1Cbo.Size = new Size(75, 19);
            SaladSide1Cbo.TabIndex = 3;
            SaladSide1Cbo.Text = "Croutons";
            SaladSide1Cbo.UseVisualStyleBackColor = true;
            // 
            // SaladSide2Cbo
            // 
            SaladSide2Cbo.AutoSize = true;
            SaladSide2Cbo.Location = new Point(6, 47);
            SaladSide2Cbo.Name = "SaladSide2Cbo";
            SaladSide2Cbo.Size = new Size(81, 19);
            SaladSide2Cbo.TabIndex = 4;
            SaladSide2Cbo.Text = "Bacon bits";
            SaladSide2Cbo.UseVisualStyleBackColor = true;
            // 
            // SaladSide3Cbo
            // 
            SaladSide3Cbo.AutoSize = true;
            SaladSide3Cbo.Location = new Point(6, 72);
            SaladSide3Cbo.Name = "SaladSide3Cbo";
            SaladSide3Cbo.Size = new Size(88, 19);
            SaladSide3Cbo.TabIndex = 5;
            SaladSide3Cbo.Text = "Bread sticks";
            SaladSide3Cbo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 25);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Subtotal:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 54);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 1;
            label2.Text = "Tax (7.75%):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 83);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 2;
            label3.Text = "Order Total:";
            // 
            // SubtotalTxt
            // 
            SubtotalTxt.Location = new Point(100, 22);
            SubtotalTxt.Name = "SubtotalTxt";
            SubtotalTxt.ReadOnly = true;
            SubtotalTxt.Size = new Size(100, 23);
            SubtotalTxt.TabIndex = 3;
            // 
            // TaxTxt
            // 
            TaxTxt.Location = new Point(100, 51);
            TaxTxt.Name = "TaxTxt";
            TaxTxt.ReadOnly = true;
            TaxTxt.Size = new Size(100, 23);
            TaxTxt.TabIndex = 4;
            // 
            // OrderTotalTxt
            // 
            OrderTotalTxt.Location = new Point(100, 80);
            OrderTotalTxt.Name = "OrderTotalTxt";
            OrderTotalTxt.ReadOnly = true;
            OrderTotalTxt.Size = new Size(100, 23);
            OrderTotalTxt.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 303);
            Controls.Add(SaladGrp);
            Controls.Add(PizzaGrp);
            Controls.Add(ExitBtn);
            Controls.Add(OrderBtn);
            Controls.Add(OrderTotalGrp);
            Controls.Add(HamburgerGrp);
            Controls.Add(MainCourseGrp);
            Name = "Form1";
            Text = "Form1";
            MainCourseGrp.ResumeLayout(false);
            MainCourseGrp.PerformLayout();
            HamburgerGrp.ResumeLayout(false);
            HamburgerGrp.PerformLayout();
            OrderTotalGrp.ResumeLayout(false);
            OrderTotalGrp.PerformLayout();
            PizzaGrp.ResumeLayout(false);
            PizzaGrp.PerformLayout();
            SaladGrp.ResumeLayout(false);
            SaladGrp.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox MainCourseGrp;
        private GroupBox HamburgerGrp;
        private GroupBox OrderTotalGrp;
        private Button OrderBtn;
        private Button ExitBtn;
        private RadioButton SaladRdo;
        private RadioButton PizzaRdo;
        private RadioButton HamburgerRdo;
        private CheckBox HamburgerSide3Cbo;
        private CheckBox HamburgerSide2Cbo;
        private CheckBox HamburgerSide1Cbo;
        private TextBox OrderTotalTxt;
        private TextBox TaxTxt;
        private TextBox SubtotalTxt;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox PizzaGrp;
        private CheckBox PizzaSide3Cbo;
        private CheckBox PizzaSide2Cbo;
        private CheckBox PizzaSide1Cbo;
        private GroupBox SaladGrp;
        private CheckBox SaladSide3Cbo;
        private CheckBox SaladSide2Cbo;
        private CheckBox SaladSide1Cbo;
    }
}
