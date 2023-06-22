namespace AutomobileWinApp
{
    partial class frmCarDetails
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
            IbCarID = new Label();
            txtCarID = new TextBox();
            txtCarName = new TextBox();
            lbCarName = new Label();
            lbPrice = new Label();
            txtPrice = new MaskedTextBox();
            txtReleaseYear = new MaskedTextBox();
            lbReleaseYear = new Label();
            lbManufacturer = new Label();
            cboManufacturer = new ComboBox();
            btnSave = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // IbCarID
            // 
            IbCarID.AutoSize = true;
            IbCarID.Location = new Point(38, 61);
            IbCarID.Name = "IbCarID";
            IbCarID.Size = new Size(50, 20);
            IbCarID.TabIndex = 0;
            IbCarID.Text = "Car ID";
            IbCarID.Click += label1_Click_1;
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(149, 59);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(204, 27);
            txtCarID.TabIndex = 1;
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(149, 100);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(204, 27);
            txtCarName.TabIndex = 5;
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new Point(38, 104);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(75, 20);
            lbCarName.TabIndex = 4;
            lbCarName.Text = "Car Name";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(38, 185);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(41, 20);
            lbPrice.TabIndex = 6;
            lbPrice.Text = "Price";
            lbPrice.Click += label1_Click_2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(149, 181);
            txtPrice.Mask = " 000000000";
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(204, 27);
            txtPrice.TabIndex = 8;
            txtPrice.Text = "0";
            txtPrice.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(149, 213);
            txtReleaseYear.Mask = "0000";
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(204, 27);
            txtReleaseYear.TabIndex = 10;
            txtReleaseYear.Text = "0";
            txtReleaseYear.MaskInputRejected += maskedTextBox2_MaskInputRejected;
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Location = new Point(38, 219);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new Size(88, 20);
            lbReleaseYear.TabIndex = 9;
            lbReleaseYear.Text = "ReleaseYear";
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new Point(38, 147);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new Size(97, 20);
            lbManufacturer.TabIndex = 11;
            lbManufacturer.Text = "Manufacturer";
            lbManufacturer.Click += label3_Click;
            // 
            // cboManufacturer
            // 
            cboManufacturer.FormattingEnabled = true;
            cboManufacturer.Items.AddRange(new object[] { "Audi", "BMW", "Ford", "Honda", "Hyundai", "Kia", "Suzuki", "Toyota" });
            cboManufacturer.Location = new Point(151, 143);
            cboManufacturer.Name = "cboManufacturer";
            cboManufacturer.Size = new Size(202, 28);
            cboManufacturer.TabIndex = 12;
            cboManufacturer.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(149, 266);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(279, 266);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmCarDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cboManufacturer);
            Controls.Add(lbManufacturer);
            Controls.Add(txtReleaseYear);
            Controls.Add(lbReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(lbPrice);
            Controls.Add(txtCarName);
            Controls.Add(lbCarName);
            Controls.Add(txtCarID);
            Controls.Add(IbCarID);
            Name = "frmCarDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCarDetails";
            Load += frmCarDetails_Load_1;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IbCarID;
        private TextBox txtCarID;
        private TextBox txtCarName;
        private Label lbCarName;
        private Label lbPrice;
        private MaskedTextBox txtPrice;
        private MaskedTextBox txtReleaseYear;
        private Label lbReleaseYear;
        private Label lbManufacturer;
        private ComboBox cboManufacturer;
        private Button btnSave;
        private FileSystemWatcher fileSystemWatcher1;
        private Button btnCancel;
    }
}