using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Globalization;

namespace DamianBisWinFormsTask
{
    public partial class Form1 : Form
    {
        private Button[] buttons;
        private bool[] isclicked;
        private BindingList<Element> projectElements; // list of elements to draw after refresh
        private Element Selected_Element = null;


        private int MaxHeight;
        private int MaxWidth;

        public Form1()
        {
            InitializeComponent();
            ButtonsAssign();

            //Init blueprint
            Bitmap bitmapa = new Bitmap(splitContainer1.Panel1.Width, splitContainer1.Panel1.Height);
            Graphics fl = Graphics.FromImage(bitmapa);
            fl.Clear(Color.White);
            Bitmapa.Image = bitmapa;
            MaxHeight = bitmapa.Size.Height;
            MaxWidth = bitmapa.Size.Width;
            Bitmapa.MouseWheel += onMouseWheel;
            ListBox.DataSource = projectElements;

        }


        private void ButtonsAssign()
        {
            projectElements = new BindingList<Element>();

            buttons = new Button[5];
            isclicked = new bool[5];
            int i = 0;
            foreach (Button b in FurnituresFlowLayout.Controls)
            {
                buttons[i] = b;
                i++;
            }

            foreach (Button b in FurnituresFlowLayout.Controls)
            {
                b.Click += button_Click;
            }

        }
        private void newBlueprintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bitmapa = new Bitmap(splitContainer1.Panel1.Width, splitContainer1.Panel1.Height);
            Graphics fl = Graphics.FromImage(bitmapa);
            fl.Clear(Color.White);
            Bitmapa.Image = bitmapa;
            projectElements = null;
            Selected_Element = null;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;

            int index = -1;
            for (int i = 0; i < 5; i++)
            {
                if (buttons[i] == b) index = i;
            }

            if (isclicked[index] == true)
            {
                if (buildingWall && index == 4)
                {
                    buildingWall = false;
                    RedrawBitmap();
                }
                isclicked[index] = false;
                b.BackColor = Color.WhiteSmoke;
            }
            else
            {
                int indexprev = -1;
                for (int i = 0; i < 5; i++)
                {
                    if (buttons[i] != b && isclicked[i]) indexprev = i;
                }
                if (indexprev != -1)
                {
                    isclicked[indexprev] = false;
                    buttons[indexprev].BackColor = Color.WhiteSmoke;
                }
                if (indexprev == 4)
                {
                    buildingWall = false;
                    RedrawBitmap();
                }
                isclicked[index] = true;
                buttons[index].BackColor = Color.Purple;
            }
        }

        Point Animation_Current_Point;
        bool buildingWall = false;

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            Animation_Current_Point = e.Location;

            int index = -1;
            for (int i = 0; i < 5; i++)
            {
                if (isclicked[i])
                {
                    index = i;
                    break;
                }
            }
            if (index == -1)
            {
                Point CurrentPoint = e.Location;
                if (projectElements.Count > 0)
                {
                    foreach (Element element in projectElements)
                    {
                        if (element.IsPointInsideElementSet(CurrentPoint, ref Selected_Element))
                        {
                            break;
                        }
                        if (Selected_Element != null) Selected_Element.selected = false;
                        Selected_Element = null;
                    }
                    projectElements.Reverse();
                }
                RedrawBitmap();
                return;
            }

            if (index != 4)
            {
                isclicked[index] = false;
                buttons[index].BackColor = Color.WhiteSmoke;
            }

            switch (buttons[index].Name)
            {
                case "kitchen_table":
                    {
                        Graphics bitmap = Graphics.FromImage(Bitmapa.Image);
                        Image pic = (new Bitmap(DamianBisWinFormsTask.Properties.Resources.coffee_table));
                        int x = e.X - pic.Size.Width / 2, y = e.Y - pic.Size.Height / 2;
                        Element f = new Furniture(pic, new Point(x, y), buttons[index].Name);
                        f.DrawImage(bitmap);
                        projectElements.Add(f);
                        string text = "Kitchen table " + "{" + $"X={x}, Y={y}" + "}";
                        break;
                    }
                case "double_bed":
                    {
                        Graphics bitmap = Graphics.FromImage(Bitmapa.Image);
                        Image pic = (new Bitmap(DamianBisWinFormsTask.Properties.Resources.double_bed));
                        int x = e.X - pic.Size.Width / 2, y = e.Y - pic.Size.Height / 2;
                        Element f = new Furniture(pic, new Point(x, y), buttons[index].Name);
                        f.DrawImage(bitmap);
                        projectElements.Add(f);
                        string text = "Double bed " + "{" + $"X={x}, Y={y}" + "}";
                        break;
                    }
                case "table":
                    {
                        Graphics bitmap = Graphics.FromImage(Bitmapa.Image);
                        Image pic = (new Bitmap(DamianBisWinFormsTask.Properties.Resources.table));
                        int x = e.X - pic.Size.Width / 2, y = e.Y - pic.Size.Height / 2;
                        Element f = new Furniture(pic, new Point(x, y), buttons[index].Name);
                        f.DrawImage(bitmap);
                        projectElements.Add(f);
                        string text = "Table " + "{" + $"X={x}, Y={y}" + "}";
                        break;
                    }
                case "sofa":
                    {
                        Graphics bitmap = Graphics.FromImage(Bitmapa.Image);
                        Image pic = (new Bitmap(DamianBisWinFormsTask.Properties.Resources.sofa));
                        int x = e.X - pic.Size.Width / 2, y = e.Y - pic.Size.Height / 2;
                        Element f = new Furniture(pic, new Point(x, y), buttons[index].Name);
                        f.DrawImage(bitmap);
                        projectElements.Add(f);
                        string text = "Sofa " + "{" + $"X={x}, Y={y}" + "}";
                        break;
                    }
                case "wall":
                    {
                        if (e.Button == MouseButtons.Left)
                        {
                            if (!buildingWall)
                            {
                                if (Selected_Element != null) Selected_Element.selected = false;
                                Selected_Element = null;
                                Element f = new Wall(Animation_Current_Point);
                                projectElements.Add(f);
                                string text = "Wall " + "{" + $"X={Animation_Current_Point.X}, Y={Animation_Current_Point.Y}" + "}";
                            }

                            if (buildingWall)
                            {
                                Wall w = projectElements.Last() as Wall;
                                w.AddWall(Animation_Current_Point);
                            }
                            buildingWall = true;

                        }
                        else if (e.Button == MouseButtons.Right)
                        {
                            buildingWall = false;
                            isclicked[4] = false;
                            buttons[4].BackColor = Color.WhiteSmoke;
                            RedrawBitmap();
                        }
                        break;
                    }

                default:
                    {
                        break;
                    }

            }
            if (Selected_Element == null) ListBox.ClearSelected();
            Bitmapa.Refresh();
        }

        private void RedrawBitmap()
        {
            Bitmap bitmapa = new Bitmap(MaxWidth, MaxHeight);
            Graphics fl = Graphics.FromImage(bitmapa);
            fl.Clear(Color.White);
            Bitmapa.Image = bitmapa;

            foreach (Element f in projectElements)
            {
                f.DrawImage(Graphics.FromImage(bitmapa));
            }
            Bitmapa.Refresh();

            if (Selected_Element is Furniture)
            {
                ListBox.DataSource = null;
                ListBox.DataSource = projectElements;
            }
            ListBox.Refresh();

            if (Selected_Element != null && Selected_Element.selected) ListBox.SetSelected(GetIndex(Selected_Element), true);
            else if (Selected_Element != null && !Selected_Element.selected) ListBox.SetSelected(GetIndex(Selected_Element), false);
            if (Selected_Element == null) ListBox.ClearSelected();
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && Selected_Element != null)
            {
                projectElements.Remove(Selected_Element);
                Selected_Element = null;
                RedrawBitmap();
            }
        }

        private int GetIndex(Element elem)
        {
            int i = 0;
            foreach (var e in projectElements)
            {
                if (e == elem)
                {
                    break;
                }
                i++;
            }
            return i;
        }

        private void Bitmapa_MouseMove(object sender, MouseEventArgs e)
        {
            //wall drawing
            if (buildingWall)
            {
                Pen p = new Pen(Color.Black, 10);
                p.LineJoin = LineJoin.Bevel;
                Bitmap bitmapa = new Bitmap(MaxWidth, MaxHeight);
                Graphics fl = Graphics.FromImage(bitmapa);
                fl.Clear(Color.White);
                fl.DrawLine(p, Animation_Current_Point, new Point(e.X, e.Y));
                Bitmapa.Image = bitmapa;
                foreach (Element f in projectElements)
                {
                    f.DrawImage(Graphics.FromImage(bitmapa));
                }
                Bitmapa.Refresh();
            }

            //item moving
            if (Selected_Element != null)
            {
                int X = e.X - Animation_Current_Point.X;
                int Y = e.Y - Animation_Current_Point.Y;
                if (e.Button == MouseButtons.Left)
                {
                    if (Selected_Element.IsPointInsideElement(e.Location))
                    {
                        if (Selected_Element is Wall)
                        {
                            Wall w = Selected_Element as Wall;
                            Wall newWall = new Wall(new Point(w.position.X + X, w.position.Y + Y));
                            foreach (Point p in w.punkty)
                            {
                                newWall.AddWall(new Point((int)p.X + X, (int)p.Y + Y));
                            }
                            projectElements.Remove(Selected_Element);
                            Selected_Element = newWall;
                            projectElements.Add(newWall);
                        }
                        else
                        {
                            Furniture f = Selected_Element as Furniture;
                            Selected_Element.position.X += X;
                            Selected_Element.position.Y += Y;
                        }
                    }
                }
                Animation_Current_Point = e.Location;
                Selected_Element.selected = true;
                RedrawBitmap();
            }
        }


        private void splitContainer1_SizeChanged(object sender, EventArgs e)
        {

            if (splitContainer1.Panel1.Height > MaxHeight) MaxHeight = splitContainer1.Panel1.Height;
            if (splitContainer1.Panel1.Width > MaxWidth) MaxWidth = splitContainer1.Panel1.Width;
            Bitmapa.Width = MaxWidth;
            Bitmapa.Height = MaxHeight;

            RedrawBitmap();
        }


        private void OpenSchema_Click(object sender, EventArgs e)
        {

            OpenFileDialog SaveDialog = new OpenFileDialog();
            SaveDialog.Filter = "Designer (*.bd)|*.bd";
            SaveDialog.FilterIndex = 1;
            if (SaveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream fStream = File.Open(SaveDialog.FileName, FileMode.Open);
                    BinaryFormatter bFormatter = new BinaryFormatter();
                    AllDataToSave dataToSave = bFormatter.Deserialize(fStream) as AllDataToSave;
                    projectElements = dataToSave.projectElements;
                    MaxHeight = dataToSave.MaxHeight;
                    MaxWidth = dataToSave.MaxWidth;
                    fStream.Close();
                    if (CultureInfo.CurrentUICulture.Name == "pl-PL")
                        MessageBox.Show("Otwarto pomyślnie");
                    else
                        MessageBox.Show("Open succesful");
                    Selected_Element = null;
                    RedrawBitmap();
                    Bitmapa.Refresh();
                }
                catch
                {
                    if (CultureInfo.CurrentUICulture.Name == "pl-PL")
                        MessageBox.Show("Coś poszło nie tak");
                    else
                        MessageBox.Show("It's something incorrect");
                }
            }
        }

        private void SaveSchema_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveDialog = new SaveFileDialog();
            SaveDialog.Filter = "Designer (*.bd)|*.bd";
            SaveDialog.FilterIndex = 1;
            if (SaveDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fStream = File.Open(SaveDialog.FileName, FileMode.Create);
                BinaryFormatter bFormatter = new BinaryFormatter();
                AllDataToSave data = new AllDataToSave(projectElements, MaxHeight, MaxWidth);
                bFormatter.Serialize(fStream, data);
                fStream.Close();
                if (CultureInfo.CurrentUICulture.Name == "pl-PL")
                    MessageBox.Show("Zapisano pomyślnie");
                else
                    MessageBox.Show("Save succesful");
            }
            else
            {
                if (CultureInfo.CurrentUICulture.Name == "pl-PL")
                    MessageBox.Show("Coś poszło nie tak");
                else
                    MessageBox.Show("It's something incorrect");
            }
        }


        private void onMouseWheel(object sender, MouseEventArgs e)
        {
            if (Selected_Element != null)
            {
                if (Selected_Element is Furniture) Selected_Element.alfa += e.Delta / 8;
                else
                {
                    Wall w = Selected_Element as Wall;
                    Wall newWall = new Wall(w.position);
                    foreach (Point p in w.punkty)
                    {
                        newWall.AddWall(calculatePoint(p, (float)e.Delta / 10, w.position));
                    }
                    projectElements.Remove(Selected_Element);
                    projectElements.Add(newWall);
                    Selected_Element = newWall;
                }
                RedrawBitmap();
            }
            ((HandledMouseEventArgs)e).Handled = true;
        }

        private Point calculatePoint(Point p, float angle, Point center)
        {
            double R = Math.Sqrt(((p.X - center.X) * (p.X - center.X)) + ((p.Y - center.Y) * (p.Y - center.Y)));
            Point ret = new Point();
            double currangle = Math.Atan2(p.Y - center.Y, p.X - center.X) * (180 / Math.PI);
            ret.X = (int)(center.X + R * Math.Cos((angle + currangle) * (Math.PI / 180)));
            ret.Y = (int)(center.Y + R * Math.Sin((angle + currangle) * (Math.PI / 180)));
            return ret;
        }



        private void LanuagePolish_Click(object sender, EventArgs e)
        {
            int wid = MaxWidth, hig = MaxHeight;
            Size size = this.Size;
            BindingList<Element> elems = projectElements;
            Element selectedel = Selected_Element;
            CultureInfo.CurrentCulture = new CultureInfo("pl-PL");
            CultureInfo.CurrentUICulture = new CultureInfo("pl-PL");
            Controls.Clear();
            InitializeComponent();
            this.Size = size;
            ButtonsAssign();
            Selected_Element = selectedel;
            projectElements = elems;
            Bitmapa.Width = MaxWidth;
            Bitmapa.Height = MaxHeight;
            MaxHeight = hig;
            MaxWidth = wid;
            RedrawBitmap();
            ListBox.DataSource = null;
            ListBox.DataSource = elems;
            Bitmapa.MouseWheel += onMouseWheel;
        }

        private void LanguageEnglish_Click(object sender, EventArgs e)
        {
            int wid = MaxWidth, hig = MaxHeight;
            Size size = this.Size;
            BindingList<Element> elems = projectElements;
            Element selectedel = Selected_Element;
            CultureInfo.CurrentCulture = new CultureInfo("en-US");
            CultureInfo.CurrentUICulture = new CultureInfo("en-US");
            Controls.Clear();
            InitializeComponent();
            this.Size = size;
            ButtonsAssign();
            Selected_Element = selectedel;
            projectElements = elems;
            Bitmapa.Width = MaxWidth;
            Bitmapa.Height = MaxHeight;
            MaxHeight = hig;
            MaxWidth = wid;
            RedrawBitmap();
            ListBox.DataSource = null;
            ListBox.DataSource = elems;
            Bitmapa.MouseWheel += onMouseWheel;
        }
    }
}
