using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace XMLGameResults
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void txtScore_TextChanged(object sender, EventArgs e)
        {

         
        }

        private void txtScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (e.KeyChar <= 47 || e.KeyChar >= 58)
            {
                e.Handled = true;
            }
        }
        private string filename = "../../Results.xml";
        private void addPlayerToList(string id, string name, string score)
        {
            //создаем новую коллекцию
            ListViewItem lvi = new ListViewItem(id);
            //заполняем ее значениями
            lvi.SubItems.Add(name);
            lvi.SubItems.Add(score);
            //вводим ее в список
            listOfPlayers.Items.Add(lvi);
        }
        private void loadXml()
        {
            XmlDocument xmlDoc = new XmlDocument(); //создаем xml-документ
            xmlDoc.Load(filename); //загружаем документ из файла
                                   //получаем корневой элемент
            XmlElement xmlRoot = xmlDoc.DocumentElement;
            //обходим все узлы player в корневом элементе
            foreach (XmlNode xmlNode in xmlRoot)
            {
                //переменные для вывода в список
                string id = "";
                string name = "";

            string score = "";
                //если узел содержит атрибуты
                if (xmlNode.Attributes.Count > 0)
                {
                    // получаем значение атрибута id
                    XmlNode attr = xmlNode.Attributes.GetNamedItem("id");
                    if (attr != null) //если атрибут не пуст
                                      //заносим его значение в соответствующую переменную
                        id = attr.Value;
                }
                // обходим все дочерние узлы элемента player
                foreach (XmlNode childNode in xmlNode.ChildNodes)
                {

                    // если узел имеет имя name
                    if (childNode.Name == "name")
                    {
                        //заносим его значение в соответствующую переменную
                        name = childNode.InnerText.ToString();
                    }
                    // если узел имеет имя score
                    if (childNode.Name == "score")
                    {
                        //заносим его значение в соответствующую переменную
                        score = childNode.InnerText.ToString();
                    }
                }
                //выводим в список информацию об игроке
                addPlayerToList(id, name, score);
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            loadXml();
        }
        private void addToXml()
        {
            XmlDocument xmlDoc = new XmlDocument(); //создаем xml-документ
            xmlDoc.Load(filename); //загружаем данные
            XmlElement xmlRoot = xmlDoc.DocumentElement; //получаем корневой элемент
                                                         // создаем новый элемент player
            XmlElement playerElem = xmlDoc.CreateElement("player");
       
// создаем его атрибут id
XmlAttribute idAttr = xmlDoc.CreateAttribute("id");
            // создаем элементы name и score
            XmlElement nameElem = xmlDoc.CreateElement("name");
            XmlElement scoreElem = xmlDoc.CreateElement("score");

            // создаем текстовые значения для элементов и атрибута
            //id=количество узлов в корневом узле + 1
            XmlText idText = xmlDoc.CreateTextNode((xmlRoot.ChildNodes.Count + 1).ToString());
            XmlText nameText = xmlDoc.CreateTextNode(txtName.Text);
            XmlText scoreText = xmlDoc.CreateTextNode(txtScore.Text);
            //присваиваем текстовые значения в атрибут и элементы
            idAttr.AppendChild(idText);
            nameElem.AppendChild(nameText);
            scoreElem.AppendChild(scoreText);
            //добавляем атрибут и элементы в узел player
            playerElem.Attributes.Append(idAttr);
            playerElem.AppendChild(nameElem);
            playerElem.AppendChild(scoreElem);
            //добаваляем в корневой узел новый узел player
            xmlRoot.AppendChild(playerElem);
            //сохраняем изменения
            xmlDoc.Save(filename);
            //выводим в список новую строку
            string id = (xmlRoot.ChildNodes.Count + 1).ToString();
            string name = txtName.Text;
            string score = txtScore.Text;
            addPlayerToList(id, name, score);
        }
    }
}
