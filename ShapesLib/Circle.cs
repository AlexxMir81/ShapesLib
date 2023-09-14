namespace ShapesLib
{
	public class Circle : IAreaFigure
	{
		//private double radius;
		//public double Radius
		//{
		//	get { return radius; }
		//	set
		//	{
		//		if (value <= 0d || double.IsInfinity(radius) || double.IsNaN(radius))
		//		{
		//			throw new ArgumentOutOfRangeException(nameof(value));
		//		}
		//		radius = value;
		//	}
		//}

		public Radius MyRadius { get; set; }
		public class Radius
		{
			private double value;
			public double Value
			{
				get { return value; }
				set
				{
					if (value <= 0d || double.IsInfinity(value) || double.IsNaN(value))
					{
						throw new ArgumentOutOfRangeException(nameof(value));
					}
					this.value = value;
				}
			}
		}
		public Circle(double radius)
		{
			//if (radius <= 0d || double.IsInfinity(radius) || double.IsNaN(radius))
			//{
			//	throw new ArgumentOutOfRangeException(nameof(radius));
			//}
			this.MyRadius = new Radius();
			MyRadius.Value= radius;
		}
		public double CalculateArea() => MyRadius.Value *MyRadius.Value * Math.PI;

	}
}

