namespace StansGrocery
{
    public partial class StansGroceryForm : Form
    {
        public StansGroceryForm()
        {
            InitializeComponent();
            SetDefaults();
            FileToArray(filePath);
            DisplayData();
        }

        string[,] customerData = new string[0, 0];
        string filePath = "..\\..\\..\\..\\Grocery.txt";

        private void SetDefaults()
        {
            AisleRadioButton.Checked = true;
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
            int filterColumn = AisleRadioButton.Checked ? 1 : 2;

            DisplayListBox.Items.Clear();

            var rows = new List<(int sortKey, string display)>();

            for (int row = 0; row < data.GetLength(1); row++)
            {
                string formattedRow = "";
                for (int column = 0; column < data.GetLength(0); column++)
                {
                    if (data[column, row] != null && (data[filterColumn, row] == FilterComboBox.SelectedItem.ToString() || FilterComboBox.SelectedIndex == 0))
                    {
                        formattedRow = $"{data[0, row],-25} {data[1, row],-5} {data[2, row],-25}";
                    }
                }

                if (formattedRow != "" && formattedRow.Contains(SearchTextBox.Text, StringComparison.InvariantCultureIgnoreCase))
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
                case bool when AisleRadioButton.Checked:
                    column = 1;
                    break;
                case bool when CategoryRadioButton.Checked:
                    column = 2;
                    break;
                    //default:
            }

            for (int row = 0; (row < this.customerData.GetUpperBound(1)); row++)
            {
                if (this.customerData[column, row] != null && FilterComboBox.Items.Contains(this.customerData[column, row]) != true)
                {

                    FilterComboBox.Items.Add(this.customerData[column, row]); //add city 
                }
            }
            FilterComboBox.Items.Add("~Select~");
            var items = FilterComboBox.Items.Cast<string>()
            .OrderBy(x => int.TryParse(x, out int n) ? n : int.MaxValue)
            .ToList();

            FilterComboBox.Items.Clear();
            foreach (var item in items)
                FilterComboBox.Items.Add(item);

            FilterComboBox.SelectedIndex = 0;

        }

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
            SearchTextBox.Text = "";
        }

        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayData();
        }
    }
}
