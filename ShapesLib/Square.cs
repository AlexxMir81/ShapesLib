namespace ShapesLib
{
	/// <summary> Круг </summary>
	public partial class Square: IShapes
	{
		private Side mySide;
		/// <summary>
		/// Радиус круга
		/// </summary>
		public Side MySide
		{
			get { return mySide; }
			set {
				mySide = value;
				diagonal = MySide.Value * Math.Sqrt(2d);
			}
		}
		private double diagonal;
		/// <summary>
		/// Диагональ квадрата
		/// </summary>
		public double Diagonal
		{
			get { return diagonal; }
		}
		/// <summary>
		/// Конструктор квадрата
		/// </summary>
		/// <param name="side">Сторона квадрата</param>
		/// <exception cref="ArgumentOutOfRangeException"> Если сторона меньше или равна нулю или равна бесконечности или равна NaN </exception>
		public Square(double side)
		{
			this.MySide = new Side();
			MySide.Value = side;
			diagonal = MySide.Value*Math.Sqrt(2d);
		}
		/// <summary>
		///  Площадь квадрата
		/// </summary>
		public double CalculateArea()
		{
			return MySide.Value*MySide.Value;
		}
	}
}