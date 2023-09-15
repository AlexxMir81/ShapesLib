namespace ShapesLib
{
	public partial class Square: IShapes
	{
        //public Side MySide { get; set; }

		private Side mySide;

		public Side MySide
		{
			get { return mySide; }
			set {
				mySide = value;
				diagonal = MySide.Value * Math.Sqrt(2d);
			}
		}
		private double diagonal;

		public double Diagonal
		{
			get { return diagonal; }
		}

        public Square(double side)
		{
			this.MySide = new Side();
			MySide.Value = side;
			diagonal = MySide.Value*Math.Sqrt(2d);
		}

		public double CalculateArea()
		{
			return MySide.Value*MySide.Value;
		}
	}
}