using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    public partial class MainApp : Form
    {
        private List<Person> people;
        public MainApp()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            string jsonFilePath = "people.json";
            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);
                people = JsonConvert.DeserializeObject<List<Person>>(json);
                dataGridView.DataSource = people;
            }
            else
            {
                people = new List<Person>();
            }
        }

        private void MainApp_Load(object sender, EventArgs e)
        {
            LoadData();

        }
    }

    public class Person
    {
        public string Name { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public double BMI { get; set; }
        public string Remarks { get; set; }

        public Person(string name, double height, double weight, double bmi, string remarks)
        {
            Name = name;
            Height = height;
            Weight = weight;
            BMI = bmi;
            Remarks = remarks;
        }
    }
}
