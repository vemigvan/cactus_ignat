using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab9_1v
{
    class Picture : IDraw
    {
        public List<Shape> shapes;

        public int Length { get; set; }

        public Picture()
        {
            shapes = new List<Shape>(0);
        }
        public Picture(int quantity)
        {
            shapes = new List<Shape>(quantity);
        }


        public Shape this[int index]
        {
            get { return shapes[index]; }
            set { shapes[index] = value; }
        }

        public void AddShape(Shape figure)
        {
            shapes.Add(figure);
            Length++;

        }

        public void DeleteShape(string name)
        {
            for (int i = 0; i < Length; i++)
            {
                if (shapes[i].Name == name)
                {
                    shapes.Remove(shapes[i]);
                    Length--;
                }
            };
        }
        public void DeleteShape(double maxArea)
        {
            for (int i = 0; i < Length; i++)
            {
                if (shapes[i].Area() > maxArea)
                {
                    shapes.Remove(shapes[i]);
                    Length--;
                }
            }
        }
        public void DeleteShape(Type shapeClass)
        {
            for (int i = 0; i < Length; i++)
            {
                if (shapes[i].GetType() == shapeClass)
                {
                    shapes.Remove(shapes[i]);
                    Length--;
                }
            }
        }

        

        public void Draw()
        {
            foreach (Shape el in shapes)
            {
                Circle el_1;
                Square el_2;
                Triangle el_3;
                if (el is Circle)
                {
                    el_1 = (Circle)el;
                    el_1.Draw();
                }
                else if (el is Square)
                {
                    el_2 = (Square)el;
                    el_2.Draw();
                }
                else
                {
                    el_3 = (Triangle)el;
                    el_3.Draw();
                }
            }
        }



    }
}
