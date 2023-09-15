namespace ShapesLib
{
	public partial class Circle : IShapes
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

