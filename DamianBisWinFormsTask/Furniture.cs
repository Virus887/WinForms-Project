using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;


namespace DamianBisWinFormsTask
{
    [Serializable()]
    public class Furniture : Element
    {

        public Image image;

        public Furniture(Image image, Point pos, string name) : base(name)
        {
            position = pos;
            this.image = image;
        }

        public override void DrawImage(Graphics bitmap)
        {
            ImageAttributes imageAttributes = new ImageAttributes();
            int width = image.Width;
            int height = image.Height;

            float[][] colorMatrixElements = {
                                       new float[] {1,  0,  0,  0, 0},
                                       new float[] {0,  1,  0,  0, 0},
                                       new float[] {0,  0,  1,  0, 0},
                                       new float[] {0,  0,  0,  .5f, 0},
                                       new float[] {0, 0, 0, 0, 1}};

            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);

            imageAttributes.SetColorMatrix(
               colorMatrix,
               ColorMatrixFlag.Default,
               ColorAdjustType.Bitmap);


            Image image2 = RotateImage(image, alfa);

            if (selected)
            {
                bitmap.DrawImage(
                                       image2,
                                       new Rectangle(position.X, position.Y, image2.Width, image2.Height),  // destination rectangle 
                                       0, 0,        // upper-left corner of source rectangle 
                                       image2.Width,       // width of source rectangle
                                       image2.Height,      // height of source rectangle
                                       GraphicsUnit.Pixel,
                                       imageAttributes);
            }
            else bitmap.DrawImage(image2, position);
        }


        //https://stackoverflow.com/questions/2163829/how-do-i-rotate-a-picture-in-winforms
        public static Image RotateImage(Image img, float rotationAngle)
        {
            //create an empty Bitmap image
            Bitmap bmp = new Bitmap(img.Width + 100, img.Height + 100);

            //turn the Bitmap into a Graphics object
            Graphics gfx = Graphics.FromImage(bmp);

            //now we set the rotation point to the center of our image
            gfx.TranslateTransform((float)img.Width / 2, (float)img.Height / 2);

            //now rotate the image
            gfx.RotateTransform(rotationAngle);

            gfx.TranslateTransform(-(float)img.Width / 2, -(float)img.Height / 2);

            //now draw our new image onto the graphics object
            gfx.DrawImage(img, new Point(0, 0));

            //dispose of our Graphics object
            gfx.Dispose();

            //return the image
            return bmp;
        }

        public override bool IsPointInsideElementSet(Point point, ref Element Selected_Element)
        {
            int lenX = image.Width;
            int lenY = image.Height;
            if (point.X > position.X && point.X < position.X + lenX && point.Y > position.Y && point.Y < position.Y + lenY)
            {

                if (Selected_Element != null && Selected_Element != this) Selected_Element.selected = false;

                if (selected == false)
                {
                    selected = true;
                    Selected_Element = this;
                }
                else
                {
                    selected = false;
                    Selected_Element = null;
                }
                return true;
            }
            return false;
        }

        public override bool IsPointInsideElement(Point point)
        {
            int lenX = image.Width;
            int lenY = image.Height;
            if (point.X > position.X && point.X < position.X + lenX && point.Y > position.Y && point.Y < position.Y + lenY) return true;
            return false;
        }

        public override string ToString()
        {
            string text = "";
            switch (Name)
            {
                case "kitchen_table":
                    {
                        if (CultureInfo.CurrentUICulture.Name == "pl-PL")
                            return text = "Stół kuchenny " + "{" + $"X={position.X}, Y={position.Y}" + "}";
                        else
                            return text = "Kitchen table " + "{" + $"X={position.X}, Y={position.Y}" + "}";

                    }
                case "double_bed":
                    {
                        if (CultureInfo.CurrentUICulture.Name == "pl-PL")
                            return text = "Podwójne łóżko " + "{" + $"X={position.X}, Y={position.Y}" + "}";
                        else
                            return text = "Double bed " + "{" + $"X={position.X}, Y={position.Y}" + "}";
                    }
                case "table":
                    {
                        if (CultureInfo.CurrentUICulture.Name == "pl-PL")
                            return text = "Stół " + "{" + $"X={position.X}, Y={position.Y}" + "}";
                        else
                            return text = "Table " + "{" + $"X={position.X}, Y={position.Y}" + "}";
                    }
                case "sofa":
                    {
                        if (CultureInfo.CurrentUICulture.Name == "pl-PL")
                            return text = "Kanapa " + "{" + $"X={position.X}, Y={position.Y}" + "}";
                        else
                            return text = "Sofa " + "{" + $"X={position.X}, Y={position.Y}" + "}";
                    }
                default:
                    {

                        break;
                    }
            }
            return text;
        }
    }

}
