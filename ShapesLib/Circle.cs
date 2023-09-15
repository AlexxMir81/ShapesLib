namespace ShapesLib
{
	/// <summary> Круг </summary>
	public partial class Circle : IShapes
	{
		/// <summary>
		/// Радиус круга
		/// </summary>
		public Radius MyRadius { get; set; }

		/// <summary>
		/// Конструктор круга
		/// </summary>
		/// <param name="radius">Радиус круга</param>
		/// <exception cref="ArgumentOutOfRangeException"> Если радиус меньше или равен нулю или равен бесконечности или равен NaN </exception>
		public Circle(double radius)
		{
			this.MyRadius = new Radius();
			MyRadius.Value= radius;
		}

		/// <summary>
		///  Площадь круга
		/// </summary>
		public double CalculateArea() => MyRadius.Value *MyRadius.Value * Math.PI;

	}
}

