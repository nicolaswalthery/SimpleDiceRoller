namespace SimpleDiceRoller
{
    partial class Mainform
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.tableLayoutPanelCaracDie = new System.Windows.Forms.TableLayoutPanel();
            this.labelNumSides = new System.Windows.Forms.Label();
            this.labelNumDice = new System.Windows.Forms.Label();
            this.panelButtonRoll = new System.Windows.Forms.Panel();
            this.buttonRoller = new System.Windows.Forms.Button();
            this.panelOutcome = new System.Windows.Forms.Panel();
            this.richTextBoxOutcome = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxNDice = new System.Windows.Forms.TextBox();
            this.textBoxNSides = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelCaracDie.SuspendLayout();
            this.panelButtonRoll.SuspendLayout();
            this.panelOutcome.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelCaracDie
            // 
            this.tableLayoutPanelCaracDie.ColumnCount = 1;
            this.tableLayoutPanelCaracDie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCaracDie.Controls.Add(this.labelNumSides, 0, 2);
            this.tableLayoutPanelCaracDie.Controls.Add(this.labelNumDice, 0, 0);
            this.tableLayoutPanelCaracDie.Location = new System.Drawing.Point(12, 44);
            this.tableLayoutPanelCaracDie.Name = "tableLayoutPanelCaracDie";
            this.tableLayoutPanelCaracDie.RowCount = 4;
            this.tableLayoutPanelCaracDie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelCaracDie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelCaracDie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelCaracDie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelCaracDie.Size = new System.Drawing.Size(141, 119);
            this.tableLayoutPanelCaracDie.TabIndex = 0;
            // 
            // labelNumSides
            // 
            this.labelNumSides.AutoSize = true;
            this.labelNumSides.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNumSides.Location = new System.Drawing.Point(3, 58);
            this.labelNumSides.Name = "labelNumSides";
            this.labelNumSides.Size = new System.Drawing.Size(114, 29);
            this.labelNumSides.TabIndex = 1;
            this.labelNumSides.Text = "Number of sides";
            this.labelNumSides.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNumSides.Click += new System.EventHandler(this.labelNumSides_Click);
            // 
            // labelNumDice
            // 
            this.labelNumDice.AutoSize = true;
            this.labelNumDice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNumDice.Location = new System.Drawing.Point(3, 0);
            this.labelNumDice.Name = "labelNumDice";
            this.labelNumDice.Size = new System.Drawing.Size(114, 29);
            this.labelNumDice.TabIndex = 0;
            this.labelNumDice.Text = "Number of dice";
            this.labelNumDice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelButtonRoll
            // 
            this.panelButtonRoll.Controls.Add(this.buttonRoller);
            this.panelButtonRoll.Location = new System.Drawing.Point(251, 5);
            this.panelButtonRoll.Name = "panelButtonRoll";
            this.panelButtonRoll.Size = new System.Drawing.Size(167, 165);
            this.panelButtonRoll.TabIndex = 1;
            // 
            // buttonRoller
            // 
            this.buttonRoller.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.buttonRoller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoller.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(90)))), ((int)(((byte)(108)))));
            this.buttonRoller.Image = ((System.Drawing.Image)(resources.GetObject("buttonRoller.Image")));
            this.buttonRoller.Location = new System.Drawing.Point(3, 7);
            this.buttonRoller.Name = "buttonRoller";
            this.buttonRoller.Size = new System.Drawing.Size(161, 151);
            this.buttonRoller.TabIndex = 0;
            this.buttonRoller.UseVisualStyleBackColor = true;
            this.buttonRoller.Click += new System.EventHandler(this.buttonRoller_Click);
            // 
            // panelOutcome
            // 
            this.panelOutcome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOutcome.Controls.Add(this.richTextBoxOutcome);
            this.panelOutcome.Location = new System.Drawing.Point(424, 12);
            this.panelOutcome.Name = "panelOutcome";
            this.panelOutcome.Size = new System.Drawing.Size(597, 151);
            this.panelOutcome.TabIndex = 2;
            // 
            // richTextBoxOutcome
            // 
            this.richTextBoxOutcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(45)))));
            this.richTextBoxOutcome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxOutcome.Font = new System.Drawing.Font("Century Gothic", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxOutcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.richTextBoxOutcome.Location = new System.Drawing.Point(3, 10);
            this.richTextBoxOutcome.Name = "richTextBoxOutcome";
            this.richTextBoxOutcome.ReadOnly = true;
            this.richTextBoxOutcome.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.richTextBoxOutcome.Size = new System.Drawing.Size(589, 132);
            this.richTextBoxOutcome.TabIndex = 0;
            this.richTextBoxOutcome.Text = "";
            this.richTextBoxOutcome.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxNDice, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNSides, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(159, 38);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(86, 125);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // textBoxNDice
            // 
            this.textBoxNDice.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNDice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(45)))));
            this.textBoxNDice.Location = new System.Drawing.Point(3, 3);
            this.textBoxNDice.MaxLength = 4;
            this.textBoxNDice.Name = "textBoxNDice";
            this.textBoxNDice.Size = new System.Drawing.Size(80, 32);
            this.textBoxNDice.TabIndex = 0;
            this.textBoxNDice.TextChanged += new System.EventHandler(this.textBoxNDice_TextChanged);
            // 
            // textBoxNSides
            // 
            this.textBoxNSides.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNSides.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(45)))));
            this.textBoxNSides.Location = new System.Drawing.Point(3, 65);
            this.textBoxNSides.MaxLength = 4;
            this.textBoxNSides.Name = "textBoxNSides";
            this.textBoxNSides.Size = new System.Drawing.Size(80, 32);
            this.textBoxNSides.TabIndex = 1;
            this.textBoxNSides.TextChanged += new System.EventHandler(this.textBoxNSides_TextChanged);
            // 
            // Mainform
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1027, 171);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelOutcome);
            this.Controls.Add(this.panelButtonRoll);
            this.Controls.Add(this.tableLayoutPanelCaracDie);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mainform";
            this.Text = "Simple Dice Roller";
            this.tableLayoutPanelCaracDie.ResumeLayout(false);
            this.tableLayoutPanelCaracDie.PerformLayout();
            this.panelButtonRoll.ResumeLayout(false);
            this.panelOutcome.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCaracDie;
        private System.Windows.Forms.Panel panelButtonRoll;
        private System.Windows.Forms.Button buttonRoller;
        private System.Windows.Forms.Panel panelOutcome;
        private System.Windows.Forms.Label labelNumDice;
        private System.Windows.Forms.Label labelNumSides;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxNDice;
        private System.Windows.Forms.TextBox textBoxNSides;
        private System.Windows.Forms.RichTextBox richTextBoxOutcome;
    }
}

