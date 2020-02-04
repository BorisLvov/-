using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Крестки : Form
    {
        private int x = 12, y = 12;// Начльные координаты 1 кнопки
        private Button[,] buttons = new Button[3, 3];//Создем двухмеррный массив
        private int playr; 
        public Крестки()
        {
            InitializeComponent();
            this.Height = 700;//указваем размеры
            this.Width = 800;
            label1.Text = "Ходит игрок 1";
            playr = 1;
            for (int i = 0; i < buttons.Length / 3; i++)
            {
                for (int j = 0; j < buttons.Length / 3; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Size = new Size(200, 200);
                }
            }
            setButtons();
        }
        private void setButtons()//Функция в которой описываем расположение кнопок
        {
            for (int i = 0; i < 3; i++)//iВертикальный порядок а J горизонтальный порядок
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j].Location = new Point(12 + 206 * j, 12 + 206 * i);
                    buttons[i, j].Click += button1_Click;
                    buttons[i, j].Font = new Font(new FontFamily("Microsoft Sans Serif"), 138);//Размер текста
                    buttons[i, j].Text = "";
                    this.Controls.Add(buttons[i, j]);//Добавление созданного элемента на форму
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {switch (playr)
            {
                case 1:
                    sender.GetType().GetProperty("Text").SetValue(sender, "x");//Выводив в баттоне x
                    playr = 0;//игрок 1 ставит крестик
                    label1.Text = "Ходит игрок 1";
                    break;
                case 0:
                    sender.GetType().GetProperty("Text").SetValue(sender, "o");//Выводив в баттоне о
                    playr = 1;//игрок 2 ставит нолик
                    label1.Text = "Ходит игрок 2";
                    break;
            }
            sender.GetType().GetProperty("Enabled").SetValue(sender,false);//Запрещаем изменение после выбора клекти
            ChekWin();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j].Text = "";
                    buttons[i, j].Enabled = true;
                }
            }
        }

        private void ChekWin()//функция проверка выйграл игркок или нет 
        {
            if (buttons[0, 0].Text == buttons[0, 1].Text && buttons[0, 1].Text == buttons[0, 2].Text)
            { 
                if (buttons[0, 0].Text != "")
                {
                    MessageBox.Show("Вы победили!");
                    return;
                }
            }
            if (buttons[1, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[1, 2].Text)
            {
                if (buttons[1, 0].Text != "")
                    MessageBox.Show("Вы победили!");
            }
            if (buttons[2, 0].Text == buttons[2, 1].Text && buttons[2, 1].Text == buttons[2, 2].Text)
            {
                if (buttons[2, 0].Text != "")
                    MessageBox.Show("Вы победили!");
            }
            if (buttons[0, 0].Text == buttons[1, 0].Text && buttons[1, 0].Text == buttons[2, 0].Text)
            {
                if (buttons[0, 0].Text != "")
                    MessageBox.Show("Вы победили!");
            }
            if (buttons[0, 1].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 1].Text)
            {
                if (buttons[0, 1].Text != "")
                    MessageBox.Show("Вы победили!");
            }
            if (buttons[0, 2].Text == buttons[1, 2].Text && buttons[1, 2].Text == buttons[2, 2].Text)
            {
                if (buttons[0, 2].Text != "")
                    MessageBox.Show("Вы победили!");
            }
            if (buttons[0, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 2].Text)
            {
                if (buttons[0, 0].Text != "")
                    MessageBox.Show("Вы победили!");
            }
            if (buttons[2, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[0, 2].Text)
            {
                if (buttons[2, 0].Text != "")
                    MessageBox.Show("Вы победили!");
            }
          
        }
        private void Крестки_Load(object sender, EventArgs e)
        {

        }
    }
}
