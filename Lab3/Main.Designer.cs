namespace Lab3
{
    partial class Main
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.roleContainer3 = new Lab3.roleContainer();
            this.roleContainer2 = new Lab3.roleContainer();
            this.roleContainer1 = new Lab3.roleContainer();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1053, 576);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "保存游戏进度";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1053, 621);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 33);
            this.button2.TabIndex = 5;
            this.button2.Text = "回到主菜单";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // roleContainer3
            // 
            this.roleContainer3.Location = new System.Drawing.Point(79, 376);
            this.roleContainer3.Name = "roleContainer3";
            this.roleContainer3.RedSize = 162;
            this.roleContainer3.Size = new System.Drawing.Size(163, 253);
            this.roleContainer3.TabIndex = 3;
            this.roleContainer3.Click += new System.EventHandler(this.roleContainer3_Click);
            // 
            // roleContainer2
            // 
            this.roleContainer2.Location = new System.Drawing.Point(839, 86);
            this.roleContainer2.Name = "roleContainer2";
            this.roleContainer2.RedSize = 162;
            this.roleContainer2.Size = new System.Drawing.Size(165, 252);
            this.roleContainer2.TabIndex = 1;
            this.roleContainer2.Click += new System.EventHandler(this.roleContainer2_Click);
            // 
            // roleContainer1
            // 
            this.roleContainer1.Location = new System.Drawing.Point(79, 86);
            this.roleContainer1.Name = "roleContainer1";
            this.roleContainer1.RedSize = 162;
            this.roleContainer1.Size = new System.Drawing.Size(163, 252);
            this.roleContainer1.TabIndex = 0;
            this.roleContainer1.Click += new System.EventHandler(this.roleContainer1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 666);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.roleContainer3);
            this.Controls.Add(this.roleContainer2);
            this.Controls.Add(this.roleContainer1);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "开始游戏";
            this.Load += new System.EventHandler(this.Main_load);
            this.ResumeLayout(false);

        }

        #endregion

        private roleContainer roleContainer1;
        private roleContainer roleContainer2;
        private roleContainer roleContainer3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

