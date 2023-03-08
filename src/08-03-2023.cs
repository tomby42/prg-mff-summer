/*
# NPRG031 Programování 2  – cvičení

https://www.youtube.com/watch?v=QjJaFG63Hlo
*/


/*
VSCode:

mkdir MyApp
cd MyApp
dotnet new console

File → Open Folder
select the MyApp
Select Yes 

"console": "integratedTerminal" in launch.json file
*/

using System;

namespace Cviceni {
    internal class Program {
        static void Main(string[] args) {
            shapes();
        }

        static void shapes() {
            Shape[] shapes = new Shape[3];
            Rectangle rect;

            // create some shape instances
            shapes[0] = new Rectangle(10, 20, 5, 6);
            shapes[1] = new Circle(15, 25, 8);
            shapes[2] = new Square(30,30,10);

            // iterate through the list and handle shapes polymorphically
            for (int i = 0; i < shapes.Length; i++) {
                shapes[i].draw();
                shapes[i].rMoveTo(100, 100);
                shapes[i].draw();
            }

            // call a rectangle specific function
            rect = new Rectangle(0, 0, 15, 15);
            rect.setWidth(30);
            rect.draw();
        }
    }

    public abstract class Shape {
        private int x;
        private int y;

        // constructor
        public Shape(int newx, int newy) {
            setX(newx);
            setY(newy);
        }

        // accessors for x & y coordinates
        public int getX() { return x; }
        public int getY() { return y; }
        public void setX(int newx) { x = newx; }
        public void setY(int newx) { y = newx; }

        // move the x & y coordinates
        public void moveTo(int newx, int newy) {
            setX(newx);
            setY(newy);
        }
        public void rMoveTo(int deltax, int deltay) {
            moveTo(deltax + getX(), deltay + getY());
        }

        // virtual routine - draw the shape
        public abstract void draw();
        public abstract double area();
        public abstract double circumference();
   }

   public class Rectangle: Shape {
        private int width;
        private int height;

        // constructor
        public Rectangle(int newx, int newy, int newwidth, int newheight): base(newx, newy) {
            setWidth(newwidth);
            setHeight(newheight);
        }

        // accessors for width & height
        public int getWidth() { return width; }
        public int getHeight() { return height; }
        public void setWidth(int newwidth) { width = newwidth; }
        public void setHeight(int newheight) { height = newheight; }

        // draw the rectangle
        public override void draw() {
            Console.WriteLine("Drawing a Rectangle at:({0},{1}), Width {2}, Height {3}, Area {4}, Circumference {5}",
                getX(), getY(), getWidth(), getHeight(), area(), circumference());
        }
        public override double area() {
            return width*height;
        }
        public override double circumference() {
            return 2*(width+height);
        }
   }

    // Cviceni: napiste tridu Circle, Square

    public class Circle: Shape {
        private int radius;

        // constructor
        public Circle(int newx, int newy, int newradius): base(newx, newy) {
            setRadius(newradius);
        }

        // accessors for the radius
        public int getRadius() { return radius; }
        public void setRadius(int newradius) { radius = newradius; }

        // draw the circle
        public override void draw() {
            Console.WriteLine("Drawing a Circle at:({0},{1}), Radius {2}, Area {3}, Circumference {4}",
                getX(), getY(), getRadius(), area(), circumference());
        }

        public override double area() {
            return Math.PI*radius;
        }
        public override double circumference() {
            return 2*Math.PI*radius;
        }
   }

    public class Square : Rectangle {
        public Square(int newx, int newy, int size) : base(newx, newy, size, size) {
        }

        public override void draw() {
            Console.WriteLine("Drawing a Square at:({0},{1}), Size {2},  Area {3}, Circumference {4}",
                getX(), getY(), getWidth(), area(), circumference());
        }
    }

}

