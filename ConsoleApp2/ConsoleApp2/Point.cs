using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal struct Point
    {
       public int x, y, z;
       public Point (int x , int y , int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static bool operator ==(Point p1, Point p2)
        {
            return (p1.x == p2.x && p1.y == p2.y && p1.z == p2.z);
        }

        public static bool operator !=(Point p1, Point p2)
        {
            return (p1.x != p2.x || p1.y != p2.y || p1.z != p2.z);
        }

        public void display()
        {
            Console.WriteLine($"this point coordinates are : {this.x} , {this.y} and {this.z}");
        }

        public void changeCoordinates(int x , int y , int z)
        {
            this .x = x;
            this .y = y;
            this .z = z;
        }

        public override string ToString()
        {
            return $"this is a description for point with coordinates {x} , {y} and {z}";
        }

        //public override bool Equals(object obj)
        //{
        //    if (obj is Point)     // cannot use ref here???? yes its a value type
        //    {
        //        // Point newP = obj as Point;   // as with ref type only   yes
        //        Point newP = (Point)obj;

        //        if (x == newP.x && y == newP.y && z == newP.z)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    else
        //    { return false; }

        //}

        public static void displayArr(Point[] pointArr)
        {
            for(int i = 0; i < pointArr.Length; i++) 
            {
                Console.WriteLine($"point number {i + 1} coordinates are {pointArr[i].x} , {pointArr[i].y} and {pointArr[i].z}");
            }
        }
    }
}
