namespace StansGrocery
{
    partial class StansGroceryForm
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
            DisplayListBox = new ListBox();
            FiltersGroupBox = new GroupBox();
            DisplayFilterLabel = new Label();
            FilterComboBox = new ComboBox();
            FilterByCategoryRadioButton = new RadioButton();
            FilterByAisleRadioButton = new RadioButton();
            SearchTextBox = new TextBox();
            SearchButton = new Button();
            SearchBarLabel = new Label();
            TopMenuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            DisplayLabel = new Label();
            FiltersGroupBox.SuspendLayout();
            TopMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // DisplayListBox
            // 
            DisplayListBox.Font = new Font("Source Code Pro", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DisplayListBox.FormattingEnabled = true;
            DisplayListBox.Location = new Point(12, 25);
            DisplayListBox.Name = "DisplayListBox";
            DisplayListBox.Size = new Size(453, 404);
            DisplayListBox.TabIndex = 0;
            DisplayListBox.SelectedIndexChanged += DisplayListBox_SelectedIndexChanged;
            // 
            // FiltersGroupBox
            // 
            FiltersGroupBox.Controls.Add(DisplayFilterLabel);
            FiltersGroupBox.Controls.Add(FilterComboBox);
            FiltersGroupBox.Controls.Add(FilterByCategoryRadioButton);
            FiltersGroupBox.Controls.Add(FilterByAisleRadioButton);
            FiltersGroupBox.Location = new Point(471, 25);
            FiltersGroupBox.Name = "FiltersGroupBox";
            FiltersGroupBox.Size = new Size(317, 120);
            FiltersGroupBox.TabIndex = 1;
            FiltersGroupBox.TabStop = false;
            FiltersGroupBox.Text = "Filters";
            // 
            // DisplayFilterLabel
            // 
            DisplayFilterLabel.AutoSize = true;
            DisplayFilterLabel.Location = new Point(177, 35);
            DisplayFilterLabel.Name = "DisplayFilterLabel";
            DisplayFilterLabel.Size = new Size(79, 15);
            DisplayFilterLabel.TabIndex = 3;
            DisplayFilterLabel.Text = "Display Filters";
            // 
            // FilterComboBox
            // 
            FilterComboBox.FormattingEnabled = true;
            FilterComboBox.Location = new Point(177, 54);
            FilterComboBox.Name = "FilterComboBox";
            FilterComboBox.Size = new Size(121, 23);
            FilterComboBox.TabIndex = 2;
            FilterComboBox.SelectedIndexChanged += FilterComboBox_SelectedIndexChanged;
            // 
            // FilterByCategoryRadioButton
            // 
            FilterByCategoryRadioButton.AutoSize = true;
            FilterByCategoryRadioButton.Location = new Point(16, 73);
            FilterByCategoryRadioButton.Name = "FilterByCategoryRadioButton";
            FilterByCategoryRadioButton.Size = new Size(73, 19);
            FilterByCategoryRadioButton.TabIndex = 1;
            FilterByCategoryRadioButton.TabStop = true;
            FilterByCategoryRadioButton.Text = "Category";
            FilterByCategoryRadioButton.UseVisualStyleBackColor = true;
            FilterByCategoryRadioButton.CheckedChanged += CategoryRadioButton_CheckedChanged;
            // 
            // FilterByAisleRadioButton
            // 
            FilterByAisleRadioButton.AutoSize = true;
            FilterByAisleRadioButton.Location = new Point(16, 35);
            FilterByAisleRadioButton.Name = "FilterByAisleRadioButton";
            FilterByAisleRadioButton.Size = new Size(50, 19);
            FilterByAisleRadioButton.TabIndex = 0;
            FilterByAisleRadioButton.TabStop = true;
            FilterByAisleRadioButton.Text = "Aisle";
            FilterByAisleRadioButton.UseVisualStyleBackColor = true;
            FilterByAisleRadioButton.CheckedChanged += AisleRadioButton_CheckedChanged;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(471, 229);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(211, 23);
            SearchTextBox.TabIndex = 2;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(688, 229);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(100, 23);
            SearchButton.TabIndex = 3;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // SearchBarLabel
            // 
            SearchBarLabel.AutoSize = true;
            SearchBarLabel.Location = new Point(471, 211);
            SearchBarLabel.Name = "SearchBarLabel";
            SearchBarLabel.Size = new Size(62, 15);
            SearchBarLabel.TabIndex = 4;
            SearchBarLabel.Text = "Search Bar";
            // 
            // TopMenuStrip
            // 
            TopMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            TopMenuStrip.Location = new Point(0, 0);
            TopMenuStrip.Name = "TopMenuStrip";
            TopMenuStrip.Size = new Size(797, 24);
            TopMenuStrip.TabIndex = 5;
            TopMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { searchToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(109, 22);
            searchToolStripMenuItem.Text = "Search";
            searchToolStripMenuItem.Click += searchToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(109, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(180, 22);
            aboutToolStripMenuItem.Text = "About";
            // 
            // DisplayLabel
            // 
            DisplayLabel.AutoSize = true;
            DisplayLabel.Location = new Point(484, 313);
            DisplayLabel.Name = "DisplayLabel";
            DisplayLabel.Size = new Size(76, 15);
            DisplayLabel.TabIndex = 6;
            DisplayLabel.Text = "Display Label";
            // 
            // StansGroceryForm
            // 
            AcceptButton = SearchButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 437);
            Controls.Add(DisplayLabel);
            Controls.Add(SearchBarLabel);
            Controls.Add(SearchButton);
            Controls.Add(SearchTextBox);
            Controls.Add(FiltersGroupBox);
            Controls.Add(DisplayListBox);
            Controls.Add(TopMenuStrip);
            MainMenuStrip = TopMenuStrip;
            Name = "StansGroceryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stans Grocery";
            FiltersGroupBox.ResumeLayout(false);
            FiltersGroupBox.PerformLayout();
            TopMenuStrip.ResumeLayout(false);
            TopMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox DisplayListBox;
        private GroupBox FiltersGroupBox;
        private RadioButton FilterByCategoryRadioButton;
        private RadioButton FilterByAisleRadioButton;
        private TextBox SearchTextBox;
        private Button SearchButton;
        private Label DisplayFilterLabel;
        private ComboBox FilterComboBox;
        private Label SearchBarLabel;
        private MenuStrip TopMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Label DisplayLabel;
    }
}
