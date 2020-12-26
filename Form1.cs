using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //функции ввода-вывода

namespace FileInformaation
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }
        private FileInfo fiSource;
        private string fileName;
        private FileStream fsSource; //файловый поток
        private StreamReader srSource; //объект, обеспечивающий чтение из файла
        private StreamWriter swSource; //объект, обеспечивающий запись в файла
        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            fileName = tbInput.Text; //сохраняем имя файла
            fiSource = new FileInfo(fileName); //создаем экземпляр класса FileInfo
                                               //производим очистку полей ввода
            tbInfo.Clear();
            tbEdit.Clear();
            tbInput.Clear();
            try
            {
                if (fiSource.Exists) //если выбранный пользователем файл существует
                {
                    //выводим имя файла в метку
                    lblFilename.Text = "Информация о файле: " + fileName;
                    //выводим информацию о файле в текстовое поле
                    tbInfo.Text += "Время создания файла: " +
                    fiSource.CreationTime.ToString() + "\r\n";
                    tbInfo.Text += "Размер файла " + fiSource.Length + " байт \r\n";
                    tbInfo.Text += "Полный путь к файлу: " +
                   fiSource.FullName.ToString() + "\r\n";
                }
            }
            catch (IOException ex) //при возникновении ошибок ввода-вывода
            {
                MessageBox.Show("Произошла ошибка: " + ex.ToString());
            }
            if (Path.GetExtension(fileName) == ".txt") //если у файла текстовое расширение
            {
                //снимаем блокировку элементов управления, необходимых для работы с содержимым
                btnSave.Enabled = true;
                tbEdit.ReadOnly = false;
                //создаем новый файловый поток для чтения
                fsSource = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                //создаем объект, обеспечивающий чтение из файла
                srSource = new StreamReader(fsSource);
                string line; //переменная для записи строк
                line = srSource.ReadLine(); //считываем первую строку
                while (line != null) //пока не получим пустую строку
                {
                    tbEdit.Text += line + "\r\n"; //заносим строку в текстовое поле
                    line = srSource.ReadLine(); //считываем следующую строку
                }
                srSource.Close(); //закрываем файловый поток
            }
            else
            {
                tbEdit.Text += "Файл не является текстовым";
                btnSave.Enabled = false;
                tbEdit.ReadOnly = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //создаем поток вывода с очисткой содержимого существующего файла
                fsSource = new FileStream(fileName, FileMode.Truncate, FileAccess.Write);
                swSource = new StreamWriter(fsSource);
                //построчно записываем данные в файл
                for (int i = 0; i < tbEdit.Lines.Length; i++)
                {
                    swSource.WriteLine(tbEdit.Lines[i]);
                }
                swSource.Close(); //закрываем файловый поток
                MessageBox.Show("Изменения сохранены!");
            }
            catch (IOException ex) //при возникновении ошибок
            {
                MessageBox.Show("Произошла ошибка: " + ex.ToString());
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("Произошла доступа: " + ex.ToString());
            }
        }
}
