using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrelloConverter
{
    public partial class Form1 : Form
    {
        ConsoleForm Console = new ConsoleForm();
        public Form1()
        {
            InitializeComponent();
        }

        private void VolumeButton_Click(object sender, EventArgs e)
        {
            Console.Clear();
            if(this.LengthInput.Text == "" || this.WidthInput.Text == "" || this.HeigthInput.Text == "")
            {
                MessageBox.Show("Поля ввода не могут быть пустыми.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (this.LengthInput.Text.Any(char.IsLetter) || this.WidthInput.Text.Any(char.IsLetter) || this.HeigthInput.Text.Any(char.IsLetter))
                {
                    MessageBox.Show("В поля нелья вводить буквы!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (this.LengthInput.Text.Any(char.IsSymbol) || this.WidthInput.Text.Any(char.IsSymbol) || this.HeigthInput.Text.Any(char.IsSymbol))
                    {
                        MessageBox.Show("В поля нелья вводить символы!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        int length = int.Parse(this.LengthInput.Text);
                        int width = int.Parse(this.WidthInput.Text);
                        int height = int.Parse(this.HeigthInput.Text);

                        int volume = length * width * height;

                        Console.WriteLine($"Result: {volume}");
                        Console.Show();
                    }
                }
            }
        }

        private void LitersButton_Click(object sender, EventArgs e)
        {
            Console.Clear();
            if (this.LengthInput.Text == "" || this.WidthInput.Text == "" || this.HeigthInput.Text == "")
            {
                MessageBox.Show("Поля ввода не могут быть пустыми.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (this.LengthInput.Text.Any(char.IsLetter) || this.WidthInput.Text.Any(char.IsLetter) || this.HeigthInput.Text.Any(char.IsLetter))
                {
                    MessageBox.Show("В поля нелья вводить буквы!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (this.LengthInput.Text.Any(char.IsSymbol) || this.WidthInput.Text.Any(char.IsSymbol) || this.HeigthInput.Text.Any(char.IsSymbol))
                    {
                        MessageBox.Show("В поля нелья вводить символы!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        int length = int.Parse(this.LengthInput.Text);
                        int width = int.Parse(this.WidthInput.Text);
                        int height = int.Parse(this.HeigthInput.Text);

                        int volume = length * width * height;

                        int liters = volume / 1000;

                        Console.WriteLine($"Liters: {liters}");
                        Console.Show();
                    }
                }
            }
        }

        private void MilliliButton_Click(object sender, EventArgs e)
        {
            Console.Clear();
            if (this.LengthInput.Text == "" || this.WidthInput.Text == "" || this.HeigthInput.Text == "")
            {
                MessageBox.Show("Поля ввода не могут быть пустыми.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (this.LengthInput.Text.Any(char.IsLetter) || this.WidthInput.Text.Any(char.IsLetter) || this.HeigthInput.Text.Any(char.IsLetter))
                {
                    MessageBox.Show("В поля нелья вводить буквы!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (this.LengthInput.Text.Any(char.IsSymbol) || this.WidthInput.Text.Any(char.IsSymbol) || this.HeigthInput.Text.Any(char.IsSymbol))
                    {
                        MessageBox.Show("В поля нелья вводить символы!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        int length = int.Parse(this.LengthInput.Text);
                        int width = int.Parse(this.WidthInput.Text);
                        int height = int.Parse(this.HeigthInput.Text);

                        int volume = length * width * height;

                        int liters = volume / 1000;

                        int milliliters = liters * 1000;
                        Console.Show();

                        Console.WriteLine($"Milliliters: {milliliters}");
                    }
                }
            }
        }

        private void ConvertAllButton_Click(object sender, EventArgs e)
        {
            Console.Clear();

            if (this.LengthInput.Text == "" || this.WidthInput.Text == "" || this.HeigthInput.Text == "")
            {
                MessageBox.Show("Поля ввода не могут быть пустыми.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (this.LengthInput.Text.Any(char.IsLetter) || this.WidthInput.Text.Any(char.IsLetter) || this.HeigthInput.Text.Any(char.IsLetter))
                {
                    MessageBox.Show("В поля нелья вводить буквы!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (this.LengthInput.Text.Any(char.IsSymbol) || this.WidthInput.Text.Any(char.IsSymbol) || this.HeigthInput.Text.Any(char.IsSymbol))
                    {
                        MessageBox.Show("В поля нелья вводить символы!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        int length = int.Parse(this.LengthInput.Text);
                        int width = int.Parse(this.WidthInput.Text);
                        int height = int.Parse(this.HeigthInput.Text);

                        int volume = length * width * height;

                        int liters = volume / 1000;

                        int milliliters = liters * 1000;
                        Console.Show();

                        Console.WriteLine($"Volume: {volume}" +
                            $"\nLiters: {liters}" +
                            $"\nMilliliters: {milliliters}");
                    }
                }
            }
        }
    }
}
