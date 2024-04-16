using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            LoadData();
        }

        private void LoadData()
        {
            string jsonFilePath = "people.json";
            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);
                people = JsonConvert.DeserializeObject<List<Person>>(json);
                dataGridView.DataSource = people;
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
                people = new List<Person>();
            }
        }

        private void SaveData()
        {
            string jsonFilePath = "people.json";
            string json = JsonConvert.SerializeObject(people);
            File.WriteAllText(jsonFilePath, json);
        }

        private void CalculateBMI(string name, double height, double weight)
        {
            double heightInMeters = height / 100;
            double bmi = Math.Round(weight / (heightInMeters * heightInMeters), 2);
            string remarks = GetRemarks(bmi);
            Person newPerson = new Person(name, height, weight, bmi, remarks);
            people.Add(newPerson);
            SaveData();
            LoadData();
        }

        private string GetRemarks(double bmi)
        {
            if (bmi < 18.5)
                return "Underweight";
            else if (bmi >= 18.5 && bmi < 25)
                return "Normal weight";
            else if (bmi >= 25 && bmi < 30)
                return "Overweight";
            else
                return "Obese";
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            double height = Convert.ToDouble(heightTextBox.Text);
            double weight = Convert.ToDouble(weightTextBox.Text);
            CalculateBMI(name, height, weight);
            ClearInputs();
        }

        private void ClearInputs()
        {
            nameTextBox.Text = "";
            heightTextBox.Text = "";
            weightTextBox.Text = "";
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
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
