using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            label1.Text = "Свойства форм\n" +
                              "Name: устанавливает имя формы\n" +
                              "BackColor: указывает на фоновый цвет формы.\n" +
                              "BackgroundImage: позволяет установить фоновое изображение формы\n" +
                              "ControlBox: указывает, отображается ли меню формы(меню верхнего уровня)\n" +
                              "Cursor: определяет тип курсора, который используется на форме\n" +
                              "Font: задает шрифт для формы и её элементов\n" +
                              "ForeColor: цвет шрифта на форме\n" +
                              "StartPosition: указывает на начальную позицию, с которой форма появляется на экране\n" +
                              "Text: определяет заголовок формы\n";
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            label2.Text = "Методы форм\n" +
                  "Show: Отображает элемент управления.\n" +
                  "Close:	Закрывает форму\n" +
                  "Select:	Активирует элемент управления\n" +
                  "Focus:	Устанавливает фокус ввода на элемент управления.\n" +
                  "ScaleCore:	Выполняет масштабирование формы\n" +
                  "RemoveOwnedForm: Удаляет собственную форму из этой формы.\n"; 
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            label3.Text = "Взаимодействие между формами\n" +
                "1.В панели  обозреватель решений выделяем 1 форму, затем правой кнопкой мыши и выберем пункт перейти к коду.\n" +
                "2.Меняем у элементов формы к которым необходим доступ из другой формы с private на public.\n" +
                "3.Напишем код вызова второй формы из первой при нажатии кнопки 1 формы.\n" +
                "4.Между формами данные передаются в обе стороны\n";
        }
    }
}