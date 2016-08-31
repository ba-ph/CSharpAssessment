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
using CSharpAssessment.Properties;
using System.Runtime.Serialization;

namespace CSharpAssessment
{
    public partial class Form1 : Form
    {
        NewTreeDialog newTreeDialog = null;
        ImageNode currentSelectedNode;
        ImageNode currentSelectedParentNode;
        public int NodeCount = 0;

        public class ImageNode
        {
            public ImageNode(string a_nodeName, Point a_location, Image a_nodeImage, int a_nodeId)
            {
                m_children = new List<ImageNode>();
                m_pictureBox = new PictureBox();
                m_pictureBox.Name = "node" + a_nodeId;

                m_nodeId = a_nodeId;
                NodeName = a_nodeName;
                this.NodeLocation = a_location;

                m_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                addImage(a_nodeImage);
                m_pictureBox.Location = a_location;
            }

            public int m_nodeId;
            public int getNodeID()
            {
                return m_nodeId;
            }

            public Point m_location;
            public Point NodeLocation
            {
                get; set;
            }

            public List<ImageNode> m_children;

            public void addChild(ImageNode a_newChild)
            {
                m_children.Add(a_newChild);
                a_newChild.setLocation(new Point(this.m_location.X, this.m_location.Y + 45));
            }

            public void removeChild(ImageNode a_newChild)
            {
                m_children.Remove(a_newChild);
            }

            public void clearChildren()
            {
                m_children.Clear();
            }

            public string m_nodeName;
            public string NodeName
            {
                get; set;
            }

            public override string ToString()
            {
                return m_nodeName;
            }

            public PictureBox m_pictureBox;

            public void addImage(Image a_newImage)
            {
                m_pictureBox.Image = a_newImage;
                Size size = new Size(120, 60);
                m_pictureBox.Size = size;

            }

            public void removeImage()
            {
                m_pictureBox.Image = null;
            }

            public void setPicBoxParent(Panel a_panel)
            {
                a_panel.Controls.Add(m_pictureBox);
            }

            public PictureBox getPicBox()
            {
                return m_pictureBox;
            }

            public void setLocation(Point a_location)
            {
                NodeLocation = a_location;
                m_location = a_location;
                m_pictureBox.Location = a_location;

                //Everytime a node is moved, update it's children's positions if it has any
                foreach (ImageNode child in m_children)
                {
                    child.setLocation(new Point(m_location.X, m_location.Y + 55));
                }
            }
        }


        public class Node
        {
            public Node(string a_nodeName)
            {
                m_nodeName = a_nodeName;
            }

            private string m_nodeName;
            public string NodeName
            {
                get; set;
            }

            public override string ToString()
            {
                return m_nodeName;
            }
        }


        public object lb_item = null;
        public List<ImageNode> imageNodeList = new List<ImageNode>();

        private void leafList_DragLeave(object sender, EventArgs e)
        {
            ListBox lb = sender as ListBox;

            lb_item = lb.SelectedItem;
            lb.Items.Remove(lb.SelectedItem);
        }

        private void leafList_DragEnter(object sender, DragEventArgs e)
        {
            if (lb_item != null)
            {
                leafList.Items.Add(lb_item);
                lb_item = null;
            }
        }

        private void leafList_MouseDown(object sender, MouseEventArgs e)
        {
            lb_item = null;

            if (leafList.Items.Count == 0)
            {
                return;
            }

            int index = leafList.IndexFromPoint(e.X, e.Y);
            string s = leafList.Items[index].ToString();
            DragDropEffects dde1 = DoDragDrop(s, DragDropEffects.Copy);
        }


        private void decoratorList_DragLeave(object sender, EventArgs e)
        {
            ListBox lb = sender as ListBox;

            lb_item = lb.SelectedItem;
            lb.Items.Remove(lb.SelectedItem);
        }

        private void decoratorList_DragEnter(object sender, DragEventArgs e)
        {
            if (lb_item != null)
            {
                decoratorList.Items.Add(lb_item);
                lb_item = null;
            }
        }

        private void decoratorList_MouseDown(object sender, MouseEventArgs e)
        {
            lb_item = null;

            if (decoratorList.Items.Count == 0)
            {
                return;
            }

            int index = decoratorList.IndexFromPoint(e.X, e.Y);
            string s = decoratorList.Items[index].ToString();
            DragDropEffects dde1 = DoDragDrop(s, DragDropEffects.Copy);
        }

        private void compositeList_DragLeave(object sender, EventArgs e)
        {
            ListBox lb = sender as ListBox;

            lb_item = lb.SelectedItem;
            lb.Items.Remove(lb.SelectedItem);
        }

        private void compositeList_DragEnter(object sender, DragEventArgs e)
        {
            if (lb_item != null)
            {
                compositeList.Items.Add(lb_item);
                lb_item = null;
            }
        }

        private void compositeList_MouseDown(object sender, MouseEventArgs e)
        {
            lb_item = null;

            if (compositeList.Items.Count == 0)
            {
                return;
            }

            int index = compositeList.IndexFromPoint(e.X, e.Y);
            string s = compositeList.Items[index].ToString();
            DragDropEffects dde1 = DoDragDrop(s, DragDropEffects.Copy);
        }

        private void panel1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                string str = (string)e.Data.GetData(DataFormats.StringFormat);

                Point mouseDropPos = panel1.PointToClient(System.Windows.Forms.Control.MousePosition);

                if (str == "Selector")
                {
                    Image temp;
                    using (FileStream stream = new FileStream("../../assets/selector.jpg", FileMode.Open, FileAccess.Read))
                    {
                        temp = Image.FromStream(stream);
                    }

                    ImageNode newNode = new ImageNode("SelectorNode", mouseDropPos, temp, NodeCount);
                    NodeCount += 1;
                    newNode.setPicBoxParent(panel1);
                    newNode.getPicBox().BringToFront();
                    newNode.setLocation(mouseDropPos);
                    newNode.getPicBox().Location = newNode.NodeLocation;

                    imageNodeList.Add(newNode);
                }

                if (str == "Sequence")
                {
                    Image temp;
                    using (FileStream stream = new FileStream("../../assets/sequence.jpg", FileMode.Open, FileAccess.Read))
                    {
                        temp = Image.FromStream(stream);
                    }

                    ImageNode newNode = new ImageNode("SequenceNode", mouseDropPos, temp, NodeCount);
                    NodeCount += 1;
                    newNode.setPicBoxParent(panel1);
                    newNode.getPicBox().BringToFront();
                    newNode.setLocation(mouseDropPos);
                    newNode.getPicBox().Location = newNode.NodeLocation;

                    imageNodeList.Add(newNode);
                }

                if (str == "Repeater")
                {
                    Image temp;
                    using (FileStream stream = new FileStream("../../assets/repeater.jpg", FileMode.Open, FileAccess.Read))
                    {
                        temp = Image.FromStream(stream);
                    }

                    ImageNode newNode = new ImageNode("RepeaterNode", mouseDropPos, temp, NodeCount);
                    NodeCount += 1;
                    newNode.setPicBoxParent(panel1);
                    newNode.getPicBox().BringToFront();
                    newNode.setLocation(mouseDropPos);
                    newNode.getPicBox().Location = newNode.NodeLocation;

                    imageNodeList.Add(newNode);
                }

                if (str == "Maximum")
                {
                    Image temp;
                    using (FileStream stream = new FileStream("../../assets/maximum.jpg", FileMode.Open, FileAccess.Read))
                    {
                        temp = Image.FromStream(stream);
                    }

                    ImageNode newNode = new ImageNode("MaximumNode", mouseDropPos, temp, NodeCount);
                    NodeCount += 1;
                    newNode.setPicBoxParent(panel1);
                    newNode.getPicBox().BringToFront();
                    newNode.setLocation(mouseDropPos);
                    newNode.getPicBox().Location = newNode.NodeLocation;

                    imageNodeList.Add(newNode);
                }

                if (str == "Wander")
                {
                    Image temp;
                    using (FileStream stream = new FileStream("../../assets/wander.jpg", FileMode.Open, FileAccess.Read))
                    {
                        temp = Image.FromStream(stream);
                    }

                    ImageNode newNode = new ImageNode("WanderNode", mouseDropPos, temp, NodeCount);
                    NodeCount += 1;
                    newNode.setPicBoxParent(panel1);
                    newNode.getPicBox().BringToFront();
                    newNode.setLocation(mouseDropPos);
                    newNode.getPicBox().Location = newNode.NodeLocation;

                    imageNodeList.Add(newNode);
                }

                if (str == "Walk")
                {
                    Image temp;
                    using (FileStream stream = new FileStream("../../assets/walk.jpg", FileMode.Open, FileAccess.Read))
                    {
                        temp = Image.FromStream(stream);
                    }

                    ImageNode newNode = new ImageNode("WalkNode", mouseDropPos, temp, NodeCount);
                    NodeCount += 1;
                    newNode.setPicBoxParent(panel1);
                    newNode.getPicBox().BringToFront();
                    newNode.setLocation(mouseDropPos);
                    newNode.getPicBox().Location = newNode.NodeLocation;

                    imageNodeList.Add(newNode);
                }

                if (str == "Run")
                {
                    Image temp;
                    using (FileStream stream = new FileStream("../../assets/run.jpg", FileMode.Open, FileAccess.Read))
                    {
                        temp = Image.FromStream(stream);
                    }

                    ImageNode newNode = new ImageNode("RunNode", mouseDropPos, temp, NodeCount);
                    NodeCount += 1;
                    newNode.setPicBoxParent(panel1);
                    newNode.getPicBox().BringToFront();
                    newNode.setLocation(mouseDropPos);
                    newNode.getPicBox().Location = newNode.NodeLocation;

                    imageNodeList.Add(newNode);
                }

                if (str == "OpenDoor")
                {
                    Image temp;
                    using (FileStream stream = new FileStream("../../assets/openDoor.jpg", FileMode.Open, FileAccess.Read))
                    {
                        temp = Image.FromStream(stream);
                    }

                    ImageNode newNode = new ImageNode("OpenDoorNode", mouseDropPos, temp, NodeCount);
                    NodeCount += 1;
                    newNode.setPicBoxParent(panel1);
                    newNode.getPicBox().BringToFront();
                    newNode.setLocation(mouseDropPos);
                    newNode.getPicBox().Location = newNode.NodeLocation;

                    imageNodeList.Add(newNode);
                }

                if (str == "Flee")
                {
                    Image temp;
                    using (FileStream stream = new FileStream("../../assets/flee.jpg", FileMode.Open, FileAccess.Read))
                    {
                        temp = Image.FromStream(stream);
                    }

                    ImageNode newNode = new ImageNode("FleeNode", mouseDropPos, temp, NodeCount);
                    NodeCount += 1;
                    newNode.setPicBoxParent(panel1);
                    newNode.getPicBox().BringToFront();
                    newNode.setLocation(mouseDropPos);
                    newNode.getPicBox().Location = newNode.NodeLocation;

                    imageNodeList.Add(newNode);
                }

                if (str == "FindEntrance")
                {
                    Image temp;
                    using (FileStream stream = new FileStream("../../assets/findEntrance.jpg", FileMode.Open, FileAccess.Read))
                    {
                        temp = Image.FromStream(stream);
                    }

                    ImageNode newNode = new ImageNode("FindEntranceNode", mouseDropPos, temp, NodeCount);
                    NodeCount += 1;
                    newNode.setPicBoxParent(panel1);
                    newNode.getPicBox().BringToFront();
                    newNode.setLocation(mouseDropPos);
                    newNode.getPicBox().Location = newNode.NodeLocation;

                    imageNodeList.Add(newNode);
                }

                if (str == "Attack")
                {
                    Image temp;
                    using (FileStream stream = new FileStream("../../assets/attack.jpg", FileMode.Open, FileAccess.Read))
                    {
                        temp = Image.FromStream(stream);
                    }

                    ImageNode newNode = new ImageNode("AttackNode", mouseDropPos, temp, NodeCount);
                    NodeCount += 1;
                    newNode.setPicBoxParent(panel1);
                    newNode.getPicBox().BringToFront();
                    newNode.setLocation(mouseDropPos);
                    newNode.getPicBox().Location = newNode.NodeLocation;

                    imageNodeList.Add(newNode);
                }

                this.Invalidate();
                panel1.Invalidate();
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            lb_item = null;
        }

        public bool newTreeOpened = false;
        public bool newTreeCreated = false;


        public string treeName;

        public string compositeOne;
        public string compositeTwo;

        public string decoratorOne;
        public string decoratorTwo;

        public string leafOne;
        public string leafTwo;
        public string leafThree;
        public string leafFour;
        public string leafFive;
        public string leafSix;

        public BindingList<Node> compositeNodeList = new BindingList<Node>();
        public BindingList<Node> decoratorNodeList = new BindingList<Node>();
        public BindingList<Node> leafNodeList = new BindingList<Node>();

        public object My { get; private set; }

        public Form1()
        {
            InitializeComponent();

            compositeList.DataSource = compositeNodeList;
            decoratorList.DataSource = decoratorNodeList;
            leafList.DataSource = leafNodeList;

            compositeList.AllowDrop = true;
            compositeList.MouseDown += new MouseEventHandler(this.compositeList_MouseDown);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            compositeTextBox.Text = "COMPOSITE";
            decoratorTextBox.Text = "DECORATOR";
            leafTextBox.Text = "LEAF";

            compositeList.Text = "";
            decoratorList.Text = "";
            leafList.Text = "";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            compositeNodeList.Clear();
            decoratorNodeList.Clear();
            leafNodeList.Clear();

            leafOne = null;
            leafTwo = null;
            leafThree = null;
            leafFour = null;
            leafFive = null;
            leafSix = null;

            newTreeDialog = new NewTreeDialog(this);
            newTreeDialog.Show();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            panel1.Invalidate();
            //Update the lists if a tree is opened or a new tree is created.
            if (newTreeCreated == true || newTreeOpened == true)
            {
                compositeList.Invalidate();
                decoratorList.Invalidate();
                leafList.Invalidate();

                if (compositeOne != null)
                    compositeNodeList.Add(new Node(compositeOne));

                if (compositeTwo != null)
                    compositeNodeList.Add(new Node(compositeTwo));

                if (decoratorOne != null)
                    decoratorNodeList.Add(new Node(decoratorOne));

                if (decoratorTwo != null)
                    decoratorNodeList.Add(new Node(decoratorTwo));


                if (leafOne != null)
                    leafNodeList.Add(new Node(leafOne));

                if (leafTwo != null)
                    leafNodeList.Add(new Node(leafTwo));

                if (leafThree != null)
                    leafNodeList.Add(new Node(leafThree));

                if (leafFour != null)
                    leafNodeList.Add(new Node(leafFour));

                if (leafFive != null)
                    leafNodeList.Add(new Node(leafFive));

                if (leafSix != null)
                    leafNodeList.Add(new Node(leafSix));

                newTreeCreated = false;
                newTreeOpened = false;

                compositeList.Invalidate();
                decoratorList.Invalidate();
                leafList.Invalidate();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tree_Save_Name treeSaveNameDialog = new Tree_Save_Name(this);
            treeSaveNameDialog.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeOpenDialog treeOpenDialog = new TreeOpenDialog(this);
            treeOpenDialog.Show();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Point mouseLocation = panel1.PointToClient(System.Windows.Forms.Control.MousePosition);
            //If a node has already been selected move it to the current mouse pos
            if (currentSelectedNode != null)
            {
                currentSelectedNode.setLocation(mouseLocation);
                currentSelectedNode.NodeLocation = mouseLocation;

                currentSelectedNode = null;
                panel1.Invalidate();
                return;
            }

            ImageNode temp = getCloestImageNode(mouseLocation);

            if (temp != null)
            {
                currentSelectedNode = temp;
            }
        }

        private ImageNode getCloestImageNode(Point a_mousePos)
        {
            foreach (ImageNode node in imageNodeList)
            {
                if (Math.Sqrt(Math.Pow(a_mousePos.X - node.NodeLocation.X, 2) + Math.Pow(a_mousePos.Y - node.NodeLocation.Y, 2)) < 150.0f)
                {
                    return node;
                }
            }
            return null;
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.P)
            {
                if (currentSelectedParentNode != null)
                {
                    ImageNode temp = getCloestImageNode(panel1.PointToClient(System.Windows.Forms.Control.MousePosition));
                    //assume mouse is over object we want to child to currentSelectedParentNode
                    if (temp != null)
                    {
                        currentSelectedParentNode.addChild(temp);
                        currentSelectedParentNode = null;
                        return base.ProcessDialogKey(keyData);
                    }
                    return base.ProcessDialogKey(keyData);
                }

                else if (currentSelectedNode == null)
                {
                    //get a new node that we want to add a child to
                    ImageNode temp = getCloestImageNode(panel1.PointToClient(System.Windows.Forms.Control.MousePosition));

                    if (temp != null)
                    {
                        currentSelectedParentNode = temp;
                    }
                    return base.ProcessDialogKey(keyData);
                }

                else
                {
                    MessageBox.Show("Error in previewKeyDown");
                }
            }

            if (keyData == Keys.D)
            { 
                //find the closest node to the mouse
                //has to be done before dialog box so that the panel is still active
                ImageNode temp = getCloestImageNode(panel1.PointToClient(System.Windows.Forms.Control.MousePosition));

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this node?", "Delete Node", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //assume mouse is over object we want to delete
                    if (temp != null)
                    {
                        panel1.Controls.Remove(temp.getPicBox());
                        //Search through array till we find the node so we can null it
                        for (int i = 0; i < imageNodeList.Count(); i++)
                        {
                            if (imageNodeList[i] == temp)
                            {
                                imageNodeList[i] = null;
                            }
                        }

                        imageNodeList.Remove(temp);
                        return base.ProcessDialogKey(keyData);
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    return base.ProcessDialogKey(keyData);
                }

                else
                {
                    MessageBox.Show("Error in previewKeyDown");
                    return base.ProcessDialogKey(keyData);
                }
            }

            return base.ProcessDialogKey(keyData);
        }
    }
}
