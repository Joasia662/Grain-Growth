namespace GameOfLife
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.pic = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.cbTypeOfGrid = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.numGridHeight = new System.Windows.Forms.NumericUpDown();
            this.numGridWidith = new System.Windows.Forms.NumericUpDown();
            this.lbJed1 = new System.Windows.Forms.Label();
            this.lbJed2 = new System.Windows.Forms.Label();
            this.btnJedDraw = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labPixCount = new System.Windows.Forms.Label();
            this.btnRand = new System.Windows.Forms.Button();
            this.labRand2 = new System.Windows.Forms.Label();
            this.labRand1 = new System.Windows.Forms.Label();
            this.numRand = new System.Windows.Forms.NumericUpDown();
            this.numJedCount = new System.Windows.Forms.NumericUpDown();
            this.numRadQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnRadius = new System.Windows.Forms.Button();
            this.labRad2 = new System.Windows.Forms.Label();
            this.labRad1 = new System.Windows.Forms.Label();
            this.numRadLen = new System.Windows.Forms.NumericUpDown();
            this.labRad4 = new System.Windows.Forms.Label();
            this.labRad3 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNeighborhood = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCondition = new System.Windows.Forms.ComboBox();
            this.cbHeks = new System.Windows.Forms.ComboBox();
            this.labHex = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGridHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGridWidith)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numJedCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRadQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRadLen)).BeginInit();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Location = new System.Drawing.Point(365, 50);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(600, 600);
            this.pic.TabIndex = 1;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.pic_Click);
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStart.Location = new System.Drawing.Point(28, 91);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(163, 119);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            this.btnStart.Enter += new System.EventHandler(this.btnStart_Enter);
            // 
            // cbTypeOfGrid
            // 
            this.cbTypeOfGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTypeOfGrid.FormattingEnabled = true;
            this.cbTypeOfGrid.Items.AddRange(new object[] {
            "Jednorodne",
            "Losowe",
            "Z promieniem",
            "Custom"});
            this.cbTypeOfGrid.Location = new System.Drawing.Point(28, 439);
            this.cbTypeOfGrid.Name = "cbTypeOfGrid";
            this.cbTypeOfGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbTypeOfGrid.Size = new System.Drawing.Size(321, 21);
            this.cbTypeOfGrid.TabIndex = 4;
            this.cbTypeOfGrid.SelectedIndexChanged += new System.EventHandler(this.cbTypeOfGrid_SelectedIndexChanged);
            this.cbTypeOfGrid.SelectedValueChanged += new System.EventHandler(this.cbTypeOfGrid_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(28, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "                   Zarodkowanie                     ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(29, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "      Grid Size      ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(91, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "X";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Lavender;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClose.Location = new System.Drawing.Point(952, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 37);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(60)))));
            this.panel1.Location = new System.Drawing.Point(662, 650);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(107, 54);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Location = new System.Drawing.Point(769, 650);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(109, 54);
            this.panel2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(25)))), ((int)(((byte)(48)))));
            this.panel3.Location = new System.Drawing.Point(878, 650);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(107, 54);
            this.panel3.TabIndex = 23;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Black;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Adobe Heiti Std R", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefresh.Location = new System.Drawing.Point(197, 91);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(152, 119);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh Grid";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // numGridHeight
            // 
            this.numGridHeight.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.numGridHeight.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numGridHeight.Location = new System.Drawing.Point(116, 249);
            this.numGridHeight.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numGridHeight.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numGridHeight.Name = "numGridHeight";
            this.numGridHeight.Size = new System.Drawing.Size(55, 20);
            this.numGridHeight.TabIndex = 27;
            this.numGridHeight.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // numGridWidith
            // 
            this.numGridWidith.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numGridWidith.Location = new System.Drawing.Point(29, 250);
            this.numGridWidith.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numGridWidith.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numGridWidith.Name = "numGridWidith";
            this.numGridWidith.Size = new System.Drawing.Size(55, 20);
            this.numGridWidith.TabIndex = 26;
            this.numGridWidith.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // lbJed1
            // 
            this.lbJed1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbJed1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbJed1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbJed1.Location = new System.Drawing.Point(28, 472);
            this.lbJed1.Name = "lbJed1";
            this.lbJed1.Size = new System.Drawing.Size(144, 20);
            this.lbJed1.TabIndex = 28;
            this.lbJed1.Text = " Liczba";
            this.lbJed1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbJed2
            // 
            this.lbJed2.AutoSize = true;
            this.lbJed2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbJed2.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbJed2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbJed2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbJed2.Location = new System.Drawing.Point(28, 493);
            this.lbJed2.Name = "lbJed2";
            this.lbJed2.Size = new System.Drawing.Size(144, 20);
            this.lbJed2.TabIndex = 30;
            this.lbJed2.Text = "Wierszy i Kolumn";
            this.lbJed2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnJedDraw
            // 
            this.btnJedDraw.BackColor = System.Drawing.Color.Black;
            this.btnJedDraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnJedDraw.FlatAppearance.BorderSize = 0;
            this.btnJedDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJedDraw.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJedDraw.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnJedDraw.Location = new System.Drawing.Point(178, 478);
            this.btnJedDraw.Name = "btnJedDraw";
            this.btnJedDraw.Size = new System.Drawing.Size(171, 46);
            this.btnJedDraw.TabIndex = 31;
            this.btnJedDraw.Text = "Apply";
            this.btnJedDraw.UseVisualStyleBackColor = false;
            this.btnJedDraw.Click += new System.EventHandler(this.btnJedDraw_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(178, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 41);
            this.label2.TabIndex = 32;
            this.label2.Text = "Number Of Embryos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labPixCount
            // 
            this.labPixCount.BackColor = System.Drawing.Color.DimGray;
            this.labPixCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labPixCount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labPixCount.Location = new System.Drawing.Point(212, 258);
            this.labPixCount.Name = "labPixCount";
            this.labPixCount.Size = new System.Drawing.Size(98, 20);
            this.labPixCount.TabIndex = 33;
            this.labPixCount.Text = "0 px";
            this.labPixCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRand
            // 
            this.btnRand.BackColor = System.Drawing.Color.Black;
            this.btnRand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRand.FlatAppearance.BorderSize = 0;
            this.btnRand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRand.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRand.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRand.Location = new System.Drawing.Point(178, 478);
            this.btnRand.Name = "btnRand";
            this.btnRand.Size = new System.Drawing.Size(171, 46);
            this.btnRand.TabIndex = 37;
            this.btnRand.Text = "Apply";
            this.btnRand.UseVisualStyleBackColor = false;
            this.btnRand.Click += new System.EventHandler(this.btnRand_Click);
            // 
            // labRand2
            // 
            this.labRand2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labRand2.Cursor = System.Windows.Forms.Cursors.Default;
            this.labRand2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labRand2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labRand2.Location = new System.Drawing.Point(28, 493);
            this.labRand2.Name = "labRand2";
            this.labRand2.Size = new System.Drawing.Size(144, 20);
            this.labRand2.TabIndex = 36;
            this.labRand2.Text = "Zarodków";
            this.labRand2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labRand1
            // 
            this.labRand1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labRand1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labRand1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labRand1.Location = new System.Drawing.Point(28, 472);
            this.labRand1.Name = "labRand1";
            this.labRand1.Size = new System.Drawing.Size(144, 20);
            this.labRand1.TabIndex = 35;
            this.labRand1.Text = " Liczba";
            this.labRand1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numRand
            // 
            this.numRand.Location = new System.Drawing.Point(29, 516);
            this.numRand.Name = "numRand";
            this.numRand.Size = new System.Drawing.Size(143, 20);
            this.numRand.TabIndex = 38;
            this.numRand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numJedCount
            // 
            this.numJedCount.Location = new System.Drawing.Point(28, 516);
            this.numJedCount.Name = "numJedCount";
            this.numJedCount.Size = new System.Drawing.Size(143, 20);
            this.numJedCount.TabIndex = 39;
            // 
            // numRadQuantity
            // 
            this.numRadQuantity.Location = new System.Drawing.Point(30, 519);
            this.numRadQuantity.Name = "numRadQuantity";
            this.numRadQuantity.Size = new System.Drawing.Size(143, 20);
            this.numRadQuantity.TabIndex = 47;
            // 
            // btnRadius
            // 
            this.btnRadius.BackColor = System.Drawing.Color.Black;
            this.btnRadius.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRadius.FlatAppearance.BorderSize = 0;
            this.btnRadius.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRadius.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRadius.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRadius.Location = new System.Drawing.Point(179, 486);
            this.btnRadius.Name = "btnRadius";
            this.btnRadius.Size = new System.Drawing.Size(171, 104);
            this.btnRadius.TabIndex = 45;
            this.btnRadius.Text = "Apply";
            this.btnRadius.UseVisualStyleBackColor = false;
            this.btnRadius.Click += new System.EventHandler(this.btnRadius_Click);
            // 
            // labRad2
            // 
            this.labRad2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labRad2.Cursor = System.Windows.Forms.Cursors.Default;
            this.labRad2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labRad2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labRad2.Location = new System.Drawing.Point(29, 496);
            this.labRad2.Name = "labRad2";
            this.labRad2.Size = new System.Drawing.Size(144, 20);
            this.labRad2.TabIndex = 44;
            this.labRad2.Text = "Zarodków";
            this.labRad2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labRad1
            // 
            this.labRad1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labRad1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labRad1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labRad1.Location = new System.Drawing.Point(29, 475);
            this.labRad1.Name = "labRad1";
            this.labRad1.Size = new System.Drawing.Size(144, 20);
            this.labRad1.TabIndex = 43;
            this.labRad1.Text = " Liczba";
            this.labRad1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numRadLen
            // 
            this.numRadLen.Location = new System.Drawing.Point(30, 586);
            this.numRadLen.Name = "numRadLen";
            this.numRadLen.Size = new System.Drawing.Size(143, 20);
            this.numRadLen.TabIndex = 53;
            // 
            // labRad4
            // 
            this.labRad4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labRad4.Cursor = System.Windows.Forms.Cursors.Default;
            this.labRad4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labRad4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labRad4.Location = new System.Drawing.Point(29, 563);
            this.labRad4.Name = "labRad4";
            this.labRad4.Size = new System.Drawing.Size(144, 20);
            this.labRad4.TabIndex = 51;
            this.labRad4.Text = "Promienia";
            this.labRad4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labRad4.Click += new System.EventHandler(this.label9_Click);
            // 
            // labRad3
            // 
            this.labRad3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labRad3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labRad3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labRad3.Location = new System.Drawing.Point(29, 542);
            this.labRad3.Name = "labRad3";
            this.labRad3.Size = new System.Drawing.Size(144, 20);
            this.labRad3.TabIndex = 50;
            this.labRad3.Text = "Długość";
            this.labRad3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(28, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(321, 20);
            this.label3.TabIndex = 55;
            this.label3.Text = "Sąsiedztwo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbNeighborhood
            // 
            this.cbNeighborhood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNeighborhood.FormattingEnabled = true;
            this.cbNeighborhood.Items.AddRange(new object[] {
            "Moore\'a",
            "Von Neumanna",
            "Heksagonalne",
            "Pentagonalne"});
            this.cbNeighborhood.Location = new System.Drawing.Point(28, 308);
            this.cbNeighborhood.Name = "cbNeighborhood";
            this.cbNeighborhood.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbNeighborhood.Size = new System.Drawing.Size(321, 21);
            this.cbNeighborhood.TabIndex = 54;
            this.cbNeighborhood.SelectedIndexChanged += new System.EventHandler(this.cbNeighborhood_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(29, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(321, 20);
            this.label6.TabIndex = 57;
            this.label6.Text = "Warunki brzegowe";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbCondition
            // 
            this.cbCondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCondition.FormattingEnabled = true;
            this.cbCondition.Items.AddRange(new object[] {
            "absorbujące",
            "periodyczne"});
            this.cbCondition.Location = new System.Drawing.Point(29, 381);
            this.cbCondition.Name = "cbCondition";
            this.cbCondition.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbCondition.Size = new System.Drawing.Size(321, 21);
            this.cbCondition.TabIndex = 56;
            // 
            // cbHeks
            // 
            this.cbHeks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbHeks.FormattingEnabled = true;
            this.cbHeks.Items.AddRange(new object[] {
            "z lewej strony",
            "z prawej strony",
            "random"});
            this.cbHeks.Location = new System.Drawing.Point(207, 334);
            this.cbHeks.Name = "cbHeks";
            this.cbHeks.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbHeks.Size = new System.Drawing.Size(142, 21);
            this.cbHeks.TabIndex = 58;
            // 
            // labHex
            // 
            this.labHex.BackColor = System.Drawing.Color.Gray;
            this.labHex.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labHex.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labHex.Location = new System.Drawing.Point(29, 335);
            this.labHex.Name = "labHex";
            this.labHex.Size = new System.Drawing.Size(172, 20);
            this.labHex.TabIndex = 59;
            this.labHex.Text = "Rodzaj sąsiedztwa";
            this.labHex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(985, 693);
            this.Controls.Add(this.labHex);
            this.Controls.Add(this.cbHeks);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbCondition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbNeighborhood);
            this.Controls.Add(this.numRadLen);
            this.Controls.Add(this.labRad4);
            this.Controls.Add(this.labRad3);
            this.Controls.Add(this.numRadQuantity);
            this.Controls.Add(this.btnRadius);
            this.Controls.Add(this.labRad2);
            this.Controls.Add(this.labRad1);
            this.Controls.Add(this.numJedCount);
            this.Controls.Add(this.numRand);
            this.Controls.Add(this.btnRand);
            this.Controls.Add(this.labRand2);
            this.Controls.Add(this.labRand1);
            this.Controls.Add(this.labPixCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnJedDraw);
            this.Controls.Add(this.lbJed2);
            this.Controls.Add(this.lbJed1);
            this.Controls.Add(this.numGridHeight);
            this.Controls.Add(this.numGridWidith);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTypeOfGrid);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGridHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGridWidith)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numJedCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRadQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRadLen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cbTypeOfGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.NumericUpDown numGridHeight;
        private System.Windows.Forms.NumericUpDown numGridWidith;
        private System.Windows.Forms.Label lbJed1;
        private System.Windows.Forms.Label lbJed2;
        private System.Windows.Forms.Button btnJedDraw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labPixCount;
        private System.Windows.Forms.Button btnRand;
        private System.Windows.Forms.Label labRand2;
        private System.Windows.Forms.Label labRand1;
        private System.Windows.Forms.NumericUpDown numRand;
        private System.Windows.Forms.NumericUpDown numJedCount;
        private System.Windows.Forms.NumericUpDown numRadQuantity;
        private System.Windows.Forms.Button btnRadius;
        private System.Windows.Forms.Label labRad2;
        private System.Windows.Forms.Label labRad1;
        private System.Windows.Forms.NumericUpDown numRadLen;
        private System.Windows.Forms.Label labRad4;
        private System.Windows.Forms.Label labRad3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbNeighborhood;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCondition;
        private System.Windows.Forms.ComboBox cbHeks;
        private System.Windows.Forms.Label labHex;
    }
}

