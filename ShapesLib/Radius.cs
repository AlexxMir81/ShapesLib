namespace ShapesLib
{
	public partial class Circle
	{
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

	}
}

