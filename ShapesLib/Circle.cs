namespace ShapesLib
{
	public class Circle : IAreaFigure
	{
		private double radius;
		public double Radius
		{
			get { return radius; }
			set
			{
				if (value <= 0d || double.IsInfinity(radius) || double.IsNaN(radius))
				{
					throw new ArgumentOutOfRangeException(nameof(value));
				}
				radius = value;
			}
		}
		public Circle(double radius)
		{
			this.radius = radius;
		}
		public double CalculateArea() => radius * radius * Math.PI;

		}
	}
}
