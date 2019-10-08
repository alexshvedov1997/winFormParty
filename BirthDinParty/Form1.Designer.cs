namespace BirthDinParty
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabCrol1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.numberPeople = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.lableCost = new System.Windows.Forms.Label();
            this.fancyDecor = new System.Windows.Forms.CheckBox();
            this.healthBox = new System.Windows.Forms.CheckBox();
            this.costLable = new System.Windows.Forms.Label();
            this.bithdUpDOwn = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.bthFancyDecor = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.brthLableCost = new System.Windows.Forms.Label();
            this.brthCakeWritting = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabCrol1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bithdUpDOwn)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCrol1
            // 
            this.tabCrol1.Controls.Add(this.tabPage1);
            this.tabCrol1.Controls.Add(this.tabPage2);
            this.tabCrol1.Location = new System.Drawing.Point(1, 0);
            this.tabCrol1.Name = "tabCrol1";
            this.tabCrol1.SelectedIndex = 0;
            this.tabCrol1.Size = new System.Drawing.Size(202, 208);
            this.tabCrol1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.numberPeople);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.lableCost);
            this.tabPage1.Controls.Add(this.fancyDecor);
            this.tabPage1.Controls.Add(this.healthBox);
            this.tabPage1.Controls.Add(this.costLable);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(194, 182);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dinner Party";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.brthCakeWritting);
            this.tabPage2.Controls.Add(this.brthLableCost);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.bthFancyDecor);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.bithdUpDOwn);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(194, 182);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Birthday Party";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // numberPeople
            // 
            this.numberPeople.Location = new System.Drawing.Point(11, 28);
            this.numberPeople.Name = "numberPeople";
            this.numberPeople.Size = new System.Drawing.Size(120, 20);
            this.numberPeople.TabIndex = 13;
            this.numberPeople.ValueChanged += new System.EventHandler(this.numberPeople_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Number of people";
            // 
            // lableCost
            // 
            this.lableCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lableCost.Location = new System.Drawing.Point(42, 133);
            this.lableCost.Name = "lableCost";
            this.lableCost.Size = new System.Drawing.Size(100, 23);
            this.lableCost.TabIndex = 11;
            // 
            // fancyDecor
            // 
            this.fancyDecor.AutoSize = true;
            this.fancyDecor.Location = new System.Drawing.Point(11, 65);
            this.fancyDecor.Name = "fancyDecor";
            this.fancyDecor.Size = new System.Drawing.Size(115, 17);
            this.fancyDecor.TabIndex = 10;
            this.fancyDecor.Text = "Fancy Decorations";
            this.fancyDecor.UseVisualStyleBackColor = true;
            this.fancyDecor.CheckedChanged += new System.EventHandler(this.fancyDecor_CheckedChanged);
            // 
            // healthBox
            // 
            this.healthBox.AutoSize = true;
            this.healthBox.Location = new System.Drawing.Point(11, 97);
            this.healthBox.Name = "healthBox";
            this.healthBox.Size = new System.Drawing.Size(122, 17);
            this.healthBox.TabIndex = 9;
            this.healthBox.Text = "Healthy Decorations";
            this.healthBox.UseVisualStyleBackColor = true;
            this.healthBox.CheckedChanged += new System.EventHandler(this.healthBox_CheckedChanged);
            // 
            // costLable
            // 
            this.costLable.AutoSize = true;
            this.costLable.Location = new System.Drawing.Point(8, 133);
            this.costLable.Name = "costLable";
            this.costLable.Size = new System.Drawing.Size(28, 13);
            this.costLable.TabIndex = 8;
            this.costLable.Text = "Cost";
            // 
            // bithdUpDOwn
            // 
            this.bithdUpDOwn.Location = new System.Drawing.Point(11, 28);
            this.bithdUpDOwn.Name = "bithdUpDOwn";
            this.bithdUpDOwn.Size = new System.Drawing.Size(120, 20);
            this.bithdUpDOwn.TabIndex = 0;
            this.bithdUpDOwn.ValueChanged += new System.EventHandler(this.bithdUpDOwn_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of people";
            // 
            // bthFancyDecor
            // 
            this.bthFancyDecor.AutoSize = true;
            this.bthFancyDecor.Location = new System.Drawing.Point(11, 65);
            this.bthFancyDecor.Name = "bthFancyDecor";
            this.bthFancyDecor.Size = new System.Drawing.Size(110, 17);
            this.bthFancyDecor.TabIndex = 2;
            this.bthFancyDecor.Text = "Fancy Decoration";
            this.bthFancyDecor.UseVisualStyleBackColor = true;
            this.bthFancyDecor.CheckedChanged += new System.EventHandler(this.bthFancyDecor_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cost";
            // 
            // brthLableCost
            // 
            this.brthLableCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.brthLableCost.Location = new System.Drawing.Point(42, 133);
            this.brthLableCost.Name = "brthLableCost";
            this.brthLableCost.Size = new System.Drawing.Size(100, 23);
            this.brthLableCost.TabIndex = 4;
            // 
            // brthCakeWritting
            // 
            this.brthCakeWritting.Location = new System.Drawing.Point(11, 99);
            this.brthCakeWritting.Name = "brthCakeWritting";
            this.brthCakeWritting.Size = new System.Drawing.Size(131, 20);
            this.brthCakeWritting.TabIndex = 5;
            this.brthCakeWritting.TextChanged += new System.EventHandler(this.brthCakeWritting_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cake Writting";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 206);
            this.Controls.Add(this.tabCrol1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabCrol1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bithdUpDOwn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCrol1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown numberPeople;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lableCost;
        private System.Windows.Forms.CheckBox fancyDecor;
        private System.Windows.Forms.CheckBox healthBox;
        private System.Windows.Forms.Label costLable;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox brthCakeWritting;
        private System.Windows.Forms.Label brthLableCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox bthFancyDecor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown bithdUpDOwn;
    }
}

