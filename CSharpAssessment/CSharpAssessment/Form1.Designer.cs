using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Xml.Linq;

namespace CSharpAssessment
{
    public partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public Form1 getForm1Reference()
        {
            return this;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 


        public void DeserializeTreeImage(string a_treeName, int a_num)
        {
            //List<PictureBox> deserializePictureBoxes = new List<PictureBox>();
            List<Point> deserializeLocations = new List<Point>();

            //create a streamwriter to write to file
            try
            {
                //StreamReader picBoxReader = new StreamReader(a_treeName + "PictureBoxes.xml");
                StreamReader locationsReader = new StreamReader(a_treeName + "Locations.xml");

            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show("Tree not found! " + e.FileName);
                return;
            }

            // StreamReader picBoxConfirmed = new StreamReader(a_treeName + "PictureBoxes.xml");
            StreamReader locationsConfirmed = new StreamReader(a_treeName + "Locations.xml");

            //create an XMLSerializer to serialize
            //XmlSerializer picBoxSerializer = new XmlSerializer(typeof(List<PictureBox>));
            XmlSerializer locationsSerializer = new XmlSerializer(typeof(List<Point>));

            //serialize
            if (a_num == 4)
            {
                //deserializePictureBoxes = picBoxSerializer.Deserialize(picBoxConfirmed) as List<PictureBox>;
                deserializeLocations = locationsSerializer.Deserialize(locationsConfirmed) as List<Point>;

                imageNodeList.Clear();
                foreach (Point point in deserializeLocations)
                {
                    imageNodeList.Add(new ImageNode("test", point, null, 0));
                }
            }

            //close writer
            //picBoxConfirmed.Close();
            locationsConfirmed.Close();
        }


        public void DeserializeArray(string a_treeName, int a_num)
        {
            List<string> compositeNodes = new List<string>();
            List<string> decoratorNodes = new List<string>();
            List<string> leafNodes = new List<string>();


            //create a streamwriter to write to file
            try
            {
                StreamReader reader = new StreamReader(a_treeName);
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show("Tree not found! " + e.FileName);
                return;
            }


            StreamReader readerConfirmed = new StreamReader(a_treeName);

            //create an XMLSerializer to serialize
            XmlSerializer serializer = new XmlSerializer(typeof(List<string>));

            //serialize
            switch (a_num)
            {
                case 1:
                    {
                        compositeNodes = serializer.Deserialize(readerConfirmed) as List<string>;

                        compositeOne = compositeNodes[0];
                        compositeTwo = compositeNodes[1];
                        break;
                    }
                case 2:
                    {
                        decoratorNodes = serializer.Deserialize(readerConfirmed) as List<string>;

                        decoratorOne = decoratorNodes[0];
                        decoratorTwo = decoratorNodes[1];
                        break;
                    }
                case 3:
                    {
                        leafNodes = serializer.Deserialize(readerConfirmed) as List<string>;
                        leafOne = leafNodes[0];
                        leafTwo = leafNodes[1];
                        leafThree = leafNodes[2];
                        leafFour = leafNodes[3];
                        leafFive = leafNodes[4];
                        leafSix = leafNodes[5];
                        break;
                    }
                default:
                    break;
            }

            //close writer
            readerConfirmed.Close();
        }

        public void SerializeArray(string a_path, List<string> a_node)
        {
            //create a streamwriter to write to file
            StreamWriter writer = new StreamWriter(a_path);

            //create an XMLSerializer to serialize
            XmlSerializer serializer = new XmlSerializer(typeof(List<string>));

            //serialize
            serializer.Serialize(writer, a_node);

            //close writer
            writer.Close();
        }


        public void SerializeTreeImages(string a_path, List<Image> a_pictureBoxImages)
        {
            StreamWriter imageWriter = new StreamWriter(a_path + "PictureBoxes.xml");

            XmlSerializer imageSerializer = new XmlSerializer(typeof(List<Image>));

            imageSerializer.Serialize(imageWriter, a_pictureBoxImages);

            imageWriter.Close();
        }

        public void SerializeNodeLocations(string a_path, List<Point> a_locations)
        {
            //create a streamwriter to write to file
            StreamWriter locationsWriter = new StreamWriter(a_path + "Locations.xml");

            //create an XMLSerializer to serialize
            XmlSerializer locationsSerializer = new XmlSerializer(typeof(List<Point>));

            //serialize
            locationsSerializer.Serialize(locationsWriter, a_locations);

            //close writer
            locationsWriter.Close();
        }

        public void DeserializeForm(string a_treeName)
        {
            DeserializeArray(a_treeName + "CompositeNodes.xml", 1);
            DeserializeArray(a_treeName + "DecoratorNodes.xml", 2);
            DeserializeArray(a_treeName + "LeafNodes.xml", 3);
            DeserializeTreeImage(a_treeName, 4);
        }


        public void SerializeForm(string a_path)
        {
            List<Image> pictureBoxImages = new List<Image>();
            List<Point> nodeLocations = new List<Point>();


            List<string> compositeNodes = new List<string>();
            List<string> decoratorNodes = new List<string>();
            List<string> leafNodes = new List<string>();

            compositeNodes.Add(compositeOne);
            compositeNodes.Add(compositeTwo);

            decoratorNodes.Add(decoratorOne);
            decoratorNodes.Add(decoratorTwo);

            leafNodes.Add(leafOne);
            leafNodes.Add(leafTwo);
            leafNodes.Add(leafThree);
            leafNodes.Add(leafFour);
            leafNodes.Add(leafFive);
            leafNodes.Add(leafSix);

            // Loop through all the current nodes in the tree view and add them
            //to the array for serialization
            foreach (ImageNode node in imageNodeList)
            {
                pictureBoxImages.Add(node.getPicBox().Image);
                nodeLocations.Add(node.m_location);
            }

            SerializeArray(a_path + "CompositeNodes.xml", compositeNodes);
            SerializeArray(a_path + "DecoratorNodes.xml", decoratorNodes);
            SerializeArray(a_path + "LeafNodes.xml", leafNodes);


            SerializeNodeLocations(a_path, nodeLocations);
            // SerializeTreeImages(a_path, pictureBoxImages);
        }


        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.propertiesTreeView = new System.Windows.Forms.TreeView();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leafList = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.decoratorList = new System.Windows.Forms.ListBox();
            this.compositeList = new System.Windows.Forms.ListBox();
            this.compositeTextBox = new System.Windows.Forms.RichTextBox();
            this.decoratorTextBox = new System.Windows.Forms.RichTextBox();
            this.leafTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // propertiesTreeView
            // 
            this.propertiesTreeView.Location = new System.Drawing.Point(1139, 51);
            this.propertiesTreeView.Name = "propertiesTreeView";
            this.propertiesTreeView.Size = new System.Drawing.Size(119, 619);
            this.propertiesTreeView.TabIndex = 0;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1274, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // leafList
            // 
            this.leafList.FormattingEnabled = true;
            this.leafList.Location = new System.Drawing.Point(11, 442);
            this.leafList.Name = "leafList";
            this.leafList.Size = new System.Drawing.Size(154, 225);
            this.leafList.TabIndex = 5;
            this.leafList.DragEnter += new System.Windows.Forms.DragEventHandler(this.leafList_DragEnter);
            this.leafList.DragLeave += new System.EventHandler(this.leafList_DragLeave);
            this.leafList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.leafList_MouseDown);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(172, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 619);
            this.panel1.TabIndex = 6;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragOver += new System.Windows.Forms.DragEventHandler(this.panel1_DragOver);
            // 
            // decoratorList
            // 
            this.decoratorList.FormattingEnabled = true;
            this.decoratorList.Location = new System.Drawing.Point(11, 265);
            this.decoratorList.Name = "decoratorList";
            this.decoratorList.Size = new System.Drawing.Size(154, 134);
            this.decoratorList.TabIndex = 7;
            this.decoratorList.DragEnter += new System.Windows.Forms.DragEventHandler(this.decoratorList_DragEnter);
            this.decoratorList.DragLeave += new System.EventHandler(this.decoratorList_DragLeave);
            this.decoratorList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.decoratorList_MouseDown);
            // 
            // compositeList
            // 
            this.compositeList.FormattingEnabled = true;
            this.compositeList.Location = new System.Drawing.Point(12, 83);
            this.compositeList.Name = "compositeList";
            this.compositeList.Size = new System.Drawing.Size(154, 134);
            this.compositeList.TabIndex = 8;
            // 
            // compositeTextBox
            // 
            this.compositeTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.compositeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.compositeTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.compositeTextBox.Location = new System.Drawing.Point(13, 60);
            this.compositeTextBox.Name = "compositeTextBox";
            this.compositeTextBox.Size = new System.Drawing.Size(153, 17);
            this.compositeTextBox.TabIndex = 9;
            this.compositeTextBox.Text = "";
            // 
            // decoratorTextBox
            // 
            this.decoratorTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.decoratorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.decoratorTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.decoratorTextBox.Location = new System.Drawing.Point(13, 242);
            this.decoratorTextBox.Name = "decoratorTextBox";
            this.decoratorTextBox.Size = new System.Drawing.Size(153, 17);
            this.decoratorTextBox.TabIndex = 10;
            this.decoratorTextBox.Text = "";
            // 
            // leafTextBox
            // 
            this.leafTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.leafTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.leafTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.leafTextBox.Location = new System.Drawing.Point(11, 419);
            this.leafTextBox.Name = "leafTextBox";
            this.leafTextBox.Size = new System.Drawing.Size(153, 17);
            this.leafTextBox.TabIndex = 11;
            this.leafTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1274, 681);
            this.Controls.Add(this.leafTextBox);
            this.Controls.Add(this.decoratorTextBox);
            this.Controls.Add(this.compositeTextBox);
            this.Controls.Add(this.compositeList);
            this.Controls.Add(this.decoratorList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.leafList);
            this.Controls.Add(this.propertiesTreeView);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1290, 720);
            this.MinimumSize = new System.Drawing.Size(1290, 720);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView propertiesTreeView;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ListBox leafList;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox compositeList;
        private System.Windows.Forms.ListBox decoratorList;
        private System.Windows.Forms.RichTextBox compositeTextBox;
        private System.Windows.Forms.RichTextBox decoratorTextBox;
        private System.Windows.Forms.RichTextBox leafTextBox;
    }
}

