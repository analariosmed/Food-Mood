namespace Food_Mood
{
    partial class CustomDish
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDishName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAddNewIngredient = new System.Windows.Forms.Button();
            this.comboBoxIngredientsName = new System.Windows.Forms.ComboBox();
            this.comboBoxPortionSize = new System.Windows.Forms.ComboBox();
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewDishIngredients = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSaveDish = new System.Windows.Forms.Button();
            this.buttonCancelDish = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDishIngredients)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dish Name:";
            // 
            // textBoxDishName
            // 
            this.textBoxDishName.Location = new System.Drawing.Point(140, 28);
            this.textBoxDishName.Name = "textBoxDishName";
            this.textBoxDishName.Size = new System.Drawing.Size(403, 23);
            this.textBoxDishName.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAddNewIngredient);
            this.groupBox1.Controls.Add(this.comboBoxIngredientsName);
            this.groupBox1.Controls.Add(this.comboBoxPortionSize);
            this.groupBox1.Controls.Add(this.comboBoxCategories);
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Controls.Add(this.buttonRemove);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(39, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 210);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingredient";
            // 
            // buttonAddNewIngredient
            // 
            this.buttonAddNewIngredient.Location = new System.Drawing.Point(333, 160);
            this.buttonAddNewIngredient.Name = "buttonAddNewIngredient";
            this.buttonAddNewIngredient.Size = new System.Drawing.Size(141, 34);
            this.buttonAddNewIngredient.TabIndex = 17;
            this.buttonAddNewIngredient.Text = "New Igredient";
            this.buttonAddNewIngredient.UseVisualStyleBackColor = true;
            this.buttonAddNewIngredient.Click += new System.EventHandler(this.buttonAddNewIngredient_Click);
            // 
            // comboBoxIngredientsName
            // 
            this.comboBoxIngredientsName.FormattingEnabled = true;
            this.comboBoxIngredientsName.Location = new System.Drawing.Point(158, 83);
            this.comboBoxIngredientsName.Name = "comboBoxIngredientsName";
            this.comboBoxIngredientsName.Size = new System.Drawing.Size(315, 24);
            this.comboBoxIngredientsName.TabIndex = 16;
            // 
            // comboBoxPortionSize
            // 
            this.comboBoxPortionSize.FormattingEnabled = true;
            this.comboBoxPortionSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large",
            "X Large"});
            this.comboBoxPortionSize.Location = new System.Drawing.Point(158, 121);
            this.comboBoxPortionSize.Name = "comboBoxPortionSize";
            this.comboBoxPortionSize.Size = new System.Drawing.Size(316, 24);
            this.comboBoxPortionSize.TabIndex = 15;
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Location = new System.Drawing.Point(111, 40);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(363, 24);
            this.comboBoxCategories.TabIndex = 14;
            this.comboBoxCategories.SelectedIndexChanged += new System.EventHandler(this.loadIngredients);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(231, 160);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(96, 34);
            this.buttonUpdate.TabIndex = 13;
            this.buttonUpdate.Text = "Update Size";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(129, 160);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(96, 34);
            this.buttonRemove.TabIndex = 12;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(27, 160);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(96, 34);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Add to Dish";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Size of the Portion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ingredient Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Category:";
            // 
            // dataGridViewDishIngredients
            // 
            this.dataGridViewDishIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDishIngredients.Location = new System.Drawing.Point(39, 356);
            this.dataGridViewDishIngredients.Name = "dataGridViewDishIngredients";
            this.dataGridViewDishIngredients.Size = new System.Drawing.Size(504, 162);
            this.dataGridViewDishIngredients.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(36, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ingredients List:";
            // 
            // buttonSaveDish
            // 
            this.buttonSaveDish.Location = new System.Drawing.Point(257, 545);
            this.buttonSaveDish.Name = "buttonSaveDish";
            this.buttonSaveDish.Size = new System.Drawing.Size(140, 34);
            this.buttonSaveDish.TabIndex = 12;
            this.buttonSaveDish.Text = "Save Dish";
            this.buttonSaveDish.UseVisualStyleBackColor = true;
            this.buttonSaveDish.Click += new System.EventHandler(this.buttonSaveDish_Click);
            // 
            // buttonCancelDish
            // 
            this.buttonCancelDish.Location = new System.Drawing.Point(403, 545);
            this.buttonCancelDish.Name = "buttonCancelDish";
            this.buttonCancelDish.Size = new System.Drawing.Size(140, 34);
            this.buttonCancelDish.TabIndex = 13;
            this.buttonCancelDish.Text = "Cancel";
            this.buttonCancelDish.UseVisualStyleBackColor = true;
            this.buttonCancelDish.Click += new System.EventHandler(this.buttonCancelDish_Click);
            // 
            // CustomDish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 596);
            this.Controls.Add(this.buttonCancelDish);
            this.Controls.Add(this.buttonSaveDish);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewDishIngredients);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxDishName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomDish";
            this.Text = " ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDishIngredients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDishName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewDishIngredients;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSaveDish;
        private System.Windows.Forms.Button buttonCancelDish;
        private System.Windows.Forms.ComboBox comboBoxCategories;
        private System.Windows.Forms.ComboBox comboBoxIngredientsName;
        private System.Windows.Forms.ComboBox comboBoxPortionSize;
        private System.Windows.Forms.Button buttonAddNewIngredient;
    }
}