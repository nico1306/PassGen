namespace PassGen
{
    partial class PassGen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassGen));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            pwd = new TextBox();
            label3 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(140, 15);
            label1.TabIndex = 0;
            label1.Text = "PasswordGen by Nico136";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "Length:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            textBox1.Text = "30";
            // 
            // button1
            // 
            button1.Location = new Point(8, 98);
            button1.Name = "button1";
            button1.Size = new Size(144, 23);
            button1.TabIndex = 3;
            button1.Text = "Generate and copy";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pwd
            // 
            pwd.Location = new Point(12, 156);
            pwd.Name = "pwd";
            pwd.Size = new Size(353, 23);
            pwd.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 138);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 5;
            label3.Text = "Password:";
            // 
            // button2
            // 
            button2.Location = new Point(191, 98);
            button2.Name = "button2";
            button2.Size = new Size(137, 23);
            button2.TabIndex = 6;
            button2.Text = "Auto Tap";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // PassGen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 196);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(pwd);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PassGen";
            Text = "PassGen by Nico136";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private TextBox pwd;
        private Label label3;
        private Button button2;
    }
}