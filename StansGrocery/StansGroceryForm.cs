namespace StansGrocery
{
    public partial class StansGroceryForm : Form
    {
        public StansGroceryForm()
        {
            InitializeComponent();
            FileToArray(filePath);
            DisplayData();
        }

        string[,] customerData = new string[0, 0];
        string filePath = "..\\..\\..\\Grocery.txt";

        int CountOfLinesIn(string filePath)
        {
            int count = 0;
            using (StreamReader testFile = new StreamReader(filePath))
            {
                do
                {
                    testFile.ReadLine();
                    count++;
                } while (!testFile.EndOfStream);
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
            string formattedRow = "";
            int filterColumn = 2;

            DisplayListBox.Items.Clear();

            switch (true)
            {
                case bool when CategoryRadioButton.Checked:
                    filterColumn = 2;
                    break;
                case bool when AisleRadioButton.Checked:
                    filterColumn = 1;
                    break;
                    //default:
            }

            for (int row = 0; row < data.GetLength(1); row++)
            {
                for (int column = 0; column < data.GetLength(0); column++)
                {
                    if (data[column, row] != null && (data[filterColumn, row] == FilterComboBox.SelectedItem.ToString() || FilterComboBox.SelectedIndex == 0))
                    {
                        // format the row for display, giving each field a fixed width for better readability
                        formattedRow = $"{data[0, row],-25} {data[1, row],-5} {data[2, row],-25}";
                    }
                }
                if (formattedRow != "")
                {
                    //System.String.
                    if (formattedRow.Contains(SearchTextBox.Text, StringComparison.InvariantCultureIgnoreCase))
                    {
                        DisplayListBox.Items.Add(formattedRow);
                    }

                }
            }
        }
    }
}
