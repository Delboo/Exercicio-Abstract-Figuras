using ExercicioAbstrato.Entities.Enums;

namespace ExercicioAbstrato.Entities
{
    abstract class Shape
    {
        public Color color { get; set; }

        public Shape(Color color)
        {
            this.color = color;
        }

        public abstract double Area(); 
    }
}
