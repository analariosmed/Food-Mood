namespace Food_Mood
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.checkedListBoxMealTime = new System.Windows.Forms.CheckedListBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxAfter = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonAnxious = new System.Windows.Forms.RadioButton();
            this.radioButtonDepressive = new System.Windows.Forms.RadioButton();
            this.radioButtonCalm = new System.Windows.Forms.RadioButton();
            this.radioButtonSad = new System.Windows.Forms.RadioButton();
            this.radioButtonHappy = new System.Windows.Forms.RadioButton();
            this.buttonExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.labelDishDescription = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.comboBoxDishes = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBoxAfter.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBoxMealTime
            // 
            this.checkedListBoxMealTime.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkedListBoxMealTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxMealTime.FormattingEnabled = true;
            this.checkedListBoxMealTime.Items.AddRange(new object[] {
            "Breakfast",
            "Snack",
            "Lunch",
            "Dinner"});
            this.checkedListBoxMealTime.Location = new System.Drawing.Point(129, 238);
            this.checkedListBoxMealTime.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.checkedListBoxMealTime.Name = "checkedListBoxMealTime";
            this.checkedListBoxMealTime.Size = new System.Drawing.Size(119, 76);
            this.checkedListBoxMealTime.TabIndex = 10;
            this.checkedListBoxMealTime.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxMealTime_SelectedIndexChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.buttonSave.Location = new System.Drawing.Point(252, 656);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(104, 34);
            this.buttonSave.TabIndex = 25;
            this.buttonSave.Text = "Save Report";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBoxAfter);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.buttonExit);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.labelDishDescription);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.comboBoxDishes);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.checkedListBoxMealTime);
            this.groupBox1.Location = new System.Drawing.Point(19, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupBox1.Size = new System.Drawing.Size(699, 719);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report";
            // 
            // groupBoxAfter
            // 
            this.groupBoxAfter.Controls.Add(this.radioButton6);
            this.groupBoxAfter.Controls.Add(this.radioButton7);
            this.groupBoxAfter.Controls.Add(this.radioButton8);
            this.groupBoxAfter.Controls.Add(this.radioButton9);
            this.groupBoxAfter.Controls.Add(this.radioButton10);
            this.groupBoxAfter.Location = new System.Drawing.Point(80, 600);
            this.groupBoxAfter.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupBoxAfter.Name = "groupBoxAfter";
            this.groupBoxAfter.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupBoxAfter.Size = new System.Drawing.Size(373, 45);
            this.groupBoxAfter.TabIndex = 52;
            this.groupBoxAfter.TabStop = false;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(148, 14);
            this.radioButton6.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(75, 21);
            this.radioButton6.TabIndex = 49;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Anxious";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(277, 14);
            this.radioButton7.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(97, 21);
            this.radioButton7.TabIndex = 48;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Depressive";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(83, 14);
            this.radioButton8.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(57, 21);
            this.radioButton8.TabIndex = 47;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Calm";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(225, 14);
            this.radioButton9.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(51, 21);
            this.radioButton9.TabIndex = 46;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "Sad";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(14, 14);
            this.radioButton10.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(67, 21);
            this.radioButton10.TabIndex = 45;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "Happy";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonAnxious);
            this.groupBox3.Controls.Add(this.radioButtonDepressive);
            this.groupBox3.Controls.Add(this.radioButtonCalm);
            this.groupBox3.Controls.Add(this.radioButtonSad);
            this.groupBox3.Controls.Add(this.radioButtonHappy);
            this.groupBox3.Location = new System.Drawing.Point(75, 511);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupBox3.Size = new System.Drawing.Size(373, 45);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            // 
            // radioButtonAnxious
            // 
            this.radioButtonAnxious.AutoSize = true;
            this.radioButtonAnxious.Location = new System.Drawing.Point(148, 14);
            this.radioButtonAnxious.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.radioButtonAnxious.Name = "radioButtonAnxious";
            this.radioButtonAnxious.Size = new System.Drawing.Size(75, 21);
            this.radioButtonAnxious.TabIndex = 49;
            this.radioButtonAnxious.TabStop = true;
            this.radioButtonAnxious.Text = "Anxious";
            this.radioButtonAnxious.UseVisualStyleBackColor = true;
            // 
            // radioButtonDepressive
            // 
            this.radioButtonDepressive.AutoSize = true;
            this.radioButtonDepressive.Location = new System.Drawing.Point(277, 14);
            this.radioButtonDepressive.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.radioButtonDepressive.Name = "radioButtonDepressive";
            this.radioButtonDepressive.Size = new System.Drawing.Size(97, 21);
            this.radioButtonDepressive.TabIndex = 48;
            this.radioButtonDepressive.TabStop = true;
            this.radioButtonDepressive.Text = "Depressive";
            this.radioButtonDepressive.UseVisualStyleBackColor = true;
            // 
            // radioButtonCalm
            // 
            this.radioButtonCalm.AutoSize = true;
            this.radioButtonCalm.Location = new System.Drawing.Point(83, 14);
            this.radioButtonCalm.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.radioButtonCalm.Name = "radioButtonCalm";
            this.radioButtonCalm.Size = new System.Drawing.Size(57, 21);
            this.radioButtonCalm.TabIndex = 47;
            this.radioButtonCalm.TabStop = true;
            this.radioButtonCalm.Text = "Calm";
            this.radioButtonCalm.UseVisualStyleBackColor = true;
            // 
            // radioButtonSad
            // 
            this.radioButtonSad.AutoSize = true;
            this.radioButtonSad.Location = new System.Drawing.Point(225, 14);
            this.radioButtonSad.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.radioButtonSad.Name = "radioButtonSad";
            this.radioButtonSad.Size = new System.Drawing.Size(51, 21);
            this.radioButtonSad.TabIndex = 46;
            this.radioButtonSad.TabStop = true;
            this.radioButtonSad.Text = "Sad";
            this.radioButtonSad.UseVisualStyleBackColor = true;
            // 
            // radioButtonHappy
            // 
            this.radioButtonHappy.AutoSize = true;
            this.radioButtonHappy.Location = new System.Drawing.Point(14, 14);
            this.radioButtonHappy.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.radioButtonHappy.Name = "radioButtonHappy";
            this.radioButtonHappy.Size = new System.Drawing.Size(67, 21);
            this.radioButtonHappy.TabIndex = 45;
            this.radioButtonHappy.TabStop = true;
            this.radioButtonHappy.Text = "Happy";
            this.radioButtonHappy.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.buttonExit.Location = new System.Drawing.Point(374, 656);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(104, 34);
            this.buttonExit.TabIndex = 33;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(374, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.CausesValidation = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(29, 493);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(460, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Select the emotion that reflects how you felt before your meal:";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(330, 347);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(131, 23);
            this.button9.TabIndex = 36;
            this.button9.Text = "Add custom Dish";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(275, 347);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(29, 17);
            this.label22.TabIndex = 37;
            this.label22.Text = "OR";
            // 
            // labelDishDescription
            // 
            this.labelDishDescription.AutoSize = true;
            this.labelDishDescription.Location = new System.Drawing.Point(26, 424);
            this.labelDishDescription.Name = "labelDishDescription";
            this.labelDishDescription.Size = new System.Drawing.Size(119, 17);
            this.labelDishDescription.TabIndex = 35;
            this.labelDishDescription.Text = "Dish composition:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(26, 389);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(119, 17);
            this.label20.TabIndex = 34;
            this.label20.Text = "Dish composition:";
            // 
            // comboBoxDishes
            // 
            this.comboBoxDishes.FormattingEnabled = true;
            this.comboBoxDishes.Location = new System.Drawing.Point(29, 347);
            this.comboBoxDishes.Name = "comboBoxDishes";
            this.comboBoxDishes.Size = new System.Drawing.Size(219, 24);
            this.comboBoxDishes.TabIndex = 33;
            this.comboBoxDishes.SelectedIndexChanged += new System.EventHandler(this.loadDescription);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.CausesValidation = false;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(26, 321);
            this.label19.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(130, 17);
            this.label19.TabIndex = 32;
            this.label19.Text = "Select your dish:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.CausesValidation = false;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(29, 571);
            this.label14.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(438, 17);
            this.label14.TabIndex = 38;
            this.label14.Text = "Select the emotion button that reflects  how you are feeling";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.CausesValidation = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(159, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 24);
            this.label3.TabIndex = 36;
            this.label3.Text = "Meal Report ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(26, 238);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Meal Time :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.CausesValidation = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(29, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Meal Date:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.monthCalendar1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.monthCalendar1.Location = new System.Drawing.Point(129, 55);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 33;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(10, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(745, 785);
            this.tabControl1.TabIndex = 37;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabPage1.Size = new System.Drawing.Size(737, 759);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Meal Report";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabPage2.Size = new System.Drawing.Size(701, 745);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Advice Meal";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(553, 641);
            this.button8.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(118, 28);
            this.button8.TabIndex = 1;
            this.button8.Text = "Exit";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(13, 24);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupBox2.Size = new System.Drawing.Size(658, 600);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Advice Meal";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(364, 54);
            this.button7.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(115, 26);
            this.button7.TabIndex = 45;
            this.button7.Text = "Show";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(454, 500);
            this.button6.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(126, 24);
            this.button6.TabIndex = 44;
            this.button6.Text = "Delete";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Breakfast",
            "Snack",
            "Lunch",
            "Dinner"});
            this.comboBox3.Location = new System.Drawing.Point(275, 500);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(163, 24);
            this.comboBox3.TabIndex = 43;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(51, 502);
            this.label18.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(242, 17);
            this.label18.TabIndex = 42;
            this.label18.Text = "Choose the option you want to delete";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(29, 136);
            this.label17.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(146, 17);
            this.label17.TabIndex = 41;
            this.label17.Text = "Here are your options";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 167);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 123;
            this.dataGridView1.RowTemplate.Height = 46;
            this.dataGridView1.Size = new System.Drawing.Size(601, 249);
            this.dataGridView1.TabIndex = 40;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Breakfast",
            "Snack",
            "Lunch",
            "Dinner"});
            this.comboBox2.Location = new System.Drawing.Point(144, 80);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(163, 24);
            this.comboBox2.TabIndex = 39;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(29, 81);
            this.label16.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 17);
            this.label16.TabIndex = 38;
            this.label16.Text = "Meal Time";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Happy ",
            "Calm",
            "Sad",
            "Axious",
            "Depressive"});
            this.comboBox1.Location = new System.Drawing.Point(144, 37);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "How do you feel?";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(776, 807);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Report";
            this.Text = "Report";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxAfter.ResumeLayout(false);
            this.groupBoxAfter.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckedListBox checkedListBoxMealTime;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label labelDishDescription;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox comboBoxDishes;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupBoxAfter;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonAnxious;
        private System.Windows.Forms.RadioButton radioButtonDepressive;
        private System.Windows.Forms.RadioButton radioButtonCalm;
        private System.Windows.Forms.RadioButton radioButtonSad;
        private System.Windows.Forms.RadioButton radioButtonHappy;
    }
}