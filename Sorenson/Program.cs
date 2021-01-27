using System;
using System.Collections.Generic;

namespace Sorenson
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfShapes = new List<Shape>();
            Shape shape1 = new Square(); listOfShapes.Add(shape1);
            Shape shape2 = new Square(3.5); listOfShapes.Add(shape2);
            Shape shape3 = new Square(10); listOfShapes.Add(shape3);
            Shape shape4 = new Circle(4.5); listOfShapes.Add(shape4);
            Shape shape5 = new Circle(); listOfShapes.Add(shape5);
            Shape shape6 = new Square(30); listOfShapes.Add(shape6);
            Shape shape7 = new Circle(5); listOfShapes.Add(shape7);


            foreach(Shape shape in listOfShapes){
                Console.WriteLine("The current shape name is:" + shape.GetName());
                Console.WriteLine("Area of current shape is: " + shape.GetArea());
            }
            Console.ReadKey();
        }
    }
}



interface Shape {
    public double GetArea();
    public string GetName();
}

class Square : Shape {

    private double sideLength;

    // default constructor to set sideLength to '2';
    public Square() {
        this.sideLength = 2;
    }

    // customized constructor to set the sideLength to a specific length
    public Square(double sideLength) {
        this.sideLength = sideLength;
    }

    //returns area of the square
    public double GetArea() {
        double area = this.sideLength * this.sideLength;
        return area;
    }

    //returns name of the Shape
    public string GetName() {
        return "Square";
    }
}

class Circle : Shape
{
    const double PI = 3.14;
    private double radius;

    // default constructor to set radius to '2';
    public Circle()
    {
        this.radius = 2;
    }

    // customized constructor to set the radius to a specific length
    public Circle(double radius)
    {
        this.radius = radius;
    }

    //returns Area of the circle
    public double GetArea()
    {
        double area = PI * this.radius * this.radius;
        return area;
    }

    //returns name of the Shape
    public string GetName()
    {
        return "Circle";
    }
}
