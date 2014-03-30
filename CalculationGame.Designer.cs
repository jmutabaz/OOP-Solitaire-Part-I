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
      this.discardPile3 = new System.Windows.Forms.PictureBox();
      this.discardPile4 = new System.Windows.Forms.PictureBox();
      this.foundation4 = new System.Windows.Forms.PictureBox();
      this.discardPile2 = new System.Windows.Forms.PictureBox();
      this.foundation2 = new System.Windows.Forms.PictureBox();
      this.wastePilePicture = new System.Windows.Forms.PictureBox();
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
      this.discardPile1 = new System.Windows.Forms.PictureBox();
      this.foundation1 = new System.Windows.Forms.PictureBox();
      this.hintPile1 = new System.Windows.Forms.PictureBox();
      this.hintPile2 = new System.Windows.Forms.PictureBox();
      this.hintPile3 = new System.Windows.Forms.PictureBox();
      this.hintPile4 = new System.Windows.Forms.PictureBox();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.button1 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.discardPile3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.discardPile4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.foundation4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.discardPile2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.foundation2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.wastePilePicture)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.foundation3)).BeginInit();
      this.toolStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.discardPile1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.foundation1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.hintPile1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.hintPile2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.hintPile3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.hintPile4)).BeginInit();
      this.SuspendLayout();
      // 
      // discardPile3
      // 
      this.discardPile3.Location = new System.Drawing.Point(543, 375);
      this.discardPile3.Margin = new System.Windows.Forms.Padding(2);
      this.discardPile3.Name = "discardPile3";
      this.discardPile3.Size = new System.Drawing.Size(71, 96);
      this.discardPile3.TabIndex = 19;
      this.discardPile3.TabStop = false;
      this.discardPile3.Click += new System.EventHandler(this.discardPile3_onClick);
      // 
      // discardPile4
      // 
      this.discardPile4.Location = new System.Drawing.Point(657, 375);
      this.discardPile4.Margin = new System.Windows.Forms.Padding(2);
      this.discardPile4.Name = "discardPile4";
      this.discardPile4.Size = new System.Drawing.Size(71, 96);
      this.discardPile4.TabIndex = 18;
      this.discardPile4.TabStop = false;
      this.discardPile4.Click += new System.EventHandler(this.discardPile4_onClick);
      // 
      // foundation4
      // 
      this.foundation4.Location = new System.Drawing.Point(657, 109);
      this.foundation4.Margin = new System.Windows.Forms.Padding(2);
      this.foundation4.Name = "foundation4";
      this.foundation4.Size = new System.Drawing.Size(71, 96);
      this.foundation4.TabIndex = 17;
      this.foundation4.TabStop = false;
      this.foundation4.Click += new System.EventHandler(this.btnFoundPile4_Click);
      // 
      // discardPile2
      // 
      this.discardPile2.Location = new System.Drawing.Point(417, 375);
      this.discardPile2.Margin = new System.Windows.Forms.Padding(2);
      this.discardPile2.Name = "discardPile2";
      this.discardPile2.Size = new System.Drawing.Size(71, 96);
      this.discardPile2.TabIndex = 16;
      this.discardPile2.TabStop = false;
      this.discardPile2.Click += new System.EventHandler(this.discardPile2_onClick);
      // 
      // foundation2
      // 
      this.foundation2.Location = new System.Drawing.Point(417, 109);
      this.foundation2.Margin = new System.Windows.Forms.Padding(2);
      this.foundation2.Name = "foundation2";
      this.foundation2.Size = new System.Drawing.Size(71, 96);
      this.foundation2.TabIndex = 15;
      this.foundation2.TabStop = false;
      this.foundation2.Click += new System.EventHandler(this.btnFoundPile2_Click);
      // 
      // wastePilePicture
      // 
      this.wastePilePicture.Location = new System.Drawing.Point(134, 115);
      this.wastePilePicture.Margin = new System.Windows.Forms.Padding(2);
      this.wastePilePicture.Name = "wastePilePicture";
      this.wastePilePicture.Size = new System.Drawing.Size(71, 96);
      this.wastePilePicture.TabIndex = 14;
      this.wastePilePicture.TabStop = false;
      // 
      // foundation3
      // 
      this.foundation3.Location = new System.Drawing.Point(543, 109);
      this.foundation3.Margin = new System.Windows.Forms.Padding(2);
      this.foundation3.Name = "foundation3";
      this.foundation3.Size = new System.Drawing.Size(71, 96);
      this.foundation3.TabIndex = 13;
      this.foundation3.TabStop = false;
      this.foundation3.Click += new System.EventHandler(this.btnFoundPile3_Click);
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
      this.toolStrip1.Size = new System.Drawing.Size(738, 25);
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
      this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
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
      this.toolStripDropDownButton2.Click += new System.EventHandler(this.toolStripDropDownButton2_Click);
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
      // discardPile1
      // 
      this.discardPile1.Location = new System.Drawing.Point(272, 375);
      this.discardPile1.Name = "discardPile1";
      this.discardPile1.Size = new System.Drawing.Size(71, 96);
      this.discardPile1.TabIndex = 23;
      this.discardPile1.TabStop = false;
      this.discardPile1.Click += new System.EventHandler(this.discardPile1_onClick);
      // 
      // foundation1
      // 
      this.foundation1.Location = new System.Drawing.Point(272, 109);
      this.foundation1.Name = "foundation1";
      this.foundation1.Size = new System.Drawing.Size(71, 96);
      this.foundation1.TabIndex = 24;
      this.foundation1.TabStop = false;
      this.foundation1.Click += new System.EventHandler(this.btnFoundPile1_Click_1);
      // 
      // hintPile1
      // 
      this.hintPile1.Location = new System.Drawing.Point(272, 267);
      this.hintPile1.Name = "hintPile1";
      this.hintPile1.Size = new System.Drawing.Size(95, 56);
      this.hintPile1.TabIndex = 25;
      this.hintPile1.TabStop = false;
      this.hintPile1.Click += new System.EventHandler(this.hintPile1_Click);
      // 
      // hintPile2
      // 
      this.hintPile2.Location = new System.Drawing.Point(397, 267);
      this.hintPile2.Name = "hintPile2";
      this.hintPile2.Size = new System.Drawing.Size(91, 56);
      this.hintPile2.TabIndex = 26;
      this.hintPile2.TabStop = false;
      this.hintPile2.Click += new System.EventHandler(this.hintPile2_Click);
      // 
      // hintPile3
      // 
      this.hintPile3.Location = new System.Drawing.Point(523, 267);
      this.hintPile3.Name = "hintPile3";
      this.hintPile3.Size = new System.Drawing.Size(91, 56);
      this.hintPile3.TabIndex = 27;
      this.hintPile3.TabStop = false;
      this.hintPile3.Click += new System.EventHandler(this.hintPile3_Click);
      // 
      // hintPile4
      // 
      this.hintPile4.Location = new System.Drawing.Point(637, 267);
      this.hintPile4.Name = "hintPile4";
      this.hintPile4.Size = new System.Drawing.Size(89, 56);
      this.hintPile4.TabIndex = 28;
      this.hintPile4.TabStop = false;
      this.hintPile4.Click += new System.EventHandler(this.hintPile4_Click);
      // 
      // menuStrip1
      // 
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(738, 24);
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
      // CalculationGame
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.ClientSize = new System.Drawing.Size(738, 699);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.hintPile4);
      this.Controls.Add(this.hintPile3);
      this.Controls.Add(this.hintPile2);
      this.Controls.Add(this.hintPile1);
      this.Controls.Add(this.foundation1);
      this.Controls.Add(this.discardPile1);
      this.Controls.Add(this.DeckButton);
      this.Controls.Add(this.toolStrip1);
      this.Controls.Add(this.menuStrip1);
      this.Controls.Add(this.Rules_Game);
      this.Controls.Add(this.discardPile3);
      this.Controls.Add(this.discardPile4);
      this.Controls.Add(this.foundation4);
      this.Controls.Add(this.discardPile2);
      this.Controls.Add(this.foundation2);
      this.Controls.Add(this.wastePilePicture);
      this.Controls.Add(this.foundation3);
      this.HelpButton = true;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(2);
      this.MinimumSize = new System.Drawing.Size(754, 726);
      this.Name = "CalculationGame";
      this.Text = "Calculation Solitaire";
      this.Load += new System.EventHandler(this.CalculationGame_Load);
      ((System.ComponentModel.ISupportInitialize)(this.discardPile3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.discardPile4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.foundation4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.discardPile2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.foundation2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.wastePilePicture)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.foundation3)).EndInit();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.discardPile1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.foundation1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.hintPile1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.hintPile2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.hintPile3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.hintPile4)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox discardPile3;
        private System.Windows.Forms.PictureBox discardPile4;
        private System.Windows.Forms.PictureBox foundation4;
        private System.Windows.Forms.PictureBox discardPile2;
        private System.Windows.Forms.PictureBox foundation2;
        private System.Windows.Forms.PictureBox wastePilePicture;
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
        private System.Windows.Forms.PictureBox discardPile1;
        private System.Windows.Forms.PictureBox foundation1;
        private System.Windows.Forms.PictureBox hintPile1;
        private System.Windows.Forms.PictureBox hintPile2;
        private System.Windows.Forms.PictureBox hintPile3;
        private System.Windows.Forms.PictureBox hintPile4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button1;
    }
}