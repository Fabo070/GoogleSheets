using System;
using System.Windows.Forms;
using System.IO;
using static GoogleSheets.SheetOperations;

namespace GoogleSheets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SheetOperations sheets = new SheetOperations();
        private void Browse_Click(object sender, EventArgs e)
        {
            int size = -1;
            string name = "";
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                    name = text;
                }
                catch (IOException)
                {
                }
            }
            textBox1.Text = name;
            Console.WriteLine(size); // <-- Shows file size in debugging mode.
            Console.WriteLine(result); // <-- For debugging use.
        }

        private void Update_sheet_Click(object sender, EventArgs e)
        {
            sheets.UpdateSpreadSheet();
        }

        private void Create_sheet_Click(object sender, EventArgs e)
        {
            sheets.CreateSheet();
        }

        private void Print_sheet_Click(object sender, EventArgs e)
        {
            comboBox1.FindString(comboBox2.Text);
            string index = comboBox1.FindString(comboBox1.Text).ToString();
            MessageBox.Show(index);
            string sheetId = textBox1.Text;

            int startColumb = comboBox1.FindString(comboBox1.Text);
            int endColumb = comboBox2.FindString(comboBox2.Text);


            richTextbox1.Text = sheets.PrintSheetData(sheetId, sheets.Range
                (sheet_name.Text, 
                comboBox1.Text, 
                comboBox2.Text,
                startNum.Value, 
                endNum.Value), 
                startColumb,
                endColumb);

            ;


        }

    }
}
