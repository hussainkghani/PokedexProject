
namespace PokedexProject
{
    partial class EditPokemon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPokemon));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblType1 = new System.Windows.Forms.Label();
            this.lblType2 = new System.Windows.Forms.Label();
            this.lblClassification = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPicture = new System.Windows.Forms.Label();
            this.lblSound = new System.Windows.Forms.Label();
            this.txtID1 = new System.Windows.Forms.TextBox();
            this.txtName1 = new System.Windows.Forms.TextBox();
            this.txtType1 = new System.Windows.Forms.TextBox();
            this.txtType2 = new System.Windows.Forms.TextBox();
            this.txtClassification = new System.Windows.Forms.TextBox();
            this.txtHeight1 = new System.Windows.Forms.TextBox();
            this.txtWeight1 = new System.Windows.Forms.TextBox();
            this.richtxtDescription1 = new System.Windows.Forms.RichTextBox();
            this.richtxtPicture = new System.Windows.Forms.RichTextBox();
            this.richtxtSound = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(62, 485);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 56);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(428, 485);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(107, 56);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(783, 485);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 56);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(29, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(912, 112);
            this.dataGridView1.TabIndex = 3;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(59, 147);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 17);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "ID";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(59, 210);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 17);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "NAME";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblType1
            // 
            this.lblType1.AutoSize = true;
            this.lblType1.Location = new System.Drawing.Point(59, 272);
            this.lblType1.Name = "lblType1";
            this.lblType1.Size = new System.Drawing.Size(56, 17);
            this.lblType1.TabIndex = 6;
            this.lblType1.Text = "TYPE 1";
            this.lblType1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblType2
            // 
            this.lblType2.AutoSize = true;
            this.lblType2.Location = new System.Drawing.Point(59, 346);
            this.lblType2.Name = "lblType2";
            this.lblType2.Size = new System.Drawing.Size(56, 17);
            this.lblType2.TabIndex = 7;
            this.lblType2.Text = "TYPE 2";
            this.lblType2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClassification
            // 
            this.lblClassification.AutoSize = true;
            this.lblClassification.Location = new System.Drawing.Point(59, 407);
            this.lblClassification.Name = "lblClassification";
            this.lblClassification.Size = new System.Drawing.Size(117, 17);
            this.lblClassification.TabIndex = 8;
            this.lblClassification.Text = "CLASSIFICATION";
            this.lblClassification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(608, 147);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(60, 17);
            this.lblHeight.TabIndex = 9;
            this.lblHeight.Text = "HEIGHT";
            this.lblHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(608, 210);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(63, 17);
            this.lblWeight.TabIndex = 10;
            this.lblWeight.Text = "WEIGHT";
            this.lblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(608, 276);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(100, 17);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.Text = "DESCRIPTION";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPicture
            // 
            this.lblPicture.AutoSize = true;
            this.lblPicture.Location = new System.Drawing.Point(608, 346);
            this.lblPicture.Name = "lblPicture";
            this.lblPicture.Size = new System.Drawing.Size(67, 17);
            this.lblPicture.TabIndex = 12;
            this.lblPicture.Text = "PICTURE";
            this.lblPicture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSound
            // 
            this.lblSound.AutoSize = true;
            this.lblSound.Location = new System.Drawing.Point(608, 411);
            this.lblSound.Name = "lblSound";
            this.lblSound.Size = new System.Drawing.Size(58, 17);
            this.lblSound.TabIndex = 13;
            this.lblSound.Text = "SOUND";
            this.lblSound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtID1
            // 
            this.txtID1.Location = new System.Drawing.Point(265, 146);
            this.txtID1.Name = "txtID1";
            this.txtID1.Size = new System.Drawing.Size(135, 22);
            this.txtID1.TabIndex = 14;
            // 
            // txtName1
            // 
            this.txtName1.Location = new System.Drawing.Point(265, 205);
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(135, 22);
            this.txtName1.TabIndex = 15;
            // 
            // txtType1
            // 
            this.txtType1.Location = new System.Drawing.Point(265, 267);
            this.txtType1.Name = "txtType1";
            this.txtType1.Size = new System.Drawing.Size(135, 22);
            this.txtType1.TabIndex = 16;
            // 
            // txtType2
            // 
            this.txtType2.Location = new System.Drawing.Point(265, 341);
            this.txtType2.Name = "txtType2";
            this.txtType2.Size = new System.Drawing.Size(135, 22);
            this.txtType2.TabIndex = 17;
            // 
            // txtClassification
            // 
            this.txtClassification.Location = new System.Drawing.Point(265, 406);
            this.txtClassification.Name = "txtClassification";
            this.txtClassification.Size = new System.Drawing.Size(135, 22);
            this.txtClassification.TabIndex = 18;
            // 
            // txtHeight1
            // 
            this.txtHeight1.Location = new System.Drawing.Point(766, 146);
            this.txtHeight1.Name = "txtHeight1";
            this.txtHeight1.Size = new System.Drawing.Size(135, 22);
            this.txtHeight1.TabIndex = 19;
            // 
            // txtWeight1
            // 
            this.txtWeight1.Location = new System.Drawing.Point(766, 210);
            this.txtWeight1.Name = "txtWeight1";
            this.txtWeight1.Size = new System.Drawing.Size(135, 22);
            this.txtWeight1.TabIndex = 20;
            // 
            // richtxtDescription1
            // 
            this.richtxtDescription1.Location = new System.Drawing.Point(766, 271);
            this.richtxtDescription1.Name = "richtxtDescription1";
            this.richtxtDescription1.Size = new System.Drawing.Size(135, 22);
            this.richtxtDescription1.TabIndex = 21;
            this.richtxtDescription1.Text = "";
            // 
            // richtxtPicture
            // 
            this.richtxtPicture.Location = new System.Drawing.Point(766, 346);
            this.richtxtPicture.Name = "richtxtPicture";
            this.richtxtPicture.Size = new System.Drawing.Size(135, 22);
            this.richtxtPicture.TabIndex = 22;
            this.richtxtPicture.Text = "";
            // 
            // richtxtSound
            // 
            this.richtxtSound.Location = new System.Drawing.Point(766, 411);
            this.richtxtSound.Name = "richtxtSound";
            this.richtxtSound.Size = new System.Drawing.Size(135, 22);
            this.richtxtSound.TabIndex = 23;
            this.richtxtSound.Text = "";
            // 
            // EditPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(958, 573);
            this.Controls.Add(this.richtxtSound);
            this.Controls.Add(this.richtxtPicture);
            this.Controls.Add(this.richtxtDescription1);
            this.Controls.Add(this.txtWeight1);
            this.Controls.Add(this.txtHeight1);
            this.Controls.Add(this.txtClassification);
            this.Controls.Add(this.txtType2);
            this.Controls.Add(this.txtType1);
            this.Controls.Add(this.txtName1);
            this.Controls.Add(this.txtID1);
            this.Controls.Add(this.lblSound);
            this.Controls.Add(this.lblPicture);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblClassification);
            this.Controls.Add(this.lblType2);
            this.Controls.Add(this.lblType1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Name = "EditPokemon";
            this.Text = "EditPokemon";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblType1;
        private System.Windows.Forms.Label lblType2;
        private System.Windows.Forms.Label lblClassification;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPicture;
        private System.Windows.Forms.Label lblSound;
        private System.Windows.Forms.TextBox txtID1;
        private System.Windows.Forms.TextBox txtName1;
        private System.Windows.Forms.TextBox txtType1;
        private System.Windows.Forms.TextBox txtType2;
        private System.Windows.Forms.TextBox txtClassification;
        private System.Windows.Forms.TextBox txtHeight1;
        private System.Windows.Forms.TextBox txtWeight1;
        private System.Windows.Forms.RichTextBox richtxtDescription1;
        private System.Windows.Forms.RichTextBox richtxtPicture;
        private System.Windows.Forms.RichTextBox richtxtSound;
    }
}