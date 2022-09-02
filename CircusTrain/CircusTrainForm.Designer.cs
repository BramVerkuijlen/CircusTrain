namespace CircusTrain
{
    partial class CircusTrainInterface
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
            this.lbl_animal = new System.Windows.Forms.Label();
            this.lbox_animals = new System.Windows.Forms.ListBox();
            this.lbl_diët = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_size = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbox_size = new System.Windows.Forms.ListBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbl_animalList = new System.Windows.Forms.Label();
            this.lbox_train = new System.Windows.Forms.ListBox();
            this.btn_makeTrain = new System.Windows.Forms.Button();
            this.txtbox_name = new System.Windows.Forms.TextBox();
            this.lbox_diët = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_animal
            // 
            this.lbl_animal.AutoSize = true;
            this.lbl_animal.Location = new System.Drawing.Point(27, 26);
            this.lbl_animal.Name = "lbl_animal";
            this.lbl_animal.Size = new System.Drawing.Size(45, 15);
            this.lbl_animal.TabIndex = 1;
            this.lbl_animal.Text = "Animal";
            // 
            // lbox_animals
            // 
            this.lbox_animals.FormattingEnabled = true;
            this.lbox_animals.ItemHeight = 15;
            this.lbox_animals.Location = new System.Drawing.Point(299, 63);
            this.lbox_animals.Name = "lbox_animals";
            this.lbox_animals.Size = new System.Drawing.Size(223, 199);
            this.lbox_animals.TabIndex = 2;
            // 
            // lbl_diët
            // 
            this.lbl_diët.AutoSize = true;
            this.lbl_diët.Location = new System.Drawing.Point(27, 104);
            this.lbl_diët.Name = "lbl_diët";
            this.lbl_diët.Size = new System.Drawing.Size(28, 15);
            this.lbl_diët.TabIndex = 4;
            this.lbl_diët.Text = "Diët";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(141, 205);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 29);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_size
            // 
            this.lbl_size.AutoSize = true;
            this.lbl_size.Location = new System.Drawing.Point(27, 141);
            this.lbl_size.Name = "lbl_size";
            this.lbl_size.Size = new System.Drawing.Size(26, 15);
            this.lbl_size.TabIndex = 6;
            this.lbl_size.Text = "size";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(27, 62);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(39, 15);
            this.lbl_name.TabIndex = 7;
            this.lbl_name.Text = "Name";
            // 
            // lbox_size
            // 
            this.lbox_size.FormattingEnabled = true;
            this.lbox_size.ItemHeight = 15;
            this.lbox_size.Location = new System.Drawing.Point(89, 141);
            this.lbox_size.Name = "lbox_size";
            this.lbox_size.Size = new System.Drawing.Size(127, 49);
            this.lbox_size.TabIndex = 8;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(447, 268);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lbl_animalList
            // 
            this.lbl_animalList.AutoSize = true;
            this.lbl_animalList.Location = new System.Drawing.Point(299, 26);
            this.lbl_animalList.Name = "lbl_animalList";
            this.lbl_animalList.Size = new System.Drawing.Size(50, 15);
            this.lbl_animalList.TabIndex = 12;
            this.lbl_animalList.Text = "Animals";
            // 
            // lbox_train
            // 
            this.lbox_train.FormattingEnabled = true;
            this.lbox_train.ItemHeight = 15;
            this.lbox_train.Location = new System.Drawing.Point(720, 63);
            this.lbox_train.Name = "lbox_train";
            this.lbox_train.Size = new System.Drawing.Size(223, 454);
            this.lbox_train.TabIndex = 13;
            // 
            // btn_makeTrain
            // 
            this.btn_makeTrain.Location = new System.Drawing.Point(639, 67);
            this.btn_makeTrain.Name = "btn_makeTrain";
            this.btn_makeTrain.Size = new System.Drawing.Size(75, 23);
            this.btn_makeTrain.TabIndex = 14;
            this.btn_makeTrain.Text = "Make Train";
            this.btn_makeTrain.UseVisualStyleBackColor = true;
            this.btn_makeTrain.Click += new System.EventHandler(this.btn_makeTrain_Click);
            // 
            // txtbox_name
            // 
            this.txtbox_name.Location = new System.Drawing.Point(89, 59);
            this.txtbox_name.Name = "txtbox_name";
            this.txtbox_name.Size = new System.Drawing.Size(100, 23);
            this.txtbox_name.TabIndex = 15;
            // 
            // lbox_diët
            // 
            this.lbox_diët.FormattingEnabled = true;
            this.lbox_diët.ItemHeight = 15;
            this.lbox_diët.Location = new System.Drawing.Point(89, 88);
            this.lbox_diët.Name = "lbox_diët";
            this.lbox_diët.Size = new System.Drawing.Size(127, 49);
            this.lbox_diët.TabIndex = 8;
            // 
            // CircusTrainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 588);
            this.Controls.Add(this.txtbox_name);
            this.Controls.Add(this.btn_makeTrain);
            this.Controls.Add(this.lbox_train);
            this.Controls.Add(this.lbl_animalList);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.lbox_diët);
            this.Controls.Add(this.lbox_size);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_size);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_diët);
            this.Controls.Add(this.lbox_animals);
            this.Controls.Add(this.lbl_animal);
            this.Name = "CircusTrainInterface";
            this.Text = "CircusTrain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbl_animal;
        private ListBox lbox_animals;
        private Label lbl_diët;
        private Button btn_add;
        private Label lbl_size;
        private Label lbl_name;
        private ListBox lbox_size;
        private Button btn_delete;
        private Label lbl_animalList;
        private ListBox lbox_train;
        private Button btn_makeTrain;
        private TextBox txtbox_name;
        private ListBox lbox_diët;
    }
}