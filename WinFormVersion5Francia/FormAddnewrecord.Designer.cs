namespace WinFormVersion5Francia
{
    partial class FormAddnewrecord
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label accountTypeLabel;
            System.Windows.Forms.Label initialDepositLabel;
            System.Windows.Forms.Label passwordLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddnewrecord));
            this.passwordchecktxtbox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.accountTypeComboBox = new System.Windows.Forms.ComboBox();
            this.initialDepositNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.createrecordbtn = new System.Windows.Forms.Button();
            this.database1DataSet = new WinFormVersion5Francia.Database1DataSet();
            this.kBrecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kBrecordsTableAdapter = new WinFormVersion5Francia.Database1DataSetTableAdapters.KBrecordsTableAdapter();
            this.tableAdapterManager = new WinFormVersion5Francia.Database1DataSetTableAdapters.TableAdapterManager();
            this.kBrecordsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.kBrecordsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.kBrecordsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label1 = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            accountTypeLabel = new System.Windows.Forms.Label();
            initialDepositLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.initialDepositNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kBrecordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kBrecordsBindingNavigator)).BeginInit();
            this.kBrecordsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kBrecordsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(26, 209);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(94, 13);
            label1.TabIndex = 73;
            label1.Text = "Confirm Password:";
            // 
            // passwordchecktxtbox
            // 
            this.passwordchecktxtbox.Location = new System.Drawing.Point(127, 202);
            this.passwordchecktxtbox.Name = "passwordchecktxtbox";
            this.passwordchecktxtbox.Size = new System.Drawing.Size(121, 20);
            this.passwordchecktxtbox.TabIndex = 72;
            this.passwordchecktxtbox.UseSystemPasswordChar = true;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(26, 48);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 60;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(127, 45);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(121, 20);
            this.emailTextBox.TabIndex = 61;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(26, 74);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(60, 13);
            firstNameLabel.TabIndex = 62;
            firstNameLabel.Text = "First Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(127, 71);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.firstNameTextBox.TabIndex = 63;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(26, 100);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 64;
            lastNameLabel.Text = "Last Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(127, 97);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.lastNameTextBox.TabIndex = 65;
            // 
            // accountTypeLabel
            // 
            accountTypeLabel.AutoSize = true;
            accountTypeLabel.Location = new System.Drawing.Point(26, 126);
            accountTypeLabel.Name = "accountTypeLabel";
            accountTypeLabel.Size = new System.Drawing.Size(77, 13);
            accountTypeLabel.TabIndex = 66;
            accountTypeLabel.Text = "Account Type:";
            // 
            // accountTypeComboBox
            // 
            this.accountTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accountTypeComboBox.FormattingEnabled = true;
            this.accountTypeComboBox.Items.AddRange(new object[] {
            "Savings",
            "Current"});
            this.accountTypeComboBox.Location = new System.Drawing.Point(127, 123);
            this.accountTypeComboBox.Name = "accountTypeComboBox";
            this.accountTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.accountTypeComboBox.TabIndex = 67;
            // 
            // initialDepositLabel
            // 
            initialDepositLabel.AutoSize = true;
            initialDepositLabel.Location = new System.Drawing.Point(26, 150);
            initialDepositLabel.Name = "initialDepositLabel";
            initialDepositLabel.Size = new System.Drawing.Size(73, 13);
            initialDepositLabel.TabIndex = 68;
            initialDepositLabel.Text = "Initial Deposit:";
            // 
            // initialDepositNumericUpDown
            // 
            this.initialDepositNumericUpDown.Location = new System.Drawing.Point(127, 150);
            this.initialDepositNumericUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.initialDepositNumericUpDown.Name = "initialDepositNumericUpDown";
            this.initialDepositNumericUpDown.Size = new System.Drawing.Size(121, 20);
            this.initialDepositNumericUpDown.TabIndex = 69;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(26, 179);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 70;
            passwordLabel.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(127, 176);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(121, 20);
            this.passwordTextBox.TabIndex = 71;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // createrecordbtn
            // 
            this.createrecordbtn.Location = new System.Drawing.Point(134, 228);
            this.createrecordbtn.Name = "createrecordbtn";
            this.createrecordbtn.Size = new System.Drawing.Size(114, 23);
            this.createrecordbtn.TabIndex = 59;
            this.createrecordbtn.Text = "Create Record";
            this.createrecordbtn.UseVisualStyleBackColor = true;
            this.createrecordbtn.Click += new System.EventHandler(this.createrecordbtn_Click);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kBrecordsBindingSource
            // 
            this.kBrecordsBindingSource.DataMember = "KBrecords";
            this.kBrecordsBindingSource.DataSource = this.database1DataSet;
            // 
            // kBrecordsTableAdapter
            // 
            this.kBrecordsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KBrecordsTableAdapter = this.kBrecordsTableAdapter;
            this.tableAdapterManager.UpdateOrder = WinFormVersion5Francia.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // kBrecordsBindingNavigator
            // 
            this.kBrecordsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.kBrecordsBindingNavigator.BindingSource = this.kBrecordsBindingSource;
            this.kBrecordsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.kBrecordsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.kBrecordsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.kBrecordsBindingNavigatorSaveItem});
            this.kBrecordsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.kBrecordsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.kBrecordsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.kBrecordsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.kBrecordsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.kBrecordsBindingNavigator.Name = "kBrecordsBindingNavigator";
            this.kBrecordsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.kBrecordsBindingNavigator.Size = new System.Drawing.Size(671, 25);
            this.kBrecordsBindingNavigator.TabIndex = 74;
            this.kBrecordsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // kBrecordsBindingNavigatorSaveItem
            // 
            this.kBrecordsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kBrecordsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("kBrecordsBindingNavigatorSaveItem.Image")));
            this.kBrecordsBindingNavigatorSaveItem.Name = "kBrecordsBindingNavigatorSaveItem";
            this.kBrecordsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.kBrecordsBindingNavigatorSaveItem.Text = "Save Data";
            this.kBrecordsBindingNavigatorSaveItem.Click += new System.EventHandler(this.kBrecordsBindingNavigatorSaveItem_Click);
            // 
            // kBrecordsDataGridView
            // 
            this.kBrecordsDataGridView.AutoGenerateColumns = false;
            this.kBrecordsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kBrecordsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.kBrecordsDataGridView.DataSource = this.kBrecordsBindingSource;
            this.kBrecordsDataGridView.Location = new System.Drawing.Point(12, 275);
            this.kBrecordsDataGridView.Name = "kBrecordsDataGridView";
            this.kBrecordsDataGridView.Size = new System.Drawing.Size(643, 220);
            this.kBrecordsDataGridView.TabIndex = 74;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn1.HeaderText = "Email";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "AccountType";
            this.dataGridViewTextBoxColumn4.HeaderText = "AccountType";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Balance";
            this.dataGridViewTextBoxColumn5.HeaderText = "Balance";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn6.HeaderText = "Password";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // FormAddnewrecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 507);
            this.Controls.Add(this.kBrecordsDataGridView);
            this.Controls.Add(this.kBrecordsBindingNavigator);
            this.Controls.Add(label1);
            this.Controls.Add(this.passwordchecktxtbox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(accountTypeLabel);
            this.Controls.Add(this.accountTypeComboBox);
            this.Controls.Add(initialDepositLabel);
            this.Controls.Add(this.initialDepositNumericUpDown);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.createrecordbtn);
            this.Name = "FormAddnewrecord";
            this.Text = "FormAddnewrecord";
            this.Load += new System.EventHandler(this.FormAddnewrecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.initialDepositNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kBrecordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kBrecordsBindingNavigator)).EndInit();
            this.kBrecordsBindingNavigator.ResumeLayout(false);
            this.kBrecordsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kBrecordsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordchecktxtbox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.ComboBox accountTypeComboBox;
        private System.Windows.Forms.NumericUpDown initialDepositNumericUpDown;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button createrecordbtn;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource kBrecordsBindingSource;
        private Database1DataSetTableAdapters.KBrecordsTableAdapter kBrecordsTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator kBrecordsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton kBrecordsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView kBrecordsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}