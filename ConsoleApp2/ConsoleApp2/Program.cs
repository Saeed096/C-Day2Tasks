using System.Drawing;

namespace ConsoleApp2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
           
            // if int is struct "value type" and object is class "ref type" can struct inherit from class????? in this situation yes
            Point p1 = new Point(2,5,9);
            Point p2 = new Point(2,5,91);
            ref Point p3 = ref p1;
            Console.WriteLine(p3);
/*#####*/   Console.WriteLine("ref equals : " + object.ReferenceEquals(p1, p3));   // why false should be same ref "in implementaion use == which default behavior in struct to compare each field in struct here each fields are same"" is it working only with ref type other give unexpected results - pov is it false as p1 is variable holding data and p3 is variable holding address of another variable of point >> when converting to obj and compare ref inside refequal method >> we compare ref of var p1 with ref of ref for p1 which is p3 >> different addresses >> false????
            Console.WriteLine($"2 parameters >> {object.Equals(p2, p1)}");
/*#####*/   Console.WriteLine($"equal <1 parameter> without overloading >> {p1.Equals(p2)}");   // should this func inside value type class be abstract "its implementation differs between all children"????

            int x = 8; 
            int y = 9;
/*##### x has its own equals and so on*/  Console.WriteLine(x.Equals(y));  
            //if (p1 == p2)
            //{
            //    Console.WriteLine("equal");   
            //}

            //else
            //{
            //    Console.WriteLine("not equal");
            //}


            Console.WriteLine("equal overload");
             Console.WriteLine("p1.Equals(p2):"+ p1.Equals(p2));  // how it compare values here???? normal with struct "value types"

            p1.display();

            Console.WriteLine("tostring overload");
            Console.WriteLine (p1.ToString());
            p1.changeCoordinates(1,1,1);
            p1.display();

            Console.WriteLine("using display array");
            Point[] pointArr = [p1 , p2]; 
            Point.displayArr(pointArr);

        }
    }
}
