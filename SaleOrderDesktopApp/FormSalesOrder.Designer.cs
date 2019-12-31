namespace SaleOrderDesktopApp
{
    partial class FormSalesOrder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtOrderDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtPostingDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSalesPerson = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtDocDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCustomerName = new System.Windows.Forms.ComboBox();
            this.textBoxCustomerID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSalesOrderID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgSODetails = new System.Windows.Forms.DataGridView();
            this.Del = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSODetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtOrderDate);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dtPostingDate);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmbSalesPerson);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtDeliveryDate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtDocDate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxCity);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbCustomerName);
            this.panel1.Controls.Add(this.textBoxCustomerID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxSalesOrderID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 192);
            this.panel1.TabIndex = 1;
            // 
            // dtOrderDate
            // 
            this.dtOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtOrderDate.Location = new System.Drawing.Point(934, 144);
            this.dtOrderDate.Name = "dtOrderDate";
            this.dtOrderDate.Size = new System.Drawing.Size(136, 20);
            this.dtOrderDate.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(864, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Order Date";
            // 
            // dtPostingDate
            // 
            this.dtPostingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPostingDate.Location = new System.Drawing.Point(934, 109);
            this.dtPostingDate.Name = "dtPostingDate";
            this.dtPostingDate.Size = new System.Drawing.Size(136, 20);
            this.dtPostingDate.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(855, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Posting Date";
            // 
            // cmbSalesPerson
            // 
            this.cmbSalesPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalesPerson.FormattingEnabled = true;
            this.cmbSalesPerson.Location = new System.Drawing.Point(934, 76);
            this.cmbSalesPerson.Name = "cmbSalesPerson";
            this.cmbSalesPerson.Size = new System.Drawing.Size(136, 21);
            this.cmbSalesPerson.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(851, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sales  Person";
            // 
            // dtDeliveryDate
            // 
            this.dtDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDeliveryDate.Location = new System.Drawing.Point(934, 42);
            this.dtDeliveryDate.Name = "dtDeliveryDate";
            this.dtDeliveryDate.Size = new System.Drawing.Size(136, 20);
            this.dtDeliveryDate.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(852, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Delivery Date";
            // 
            // dtDocDate
            // 
            this.dtDocDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDocDate.Location = new System.Drawing.Point(934, 14);
            this.dtDocDate.Name = "dtDocDate";
            this.dtDocDate.Size = new System.Drawing.Size(136, 20);
            this.dtDocDate.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(870, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Doc Date";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(77, 76);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.ReadOnly = true;
            this.textBoxCity.Size = new System.Drawing.Size(53, 20);
            this.textBoxCity.TabIndex = 6;
            this.textBoxCity.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "City";
            // 
            // cmbCustomerName
            // 
            this.cmbCustomerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomerName.FormattingEnabled = true;
            this.cmbCustomerName.Location = new System.Drawing.Point(139, 45);
            this.cmbCustomerName.Name = "cmbCustomerName";
            this.cmbCustomerName.Size = new System.Drawing.Size(308, 21);
            this.cmbCustomerName.TabIndex = 4;
            this.cmbCustomerName.SelectedIndexChanged += new System.EventHandler(this.cmbCustomerName_SelectedIndexChanged);
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.Location = new System.Drawing.Point(77, 45);
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.ReadOnly = true;
            this.textBoxCustomerID.Size = new System.Drawing.Size(53, 20);
            this.textBoxCustomerID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer";
            // 
            // textBoxSalesOrderID
            // 
            this.textBoxSalesOrderID.Location = new System.Drawing.Point(77, 14);
            this.textBoxSalesOrderID.Name = "textBoxSalesOrderID";
            this.textBoxSalesOrderID.ReadOnly = true;
            this.textBoxSalesOrderID.Size = new System.Drawing.Size(53, 20);
            this.textBoxSalesOrderID.TabIndex = 1;
            this.textBoxSalesOrderID.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "So No.";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Location = new System.Drawing.Point(14, 340);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1090, 73);
            this.panel2.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(907, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 13);
            this.label12.TabIndex = 9;
            this.label12.Tag = "";
            this.label12.Text = "Invoice Discount";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(909, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Line Amout Total";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Total";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(126, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Invoice Discount Amount";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgSODetails);
            this.panel3.Location = new System.Drawing.Point(11, 206);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1093, 128);
            this.panel3.TabIndex = 19;
            // 
            // dgSODetails
            // 
            this.dgSODetails.AllowUserToDeleteRows = false;
            this.dgSODetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSODetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Del,
            this.Item,
            this.Description,
            this.LocationCode,
            this.Quantity,
            this.UOM,
            this.Price,
            this.Discount,
            this.Amount});
            this.dgSODetails.Location = new System.Drawing.Point(4, 7);
            this.dgSODetails.Name = "dgSODetails";
            this.dgSODetails.Size = new System.Drawing.Size(1086, 107);
            this.dgSODetails.TabIndex = 0;
            this.dgSODetails.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgSODetails_CellMouseClick);
            this.dgSODetails.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSODetails_CellValueChanged);
            // 
            // Del
            // 
            this.Del.Frozen = true;
            this.Del.HeaderText = "";
            this.Del.Name = "Del";
            this.Del.Width = 25;
            // 
            // Item
            // 
            this.Item.Frozen = true;
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            // 
            // Description
            // 
            this.Description.Frozen = true;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 200;
            // 
            // LocationCode
            // 
            this.LocationCode.Frozen = true;
            this.LocationCode.HeaderText = "Location Code";
            this.LocationCode.Name = "LocationCode";
            // 
            // Quantity
            // 
            this.Quantity.Frozen = true;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 125;
            // 
            // UOM
            // 
            this.UOM.Frozen = true;
            this.UOM.HeaderText = "UOM";
            this.UOM.Name = "UOM";
            this.UOM.ReadOnly = true;
            this.UOM.Width = 80;
            // 
            // Price
            // 
            this.Price.Frozen = true;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.Width = 175;
            // 
            // Discount
            // 
            this.Discount.Frozen = true;
            this.Discount.HeaderText = "Discount";
            this.Discount.Name = "Discount";
            // 
            // Amount
            // 
            this.Amount.Frozen = true;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 175;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 419);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 20;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(1026, 419);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 21;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormSalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 450);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FormSalesOrder";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo Sales Order";
            this.Load += new System.EventHandler(this.FormSalesOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSODetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxSalesOrderID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCustomerID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCustomerName;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtDocDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtDeliveryDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSalesPerson;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtPostingDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtOrderDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DataGridView dgSODetails;
        private System.Windows.Forms.DataGridViewButtonColumn Del;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}

