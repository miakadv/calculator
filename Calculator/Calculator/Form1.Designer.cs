namespace Calculator
{
    partial class label
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
            this.CE = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.eq = new System.Windows.Forms.Button();
            this.text_box = new System.Windows.Forms.TextBox();
            this.label_operation = new System.Windows.Forms.Label();
            this.label_operator = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CE
            // 
            this.CE.BackColor = System.Drawing.Color.LightCoral;
            this.CE.Font = new System.Drawing.Font("Yu Gothic Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CE.Location = new System.Drawing.Point(12, 94);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(124, 61);
            this.CE.TabIndex = 0;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = false;
            this.CE.Click += new System.EventHandler(this.clearEntry_operator);
            // 
            // C
            // 
            this.C.BackColor = System.Drawing.Color.LightCoral;
            this.C.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.C.Location = new System.Drawing.Point(142, 94);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(107, 61);
            this.C.TabIndex = 1;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = false;
            this.C.Click += new System.EventHandler(this.clear_operator);
            // 
            // div
            // 
            this.div.BackColor = System.Drawing.Color.LightCoral;
            this.div.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.div.Location = new System.Drawing.Point(255, 94);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(75, 61);
            this.div.TabIndex = 3;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = false;
            this.div.Click += new System.EventHandler(this.click_operator);
            // 
            // num7
            // 
            this.num7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.num7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.num7.Location = new System.Drawing.Point(12, 161);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(75, 61);
            this.num7.TabIndex = 4;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = false;
            this.num7.Click += new System.EventHandler(this.click_button);
            // 
            // num8
            // 
            this.num8.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.num8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8.Location = new System.Drawing.Point(93, 161);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(75, 61);
            this.num8.TabIndex = 5;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = false;
            this.num8.Click += new System.EventHandler(this.click_button);
            // 
            // num9
            // 
            this.num9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.num9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.num9.Location = new System.Drawing.Point(174, 161);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(75, 61);
            this.num9.TabIndex = 6;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = false;
            this.num9.Click += new System.EventHandler(this.click_button);
            // 
            // mult
            // 
            this.mult.BackColor = System.Drawing.Color.LightCoral;
            this.mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.mult.Location = new System.Drawing.Point(255, 161);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(75, 61);
            this.mult.TabIndex = 7;
            this.mult.Text = "*";
            this.mult.UseVisualStyleBackColor = false;
            this.mult.Click += new System.EventHandler(this.click_operator);
            // 
            // num4
            // 
            this.num4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.num4.Location = new System.Drawing.Point(12, 228);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(75, 61);
            this.num4.TabIndex = 8;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = false;
            this.num4.Click += new System.EventHandler(this.click_button);
            // 
            // num5
            // 
            this.num5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.num5.Location = new System.Drawing.Point(93, 228);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(75, 61);
            this.num5.TabIndex = 9;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = false;
            this.num5.Click += new System.EventHandler(this.click_button);
            // 
            // num6
            // 
            this.num6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.num6.Location = new System.Drawing.Point(174, 228);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(75, 61);
            this.num6.TabIndex = 10;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = false;
            this.num6.Click += new System.EventHandler(this.click_button);
            // 
            // sub
            // 
            this.sub.BackColor = System.Drawing.Color.LightCoral;
            this.sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.sub.Location = new System.Drawing.Point(255, 228);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(75, 61);
            this.sub.TabIndex = 11;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = false;
            this.sub.Click += new System.EventHandler(this.click_operator);
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.num1.Location = new System.Drawing.Point(12, 295);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(75, 61);
            this.num1.TabIndex = 12;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = false;
            this.num1.Click += new System.EventHandler(this.click_button);
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.num2.Location = new System.Drawing.Point(93, 295);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(75, 61);
            this.num2.TabIndex = 13;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = false;
            this.num2.Click += new System.EventHandler(this.click_button);
            // 
            // num3
            // 
            this.num3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.num3.Location = new System.Drawing.Point(174, 295);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(75, 61);
            this.num3.TabIndex = 14;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = false;
            this.num3.Click += new System.EventHandler(this.click_button);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.LightCoral;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.add.Location = new System.Drawing.Point(255, 295);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 61);
            this.add.TabIndex = 15;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.click_operator);
            // 
            // num0
            // 
            this.num0.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.num0.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.num0.Location = new System.Drawing.Point(93, 362);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(70, 61);
            this.num0.TabIndex = 17;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = false;
            this.num0.Click += new System.EventHandler(this.click_button);
            // 
            // point
            // 
            this.point.BackColor = System.Drawing.Color.LightCoral;
            this.point.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.point.Location = new System.Drawing.Point(12, 362);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(75, 61);
            this.point.TabIndex = 18;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = false;
            this.point.Click += new System.EventHandler(this.click_button);
            // 
            // eq
            // 
            this.eq.BackColor = System.Drawing.Color.LightCoral;
            this.eq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.eq.Location = new System.Drawing.Point(174, 362);
            this.eq.Name = "eq";
            this.eq.Size = new System.Drawing.Size(156, 61);
            this.eq.TabIndex = 19;
            this.eq.Text = "=";
            this.eq.UseVisualStyleBackColor = false;
            this.eq.Click += new System.EventHandler(this.equal_operator);
            // 
            // text_box
            // 
            this.text_box.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.text_box.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_box.Location = new System.Drawing.Point(12, 45);
            this.text_box.Name = "text_box";
            this.text_box.Size = new System.Drawing.Size(318, 43);
            this.text_box.TabIndex = 20;
            this.text_box.Text = "0";
            this.text_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_operation
            // 
            this.label_operation.AutoSize = true;
            this.label_operation.Location = new System.Drawing.Point(12, 9);
            this.label_operation.Name = "label_operation";
            this.label_operation.Size = new System.Drawing.Size(0, 17);
            this.label_operation.TabIndex = 21;
            // 
            // label_operator
            // 
            this.label_operator.AutoSize = true;
            this.label_operator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_operator.Location = new System.Drawing.Point(12, 17);
            this.label_operator.Name = "label_operator";
            this.label_operator.Size = new System.Drawing.Size(0, 25);
            this.label_operator.TabIndex = 22;
            // 
            // label
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(339, 433);
            this.Controls.Add(this.label_operator);
            this.Controls.Add(this.label_operation);
            this.Controls.Add(this.text_box);
            this.Controls.Add(this.eq);
            this.Controls.Add(this.point);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.add);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.div);
            this.Controls.Add(this.C);
            this.Controls.Add(this.CE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "label";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CE;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button eq;
        private System.Windows.Forms.TextBox text_box;
        private System.Windows.Forms.Label label_operation;
        private System.Windows.Forms.Label label_operator;
    }
}

