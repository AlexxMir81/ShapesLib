namespace ShapesLib
{
	/// <summary> Радиус окружности</summary>
	public class Radius
	{
		private double value;
		/// <summary>
		/// Значение радиуса
		/// </summary>
		/// <exception cref="ArgumentOutOfRangeException"> Если значение меньше или равно нулю или равно бесконечности или равно NaN </exception>
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

