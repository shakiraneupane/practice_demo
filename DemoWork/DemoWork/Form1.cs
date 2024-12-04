using System;
using System.Windows.Forms;

namespace DemoWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click_1(object sender, EventArgs e)
        
        {
            // Get the BOOSE program from the input TextBox
            string booseProgram = txtInput.Text;

            // Interpret the program and get the output
            string output = InterpretBOOSEProgram(booseProgram);

            // Show the output or error in the RichTextBox
            OutputBox.Text = output;
        }

        // A simple interpreter for the BOOSE language
        private string InterpretBOOSEProgram(string booseProgram)
        {
            string output = string.Empty;

            // Split the program into lines (if there are multiple commands)
            var lines = booseProgram.Split('\n');

            foreach (var line in lines)
            {
                // Check if the line is a PRINT command (example BOOSE command)
                if (line.StartsWith("PRINT"))
                {
                    // Print the text following the PRINT command
                    output += line.Substring(5).Trim() + "\n";
                }
                else
                {
                    // Handle unknown commands (error)
                    output += "Error: Unknown command\n";
                }
            }

            return output;
        }

        
    }
}
