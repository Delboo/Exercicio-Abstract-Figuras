using ExercicioAbstrato.Entities.Enums;
namespace ExercicioAbstrato.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Hight { get; set; }

        public Rectangle (double width, double hight, Color color) : base(color)
        {
            Width = width;
            Hight = hight;

        }

        public override double Area()
        {
            return Width * Hight;
        }
    }
}

