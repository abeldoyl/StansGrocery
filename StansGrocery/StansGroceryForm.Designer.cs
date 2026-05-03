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
            CategoryRadioButton = new RadioButton();
            AisleRadioButton = new RadioButton();
            SearchTextBox = new TextBox();
            SearchButton = new Button();
            SearchBarLabel = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            FiltersGroupBox.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // DisplayListBox
            // 
            DisplayListBox.FormattingEnabled = true;
            DisplayListBox.Location = new Point(12, 25);
            DisplayListBox.Name = "DisplayListBox";
            DisplayListBox.Size = new Size(453, 409);
            DisplayListBox.TabIndex = 0;
            // 
            // FiltersGroupBox
            // 
            FiltersGroupBox.Controls.Add(DisplayFilterLabel);
            FiltersGroupBox.Controls.Add(FilterComboBox);
            FiltersGroupBox.Controls.Add(CategoryRadioButton);
            FiltersGroupBox.Controls.Add(AisleRadioButton);
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
            // 
            // CategoryRadioButton
            // 
            CategoryRadioButton.AutoSize = true;
            CategoryRadioButton.Location = new Point(16, 73);
            CategoryRadioButton.Name = "CategoryRadioButton";
            CategoryRadioButton.Size = new Size(73, 19);
            CategoryRadioButton.TabIndex = 1;
            CategoryRadioButton.TabStop = true;
            CategoryRadioButton.Text = "Category";
            CategoryRadioButton.UseVisualStyleBackColor = true;
            // 
            // AisleRadioButton
            // 
            AisleRadioButton.AutoSize = true;
            AisleRadioButton.Location = new Point(16, 35);
            AisleRadioButton.Name = "AisleRadioButton";
            AisleRadioButton.Size = new Size(50, 19);
            AisleRadioButton.TabIndex = 0;
            AisleRadioButton.TabStop = true;
            AisleRadioButton.Text = "Aisle";
            AisleRadioButton.UseVisualStyleBackColor = true;
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
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
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
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(109, 22);
            exitToolStripMenuItem.Text = "Exit";
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
            aboutToolStripMenuItem.Size = new Size(107, 22);
            aboutToolStripMenuItem.Text = "About";
            // 
            // StansGroceryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SearchBarLabel);
            Controls.Add(SearchButton);
            Controls.Add(SearchTextBox);
            Controls.Add(FiltersGroupBox);
            Controls.Add(DisplayListBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "StansGroceryForm";
            Text = "Stans Grocery";
            FiltersGroupBox.ResumeLayout(false);
            FiltersGroupBox.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox DisplayListBox;
        private GroupBox FiltersGroupBox;
        private RadioButton CategoryRadioButton;
        private RadioButton AisleRadioButton;
        private TextBox SearchTextBox;
        private Button SearchButton;
        private Label DisplayFilterLabel;
        private ComboBox FilterComboBox;
        private Label SearchBarLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}
