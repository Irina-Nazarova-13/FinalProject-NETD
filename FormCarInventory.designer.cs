
namespace Lab4
{
    partial class formCarInventory
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
            this.components = new System.ComponentModel.Container();
            this.labelMake = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.comboBoxMake = new System.Windows.Forms.ComboBox();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.listViewOutput = new System.Windows.Forms.ListView();
            this.columnHeaderNew = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderID = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderMake = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderModel = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderYear = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderPrice = new System.Windows.Forms.ColumnHeader();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.richTextBoxMessage = new System.Windows.Forms.RichTextBox();
            this.toolTipForFormCarInventory = new System.Windows.Forms.ToolTip(this.components);
            this.checkBoxNew = new System.Windows.Forms.CheckBox();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMake
            // 
            this.labelMake.Location = new System.Drawing.Point(175, 20);
            this.labelMake.Name = "labelMake";
            this.labelMake.Size = new System.Drawing.Size(60, 23);
            this.labelMake.TabIndex = 0;
            this.labelMake.Text = "&Make: ";
            this.labelMake.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelModel
            // 
            this.labelModel.Location = new System.Drawing.Point(175, 58);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(65, 23);
            this.labelModel.TabIndex = 2;
            this.labelModel.Text = "M&odel: ";
            this.labelModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelYear
            // 
            this.labelYear.Location = new System.Drawing.Point(177, 96);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(55, 23);
            this.labelYear.TabIndex = 4;
            this.labelYear.Text = "&Year: ";
            this.labelYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPrice
            // 
            this.labelPrice.Location = new System.Drawing.Point(175, 134);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(57, 23);
            this.labelPrice.TabIndex = 6;
            this.labelPrice.Text = "&Price: ";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxModel
            // 
            this.textBoxModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(226)))));
            this.textBoxModel.Location = new System.Drawing.Point(278, 55);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(181, 30);
            this.textBoxModel.TabIndex = 3;
            this.toolTipForFormCarInventory.SetToolTip(this.textBoxModel, "Enter the Model of a car");
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(226)))));
            this.textBoxPrice.Location = new System.Drawing.Point(278, 131);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(181, 30);
            this.textBoxPrice.TabIndex = 7;
            this.toolTipForFormCarInventory.SetToolTip(this.textBoxPrice, "Enter the price of the car");
            // 
            // comboBoxMake
            // 
            this.comboBoxMake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(226)))));
            this.comboBoxMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMake.FormattingEnabled = true;
            this.comboBoxMake.Items.AddRange(new object[] {
            "Volkswagen Group",
            "Toyota",
            "Renault–Nissan–Mitsubishi Alliance",
            "General Motors",
            "Hyundai Motor Group",
            "Ford",
            "Honda Motor Group",
            "Fiat Chrysler Automobiles",
            "Groupe PSA",
            "Suzuki"});
            this.comboBoxMake.Location = new System.Drawing.Point(278, 17);
            this.comboBoxMake.Name = "comboBoxMake";
            this.comboBoxMake.Size = new System.Drawing.Size(181, 31);
            this.comboBoxMake.TabIndex = 1;
            this.toolTipForFormCarInventory.SetToolTip(this.comboBoxMake, "Choose the make of the car");
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(226)))));
            this.comboBoxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Items.AddRange(new object[] {
            "2021",
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980",
            "1979",
            "1978",
            "1977",
            "1976",
            "1975",
            "1974",
            "1973",
            "1972",
            "1971",
            "1970",
            "1969",
            "1968",
            "1967",
            "1966",
            "1965",
            "1964",
            "1963",
            "1962",
            "1961",
            "1960",
            "1959",
            "1958",
            "1957",
            "1956",
            "1955",
            "1954",
            "1953",
            "1952",
            "1951",
            "1950",
            "1949",
            "1948",
            "1947",
            "1946",
            "1945",
            "1944",
            "1943",
            "1942",
            "1941",
            "1940",
            "1939",
            "1938",
            "1937",
            "1936",
            "1935",
            "1934",
            "1933",
            "1932",
            "1931",
            "1930",
            "1929",
            "1928",
            "1927",
            "1926",
            "1925",
            "1924",
            "1923",
            "1922",
            "1921",
            "1920",
            "1919",
            "1918",
            "1917",
            "1916",
            "1915",
            "1914",
            "1913",
            "1912",
            "1911",
            "1910",
            "1909",
            "1908",
            "1907",
            "1906",
            "1905",
            "1904",
            "1903",
            "1902",
            "1901",
            "1900"});
            this.comboBoxYear.Location = new System.Drawing.Point(278, 93);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(181, 31);
            this.comboBoxYear.TabIndex = 5;
            this.toolTipForFormCarInventory.SetToolTip(this.comboBoxYear, "Choose the Year of a Car");
            // 
            // listViewOutput
            // 
            this.listViewOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(226)))));
            this.listViewOutput.CheckBoxes = true;
            this.listViewOutput.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNew,
            this.columnHeaderID,
            this.columnHeaderMake,
            this.columnHeaderModel,
            this.columnHeaderYear,
            this.columnHeaderPrice});
            this.listViewOutput.FullRowSelect = true;
            this.listViewOutput.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewOutput.HideSelection = false;
            this.listViewOutput.Location = new System.Drawing.Point(49, 230);
            this.listViewOutput.MultiSelect = false;
            this.listViewOutput.Name = "listViewOutput";
            this.listViewOutput.Size = new System.Drawing.Size(507, 202);
            this.listViewOutput.TabIndex = 9;
            this.listViewOutput.UseCompatibleStateImageBehavior = false;
            this.listViewOutput.View = System.Windows.Forms.View.Details;
            this.listViewOutput.SelectedIndexChanged += new System.EventHandler(this.CarChosen);
            // 
            // columnHeaderNew
            // 
            this.columnHeaderNew.Text = "New";
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            // 
            // columnHeaderMake
            // 
            this.columnHeaderMake.Text = "Make";
            this.columnHeaderMake.Width = 100;
            // 
            // columnHeaderModel
            // 
            this.columnHeaderModel.Text = "Model";
            this.columnHeaderModel.Width = 105;
            // 
            // columnHeaderYear
            // 
            this.columnHeaderYear.Text = "Year";
            this.columnHeaderYear.Width = 80;
            // 
            // columnHeaderPrice
            // 
            this.columnHeaderPrice.Text = "Price";
            this.columnHeaderPrice.Width = 95;
            // 
            // buttonEnter
            // 
            this.buttonEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(226)))));
            this.buttonEnter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEnter.Location = new System.Drawing.Point(49, 612);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(75, 34);
            this.buttonEnter.TabIndex = 11;
            this.buttonEnter.Text = "&Submit";
            this.toolTipForFormCarInventory.SetToolTip(this.buttonEnter, "Press Submit to enter data");
            this.buttonEnter.UseVisualStyleBackColor = false;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(226)))));
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReset.Location = new System.Drawing.Point(262, 612);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 34);
            this.buttonReset.TabIndex = 12;
            this.buttonReset.Text = "&Reset";
            this.toolTipForFormCarInventory.SetToolTip(this.buttonReset, "Press Reset to reset the form");
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(226)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExit.Location = new System.Drawing.Point(481, 612);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 34);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.Text = "&Exit";
            this.toolTipForFormCarInventory.SetToolTip(this.buttonExit, "press Exit to close the form");
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // richTextBoxMessage
            // 
            this.richTextBoxMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(207)))));
            this.richTextBoxMessage.Location = new System.Drawing.Point(49, 447);
            this.richTextBoxMessage.Name = "richTextBoxMessage";
            this.richTextBoxMessage.ReadOnly = true;
            this.richTextBoxMessage.Size = new System.Drawing.Size(507, 92);
            this.richTextBoxMessage.TabIndex = 10;
            this.richTextBoxMessage.Text = "";
            // 
            // checkBoxNew
            // 
            this.checkBoxNew.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxNew.Location = new System.Drawing.Point(175, 177);
            this.checkBoxNew.Name = "checkBoxNew";
            this.checkBoxNew.Size = new System.Drawing.Size(120, 36);
            this.checkBoxNew.TabIndex = 8;
            this.checkBoxNew.Text = "&New";
            this.toolTipForFormCarInventory.SetToolTip(this.checkBoxNew, "Check the box if the car is new");
            this.checkBoxNew.UseVisualStyleBackColor = true;
            // 
            // labelError
            // 
            this.labelError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(7)))), ((int)(((byte)(84)))));
            this.labelError.Location = new System.Drawing.Point(49, 558);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(507, 40);
            this.labelError.TabIndex = 23;
            this.labelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formCarInventory
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(602, 668);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.checkBoxNew);
            this.Controls.Add(this.richTextBoxMessage);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.listViewOutput);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.comboBoxMake);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.labelMake);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formCarInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Inventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMake;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.ComboBox comboBoxMake;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.ListView listViewOutput;
        private System.Windows.Forms.ColumnHeader columnHeaderNew;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderMake;
        private System.Windows.Forms.ColumnHeader columnHeaderModel;
        private System.Windows.Forms.ColumnHeader columnHeaderYear;
        private System.Windows.Forms.ColumnHeader columnHeaderPrice;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.RichTextBox richTextBoxMessage;
        private System.Windows.Forms.ToolTip toolTipForFormCarInventory;
        private System.Windows.Forms.CheckBox checkBoxNew;
        private System.Windows.Forms.Label labelError;
    }
}

