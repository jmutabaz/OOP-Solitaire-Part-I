namespace WindowsFormsApplication2
{
    partial class CalculationGame
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculationGame));
      this.foundation4 = new System.Windows.Forms.PictureBox();
      this.foundation2 = new System.Windows.Forms.PictureBox();
      this.foundation3 = new System.Windows.Forms.PictureBox();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.Rules_Game = new System.Windows.Forms.Button();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
      this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
      this.aboutGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.DeckButton = new System.Windows.Forms.Button();
      this.foundation1 = new System.Windows.Forms.PictureBox();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.button1 = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.panel3 = new System.Windows.Forms.Panel();
      this.panel4 = new System.Windows.Forms.Panel();
      this.wastePilePicture = new System.Windows.Forms.Panel();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.textBox4 = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.foundation4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.foundation2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.foundation3)).BeginInit();
      this.toolStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.foundation1)).BeginInit();
      this.SuspendLayout();
      // 
      // foundation4
      // 
      this.foundation4.Location = new System.Drawing.Point(634, 115);
      this.foundation4.Margin = new System.Windows.Forms.Padding(2);
      this.foundation4.Name = "foundation4";
      this.foundation4.Size = new System.Drawing.Size(71, 96);
      this.foundation4.TabIndex = 17;
      this.foundation4.TabStop = false;
      // 
      // foundation2
      // 
      this.foundation2.Location = new System.Drawing.Point(378, 115);
      this.foundation2.Margin = new System.Windows.Forms.Padding(2);
      this.foundation2.Name = "foundation2";
      this.foundation2.Size = new System.Drawing.Size(71, 96);
      this.foundation2.TabIndex = 15;
      this.foundation2.TabStop = false;
      // 
      // foundation3
      // 
      this.foundation3.Location = new System.Drawing.Point(501, 115);
      this.foundation3.Margin = new System.Windows.Forms.Padding(2);
      this.foundation3.Name = "foundation3";
      this.foundation3.Size = new System.Drawing.Size(71, 96);
      this.foundation3.TabIndex = 13;
      this.foundation3.TabStop = false;
      // 
      // timer1
      // 
      this.timer1.Enabled = true;
      this.timer1.Interval = 1000;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // Rules_Game
      // 
      this.Rules_Game.Location = new System.Drawing.Point(642, 51);
      this.Rules_Game.Margin = new System.Windows.Forms.Padding(2);
      this.Rules_Game.Name = "Rules_Game";
      this.Rules_Game.Size = new System.Drawing.Size(86, 39);
      this.Rules_Game.TabIndex = 20;
      this.Rules_Game.Text = "Rules";
      this.Rules_Game.UseVisualStyleBackColor = true;
      this.Rules_Game.Click += new System.EventHandler(this.btnRules_onClick);
      // 
      // toolStrip1
      // 
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
      this.toolStrip1.Location = new System.Drawing.Point(0, 24);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(746, 25);
      this.toolStrip1.TabIndex = 21;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // toolStripDropDownButton1
      // 
      this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.exitToolStripMenuItem});
      this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
      this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
      this.toolStripDropDownButton1.Size = new System.Drawing.Size(51, 22);
      this.toolStripDropDownButton1.Text = "Game";
      // 
      // newGameToolStripMenuItem
      // 
      this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
      this.newGameToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
      this.newGameToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
      this.newGameToolStripMenuItem.Text = "New Game";
      // 
      // optionsToolStripMenuItem
      // 
      this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
      this.optionsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
      this.optionsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
      this.optionsToolStripMenuItem.Text = "Options";
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Enabled = false;
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.ShortcutKeyDisplayString = "";
      this.exitToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
      this.exitToolStripMenuItem.Text = "Exit";
      // 
      // toolStripDropDownButton2
      // 
      this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutGameToolStripMenuItem,
            this.rulesToolStripMenuItem});
      this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
      this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
      this.toolStripDropDownButton2.Size = new System.Drawing.Size(45, 22);
      this.toolStripDropDownButton2.Text = "Help";
      // 
      // aboutGameToolStripMenuItem
      // 
      this.aboutGameToolStripMenuItem.Name = "aboutGameToolStripMenuItem";
      this.aboutGameToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
      this.aboutGameToolStripMenuItem.Text = "About Game";
      // 
      // rulesToolStripMenuItem
      // 
      this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
      this.rulesToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
      this.rulesToolStripMenuItem.Text = "Rules";
      // 
      // DeckButton
      // 
      this.DeckButton.Image = ((System.Drawing.Image)(resources.GetObject("DeckButton.Image")));
      this.DeckButton.Location = new System.Drawing.Point(12, 109);
      this.DeckButton.Name = "DeckButton";
      this.DeckButton.Size = new System.Drawing.Size(75, 102);
      this.DeckButton.TabIndex = 22;
      this.DeckButton.UseVisualStyleBackColor = true;
      this.DeckButton.Click += new System.EventHandler(this.btnDeck_Click);
      // 
      // foundation1
      // 
      this.foundation1.Location = new System.Drawing.Point(259, 115);
      this.foundation1.Name = "foundation1";
      this.foundation1.Size = new System.Drawing.Size(71, 96);
      this.foundation1.TabIndex = 24;
      this.foundation1.TabStop = false;
      // 
      // menuStrip1
      // 
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(746, 24);
      this.menuStrip1.TabIndex = 29;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(543, 51);
      this.button1.Margin = new System.Windows.Forms.Padding(2);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(86, 39);
      this.button1.TabIndex = 30;
      this.button1.Text = "Authors";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.btnAuthors_onClick);
      // 
      // panel1
      // 
      this.panel1.AllowDrop = true;
      this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel1.Location = new System.Drawing.Point(259, 278);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(71, 96);
      this.panel1.TabIndex = 31;
      this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
      this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
      // 
      // panel2
      // 
      this.panel2.Location = new System.Drawing.Point(378, 278);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(71, 96);
      this.panel2.TabIndex = 32;
      this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
      // 
      // panel3
      // 
      this.panel3.Location = new System.Drawing.Point(501, 278);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(71, 96);
      this.panel3.TabIndex = 32;
      this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
      // 
      // panel4
      // 
      this.panel4.Location = new System.Drawing.Point(634, 278);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(71, 96);
      this.panel4.TabIndex = 33;
      this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown);
      // 
      // wastePilePicture
      // 
      this.wastePilePicture.AllowDrop = true;
      this.wastePilePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.wastePilePicture.Location = new System.Drawing.Point(124, 115);
      this.wastePilePicture.Name = "wastePilePicture";
      this.wastePilePicture.Size = new System.Drawing.Size(71, 96);
      this.wastePilePicture.TabIndex = 32;
      // 
      // textBox1
      // 
      this.textBox1.Enabled = false;
      this.textBox1.Location = new System.Drawing.Point(259, 229);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(79, 34);
      this.textBox1.TabIndex = 34;
      // 
      // textBox2
      // 
      this.textBox2.Enabled = false;
      this.textBox2.Location = new System.Drawing.Point(378, 229);
      this.textBox2.Multiline = true;
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(71, 34);
      this.textBox2.TabIndex = 35;
      // 
      // textBox3
      // 
      this.textBox3.Enabled = false;
      this.textBox3.Location = new System.Drawing.Point(501, 229);
      this.textBox3.Multiline = true;
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(71, 34);
      this.textBox3.TabIndex = 36;
      // 
      // textBox4
      // 
      this.textBox4.Enabled = false;
      this.textBox4.Location = new System.Drawing.Point(628, 229);
      this.textBox4.Multiline = true;
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new System.Drawing.Size(77, 34);
      this.textBox4.TabIndex = 37;
      // 
      // CalculationGame
      // 
      this.AllowDrop = true;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.ClientSize = new System.Drawing.Size(746, 699);
      this.Controls.Add(this.textBox4);
      this.Controls.Add(this.textBox3);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.wastePilePicture);
      this.Controls.Add(this.panel4);
      this.Controls.Add(this.panel3);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.foundation1);
      this.Controls.Add(this.DeckButton);
      this.Controls.Add(this.toolStrip1);
      this.Controls.Add(this.menuStrip1);
      this.Controls.Add(this.Rules_Game);
      this.Controls.Add(this.foundation4);
      this.Controls.Add(this.foundation2);
      this.Controls.Add(this.foundation3);
      this.HelpButton = true;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(2);
      this.MinimumSize = new System.Drawing.Size(754, 678);
      this.Name = "CalculationGame";
      this.Text = "Calculation Solitaire";
      this.Load += new System.EventHandler(this.CalculationGame_Load);
      ((System.ComponentModel.ISupportInitialize)(this.foundation4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.foundation2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.foundation3)).EndInit();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.foundation1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox foundation4;
        private System.Windows.Forms.PictureBox foundation2;
        private System.Windows.Forms.PictureBox foundation3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Rules_Game;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem aboutGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rulesToolStripMenuItem;
        private System.Windows.Forms.Button DeckButton;
        private System.Windows.Forms.PictureBox foundation1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel wastePilePicture;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}