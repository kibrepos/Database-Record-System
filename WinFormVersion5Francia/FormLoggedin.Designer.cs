namespace WinFormVersion5Francia
{
    partial class FormLoggedin
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
            this.transferButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.database1DataSet = new WinFormVersion5Francia.Database1DataSet();
            this.kBrecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kBrecordsTableAdapter = new WinFormVersion5Francia.Database1DataSetTableAdapters.KBrecordsTableAdapter();
            this.tableAdapterManager = new WinFormVersion5Francia.Database1DataSetTableAdapters.TableAdapterManager();
            this.kBrecordsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.transfertextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kBrecordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kBrecordsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // transferButton
            // 
            this.transferButton.Location = new System.Drawing.Point(45, 202);
            this.transferButton.Name = "transferButton";
            this.transferButton.Size = new System.Drawing.Size(132, 32);
            this.transferButton.TabIndex = 0;
            this.transferButton.Text = "Transfer";
            this.transferButton.UseVisualStyleBackColor = true;
            this.transferButton.Click += new System.EventHandler(this.transferButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(45, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Deposit";
            this.button2.UseVisualStyleBackColor = true;
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
            // kBrecordsDataGridView
            // 
            this.kBrecordsDataGridView.AutoGenerateColumns = false;
            this.kBrecordsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kBrecordsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.kBrecordsDataGridView.DataSource = this.kBrecordsBindingSource;
            this.kBrecordsDataGridView.Location = new System.Drawing.Point(238, 102);
            this.kBrecordsDataGridView.Name = "kBrecordsDataGridView";
            this.kBrecordsDataGridView.ReadOnly = true;
            this.kBrecordsDataGridView.Size = new System.Drawing.Size(538, 220);
            this.kBrecordsDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn1.HeaderText = "Email";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "AccountType";
            this.dataGridViewTextBoxColumn4.HeaderText = "AccountType";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Balance";
            this.dataGridViewTextBoxColumn5.HeaderText = "Balance";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Transfer to:";
            // 
            // transfertextbox
            // 
            this.transfertextbox.Location = new System.Drawing.Point(45, 118);
            this.transfertextbox.Name = "transfertextbox";
            this.transfertextbox.Size = new System.Drawing.Size(100, 20);
            this.transfertextbox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Logged in to: ";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(110, 37);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 8;
            this.emailLabel.Text = "label2";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(45, 176);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Amount:";
            // 
            // FormLoggedin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.transfertextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kBrecordsDataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.transferButton);
            this.Name = "FormLoggedin";
            this.Text = "FormLoggedin";
            this.Load += new System.EventHandler(this.FormLoggedin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kBrecordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kBrecordsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button transferButton;
        private System.Windows.Forms.Button button2;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource kBrecordsBindingSource;
        private Database1DataSetTableAdapters.KBrecordsTableAdapter kBrecordsTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView kBrecordsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox transfertextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
    }
}