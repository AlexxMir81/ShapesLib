namespace ShapesLib
{
	public class Side
	{
		private double value;

		public double Value
		{
			get { return value; }
			set
			{
				if (value <= 0 || double.IsInfinity(value) || double.IsNaN(value))
				{
					throw new ArgumentOutOfRangeException(nameof(value));
				}
				this.value = value;
			}
		}

	}

}
