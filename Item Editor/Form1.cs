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

namespace Item_Editor
{
    public partial class Form1 : Form
    {
        XmlDocument xDoc;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.Text = "Item Editor";
            comboBoxType.Items.Add("NULL");
            comboBoxType.Items.Add("Weapon");
            comboBoxType.Items.Add("Consumable");
            comboBox2.Items.Add("NULL"); 
            comboBox2.Items.Add("Fire");
            comboBox2.Items.Add("Health");
            comboBox2.Items.Add("Damage");

            comboBoxType.SelectedItem = "NULL";
            comboBox2.SelectedItem = "NULL";
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;

            comboBoxType.SelectedItem = "NULL";
            comboBox2.SelectedItem = "NULL";
            nameTextbox.Text = "NULL";
            descTextbox.Text = "NULL";
            effectTextbos.Text = "NULL";
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            xDoc = new XmlDocument();
            xDoc.Load(@"C:\Users\David\Documents\XML files\Item.xml");

            XmlNode node = xDoc.CreateNode(XmlNodeType.Element, "Item", null);
            XmlNode nameNode = xDoc.CreateElement("Name");
            nameNode.InnerText = nameTextbox.Text;
            XmlNode typeNode = xDoc.CreateElement("Type");
            typeNode.InnerText = comboBoxType.SelectedItem.ToString();
            XmlNode effectNode = xDoc.CreateElement("Effect");
            effectNode.InnerText = comboBox2.SelectedItem.ToString();
            XmlNode powerNode = xDoc.CreateElement("Power");
            powerNode.InnerText = effectTextbos.Text;
            XmlNode descNode = xDoc.CreateElement("Desc");
            descNode.InnerText = descTextbox.Text;

            node.AppendChild(nameNode);
            node.AppendChild(typeNode);
            node.AppendChild(effectNode);
            node.AppendChild(powerNode);
            node.AppendChild(descNode);

            xDoc.DocumentElement.AppendChild(node);
            xDoc.Save(@"C:\Users\David\Documents\XML files\Item.xml");

            comboBoxType.SelectedItem = "NULL";
            comboBox2.SelectedItem = "NULL";
            nameTextbox.Text = "NULL";
            descTextbox.Text = "NULL";
            effectTextbos.Text = "NULL";
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            comboBoxType.SelectedItem = "NULL";
            comboBox2.SelectedItem = "NULL";
            nameTextbox.Text = "NULL";
            descTextbox.Text = "NULL";
            effectTextbos.Text = "NULL";
        }
    }
}
