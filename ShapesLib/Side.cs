namespace ShapesLib
{
	/// <summary> Сторона геометрической фигуры</summary>
	public class Side
	{
		private double value;
		/// <summary>
		/// Значение стороны
		/// </summary>
		/// <exception cref="ArgumentOutOfRangeException"> Если значение меньше или равно нулю или равно бесконечности или равно NaN </exception>

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
