/*
Abel Doyle
RCET 2265
Spring Semester 2026
StansGrocery
https://github.com/abeldoyl/StansGrocery.git
*/
namespace StansGrocery
{
    public partial class StansGroceryForm : Form
    {
        public StansGroceryForm()
        {
            ShowSplashForm();
            InitializeComponent();
            FileToArray(filePath);
            SetDefaults();
            DisplayData();
        }

        // Custom Methods Below -------------------------------------------------------------------

        string[,] customerData = new string[0, 0];
        string filePath = "..\\..\\..\\..\\Grocery.txt";

        private void SetDefaults()
        {
            FilterByAisleRadioButton.Checked = true;
            LoadFilterComboBox();
            DisplayLabel.Text = "";
        }
        int CountOfLinesIn(string filePath)
        {
            int count = 0;
            using (StreamReader testFile = new StreamReader(filePath))
            {
                while (testFile.ReadLine() != null)
                    count++;
            }
            return count;
        }

        string CleanFile(string input)
        {
            return input
                .Replace("\"", "") // remove quotes
                .Replace("$", "") // remove dollar signs
                .Replace("#", "") // remove hash symbols
                .Replace("%", "") // remove percent signs
                .Replace("ITM", "") // remove "ITM" prefix
                .Replace("LOC", "") // remove "LOC" prefix
                .Replace("CAT", "") // remove "CAT" prefix
                .Trim(); // remove leading and trailing whitespace
        }

        void FileToArray(string filePath)
        {
            string[,] _customerData = new string[3, CountOfLinesIn(filePath)];
            string[] temp;
            int counter = 0;

            using (StreamReader testFile = new StreamReader(filePath))
            {
                do
                {
                    temp = testFile.ReadLine().Split(',');

                    if (temp.Length >= 3)
                    {
                        for (int i = 0; i < temp.Length && i < 4; i++)
                        {
                            _customerData[i, counter] = CleanFile(temp[i]);
                        }
                    }

                    counter++;
                } while (!testFile.EndOfStream);
            }

            this.customerData = _customerData;
        }
        void DisplayData()
        {
            string[,] data = this.customerData;
            int filterColumn = FilterByAisleRadioButton.Checked ? 1 : 2;

            DisplayListBox.Items.Clear();

            var rows = new List<(int sortKey, string display)>();


            for (int row = 0; row < data.GetLength(1); row++)
            {
                string formattedRow = "";
                for (int column = 0; column < data.GetLength(0); column++)
                {
                    if (data[column, row] != null && (FilterComboBox.SelectedItem.ToString() ==
                        "~Show All~" || data[filterColumn, row]
                        == FilterComboBox.SelectedItem.ToString()))
                    {
                        formattedRow = $"{data[0, row],-25} {data[1, row],-5} {data[2, row],-25}";
                    }
                }

                if (formattedRow != "" && formattedRow.Contains
                    (SearchTextBox.Text, StringComparison.InvariantCultureIgnoreCase))
                {
                    int.TryParse(data[1, row], out int aisleNum);
                    rows.Add((aisleNum, formattedRow));
                }
            }

            foreach (var r in rows.OrderBy(r => r.sortKey))
                DisplayListBox.Items.Add(r.display);
        }

        void LoadFilterComboBox()
        {
            int column = 1;
            FilterComboBox.Items.Clear();

            switch (true)
            {
                case bool when FilterByAisleRadioButton.Checked:
                    column = 1;
                    break;
                case bool when FilterByCategoryRadioButton.Checked:
                    column = 2;
                    break;
            }

            for (int row = 0; row < this.customerData.GetUpperBound(1); row++)
            {
                if (this.customerData[column, row] != null &&
                    !FilterComboBox.Items.Contains(this.customerData[column, row]))
                {
                    FilterComboBox.Items.Add(this.customerData[column, row]);
                }
            }

            // Sort numerically for aisles, alphabetically for categories
            List<string> items;
            if (FilterByAisleRadioButton.Checked)
                items = FilterComboBox.Items.Cast<string>().OrderByDescending
                    (x => int.TryParse(x, out int n) ? n : int.MaxValue).ToList();
            else
                items = FilterComboBox.Items.Cast<string>().OrderBy(x => x).ToList();

            FilterComboBox.Items.Clear();
            FilterComboBox.Items.Add("~Show All~");
            foreach (var item in items)
                FilterComboBox.Items.Add(item);

            FilterComboBox.SelectedIndex = 0;
        }
        private void ShowSplashForm()
        {
            SplashForm splashForm = new SplashForm();
            splashForm.Show();
            //Show SplashForm for 3 seconds then close
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 3000; // 3 seconds
            timer.Tick += (s, e) =>
            {
                timer.Stop();
                splashForm.Close();
            };
            timer.Start();
        }

        // Event Handlers Below -------------------------------------------------------------------

        private void AisleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            LoadFilterComboBox();
        }

        private void CategoryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            LoadFilterComboBox();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            FilterComboBox.SelectedIndex = 0;
            DisplayData();
            if (SearchTextBox.Text.Equals("zzz", StringComparison.InvariantCultureIgnoreCase))
                this.Close();
            if (DisplayListBox.Items.Count == 0)
                DisplayLabel.Text = $"Sorry no matches for {SearchTextBox.Text}";
            SearchTextBox.Text = "";
        }

        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void DisplayListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DisplayListBox.SelectedItem == null)
            {
                DisplayLabel.Text = "";
                return;
            }

            // Find the selected item's data by matching the item name
            string selectedItem = DisplayListBox.SelectedItem.ToString().Substring(0, 25).Trim();

            for (int row = 0; row < customerData.GetLength(1); row++)
            {
                if (customerData[0, row] != null && customerData[0, row].Equals
                    (selectedItem, StringComparison.InvariantCultureIgnoreCase))
                {
                    DisplayLabel.Text = $"You will find {customerData[0, row]}" + "\n" +
                        $"on aisle {customerData[1, row]}" + "\n" +
                        $"with the {customerData[2, row]}";
                    return;
                }
            }
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchButton_Click(sender, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
