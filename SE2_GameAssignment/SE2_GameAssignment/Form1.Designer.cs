namespace SE2_GameAssignment
{
    partial class GameGUI
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
            this.btnStartGame = new System.Windows.Forms.Button();
            this.nudAmountOfEnemies = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.mapPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountOfEnemies)).BeginInit();
            this.mapPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartGame
            // 
            this.btnStartGame.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.Location = new System.Drawing.Point(162, 240);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(152, 23);
            this.btnStartGame.TabIndex = 0;
            this.btnStartGame.Text = "Start game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // nudAmountOfEnemies
            // 
            this.nudAmountOfEnemies.Location = new System.Drawing.Point(162, 135);
            this.nudAmountOfEnemies.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudAmountOfEnemies.Name = "nudAmountOfEnemies";
            this.nudAmountOfEnemies.Size = new System.Drawing.Size(152, 20);
            this.nudAmountOfEnemies.TabIndex = 1;
            this.nudAmountOfEnemies.ValueChanged += new System.EventHandler(this.nudAmountOfEnemies_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select amount of enemies";
            // 
            // mapPanel
            // 
            this.mapPanel.BackgroundImage = global::SE2_GameAssignment.Properties.Resources.laurel_wreath_156019_1280;
            this.mapPanel.Controls.Add(this.label1);
            this.mapPanel.Controls.Add(this.btnStartGame);
            this.mapPanel.Controls.Add(this.nudAmountOfEnemies);
            this.mapPanel.Location = new System.Drawing.Point(-1, -2);
            this.mapPanel.Name = "mapPanel";
            this.mapPanel.Size = new System.Drawing.Size(492, 420);
            this.mapPanel.TabIndex = 3;
            // 
            // GameGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::SE2_GameAssignment.Properties.Resources.laurel_wreath_156019_1280;
            this.ClientSize = new System.Drawing.Size(487, 416);
            this.Controls.Add(this.mapPanel);
            this.Name = "GameGUI";
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountOfEnemies)).EndInit();
            this.mapPanel.ResumeLayout(false);
            this.mapPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.NumericUpDown nudAmountOfEnemies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel mapPanel;
    }
}

