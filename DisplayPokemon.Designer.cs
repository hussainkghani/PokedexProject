
namespace PokedexProject
{
    partial class DisplayPokemon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayPokemon));
            this.picBoxSprites = new System.Windows.Forms.PictureBox();
            this.richtxtDescription = new System.Windows.Forms.RichTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSpecies = new System.Windows.Forms.TextBox();
            this.lblPokemon = new System.Windows.Forms.Label();
            this.txtTypeone = new System.Windows.Forms.TextBox();
            this.txtTypetwo = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.btnSound = new System.Windows.Forms.Button();
            this.btnBackwards = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStripCRUD = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPokemonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPokemonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSprites)).BeginInit();
            this.menuStripCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBoxSprites
            // 
            this.picBoxSprites.BackColor = System.Drawing.Color.White;
            this.picBoxSprites.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBoxSprites.ErrorImage = null;
            this.picBoxSprites.Location = new System.Drawing.Point(32, 148);
            this.picBoxSprites.Name = "picBoxSprites";
            this.picBoxSprites.Size = new System.Drawing.Size(329, 257);
            this.picBoxSprites.TabIndex = 0;
            this.picBoxSprites.TabStop = false;
            // 
            // richtxtDescription
            // 
            this.richtxtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richtxtDescription.Location = new System.Drawing.Point(233, 532);
            this.richtxtDescription.Name = "richtxtDescription";
            this.richtxtDescription.Size = new System.Drawing.Size(527, 132);
            this.richtxtDescription.TabIndex = 1;
            this.richtxtDescription.Text = "";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(474, 98);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(453, 34);
            this.txtName.TabIndex = 2;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSpecies
            // 
            this.txtSpecies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSpecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecies.Location = new System.Drawing.Point(433, 166);
            this.txtSpecies.Name = "txtSpecies";
            this.txtSpecies.Size = new System.Drawing.Size(394, 27);
            this.txtSpecies.TabIndex = 4;
            this.txtSpecies.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPokemon
            // 
            this.lblPokemon.AutoSize = true;
            this.lblPokemon.BackColor = System.Drawing.Color.White;
            this.lblPokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPokemon.Location = new System.Drawing.Point(844, 166);
            this.lblPokemon.Name = "lblPokemon";
            this.lblPokemon.Size = new System.Drawing.Size(101, 20);
            this.lblPokemon.TabIndex = 5;
            this.lblPokemon.Text = "POKEMON";
            // 
            // txtTypeone
            // 
            this.txtTypeone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeone.Location = new System.Drawing.Point(570, 253);
            this.txtTypeone.Name = "txtTypeone";
            this.txtTypeone.Size = new System.Drawing.Size(160, 27);
            this.txtTypeone.TabIndex = 6;
            this.txtTypeone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTypetwo
            // 
            this.txtTypetwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypetwo.Location = new System.Drawing.Point(757, 253);
            this.txtTypetwo.Name = "txtTypetwo";
            this.txtTypetwo.Size = new System.Drawing.Size(160, 27);
            this.txtTypetwo.TabIndex = 7;
            this.txtTypetwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.BackColor = System.Drawing.Color.White;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(861, 347);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(67, 20);
            this.lblHeight.TabIndex = 8;
            this.lblHeight.Text = "Meters";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.BackColor = System.Drawing.Color.White;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(861, 403);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(41, 20);
            this.lblWeight.TabIndex = 9;
            this.lblWeight.Text = "Kgs";
            // 
            // txtHeight
            // 
            this.txtHeight.BackColor = System.Drawing.Color.White;
            this.txtHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(676, 344);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(179, 27);
            this.txtHeight.TabIndex = 10;
            this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWeight
            // 
            this.txtWeight.BackColor = System.Drawing.Color.White;
            this.txtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(676, 403);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(179, 27);
            this.txtWeight.TabIndex = 11;
            this.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSound
            // 
            this.btnSound.BackColor = System.Drawing.Color.White;
            this.btnSound.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSound.BackgroundImage")));
            this.btnSound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSound.Location = new System.Drawing.Point(422, 262);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(91, 82);
            this.btnSound.TabIndex = 12;
            this.btnSound.UseVisualStyleBackColor = false;
            this.btnSound.Click += new System.EventHandler(this.btnSound_Click);
            // 
            // btnBackwards
            // 
            this.btnBackwards.BackColor = System.Drawing.Color.Red;
            this.btnBackwards.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackwards.Location = new System.Drawing.Point(106, 553);
            this.btnBackwards.Name = "btnBackwards";
            this.btnBackwards.Size = new System.Drawing.Size(98, 87);
            this.btnBackwards.TabIndex = 13;
            this.btnBackwards.Text = "◀";
            this.btnBackwards.UseVisualStyleBackColor = false;
            this.btnBackwards.Click += new System.EventHandler(this.btnBackwards_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(792, 553);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 87);
            this.button1.TabIndex = 14;
            this.button1.Text = "▶";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStripCRUD
            // 
            this.menuStripCRUD.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripCRUD.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.menuStripCRUD.Location = new System.Drawing.Point(0, 0);
            this.menuStripCRUD.Name = "menuStripCRUD";
            this.menuStripCRUD.Size = new System.Drawing.Size(983, 28);
            this.menuStripCRUD.TabIndex = 15;
            this.menuStripCRUD.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewPokemonToolStripMenuItem,
            this.editPokemonToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // addNewPokemonToolStripMenuItem
            // 
            this.addNewPokemonToolStripMenuItem.Name = "addNewPokemonToolStripMenuItem";
            this.addNewPokemonToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addNewPokemonToolStripMenuItem.Text = "Add New Pokemon";
            this.addNewPokemonToolStripMenuItem.Click += new System.EventHandler(this.addNewPokemonToolStripMenuItem_Click);
            // 
            // editPokemonToolStripMenuItem
            // 
            this.editPokemonToolStripMenuItem.Name = "editPokemonToolStripMenuItem";
            this.editPokemonToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editPokemonToolStripMenuItem.Text = "Edit Pokemon";
            this.editPokemonToolStripMenuItem.Click += new System.EventHandler(this.editPokemonToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // DisplayPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(983, 714);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBackwards);
            this.Controls.Add(this.btnSound);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.txtTypetwo);
            this.Controls.Add(this.txtTypeone);
            this.Controls.Add(this.lblPokemon);
            this.Controls.Add(this.txtSpecies);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.richtxtDescription);
            this.Controls.Add(this.picBoxSprites);
            this.Controls.Add(this.menuStripCRUD);
            this.MainMenuStrip = this.menuStripCRUD;
            this.Name = "DisplayPokemon";
            this.Text = "▶";
            this.Load += new System.EventHandler(this.DisplayPokemon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSprites)).EndInit();
            this.menuStripCRUD.ResumeLayout(false);
            this.menuStripCRUD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxSprites;
        private System.Windows.Forms.RichTextBox richtxtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSpecies;
        private System.Windows.Forms.Label lblPokemon;
        private System.Windows.Forms.TextBox txtTypeone;
        private System.Windows.Forms.TextBox txtTypetwo;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Button btnSound;
        private System.Windows.Forms.Button btnBackwards;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStripCRUD;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPokemonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPokemonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}