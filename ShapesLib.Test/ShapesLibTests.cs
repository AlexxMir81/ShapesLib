using FluentAssertions;
namespace ShapesLib.Test
{
	public class ShapesLibTests
	{
		private readonly AreaCalculator _areaCalculator;
		public ShapesLibTests()
		{
			this._areaCalculator = new AreaCalculator();
		}
		[Fact]
		public void Circle_is_created()
		{
			//Arrange
			var radius = 10d;
			//Action
			Circle circle = new Circle(radius);
			//Assert
			circle.MyRadius.Value.Should().Be(10d);
		}

		[Theory]
		[InlineData(-10d)]
		[InlineData(0)]
		[InlineData(double.PositiveInfinity)]
		[InlineData(double.NegativeInfinity)]
		[InlineData(double.NaN)]
		public void Creation_of_circle_with_incorrect_radius_get_exception(double radius)
		{
			FluentActions.Invoking(() => new Circle(radius: radius))
			.Should()
			.Throw<ArgumentOutOfRangeException>();
		}

		[Fact]
		public void Area_of_circle_is_calculated()
		{
			//Arrange
			var radius = 5;
			//Action
			var circle = new Circle(radius);
			//Assert
			circle.CalculateArea().Should().BeGreaterThan(0d);
		}

		[Fact]
		public void Triangle_is_created()
		{
			//Avarage
			var sidaA = 5;
			var sidaB = 6;
			var sidaC = 7;
			//Action
			var triangle  = new Triangle(sidaA, sidaB, sidaC);
			//Assert
			triangle.Should().NotBeNull();
			triangle.A.Value.Should().Be(sidaA);
			triangle.B.Value.Should().Be(sidaB);
			triangle.C.Value.Should().Be(sidaC);
		}

		[Theory]
		[InlineData(-1d, 2d, 3d)]
		[InlineData(1d, -2d, 3d)]
		[InlineData(1d, 2d, -3d)]
		[InlineData(0d, 2d, 3d)]
		[InlineData(1d, 0d, 3d)]
		[InlineData(1d, 2d, 0d)]
		[InlineData(double.NegativeInfinity, 2d, 3d)]
		[InlineData(1d, double.NegativeInfinity, 3d)]
		[InlineData(1d, 2d, double.NegativeInfinity)]
		[InlineData(double.PositiveInfinity, 2d, 3d)]
		[InlineData(1d, double.PositiveInfinity, 3d)]
		[InlineData(1d, 2d, double.PositiveInfinity)]
		[InlineData(double.NaN, 2d, 3d)]
		[InlineData(1d, double.NaN, 3d)]
		[InlineData(1d, 2d, double.NaN)]
		public void Creation_triangle_with_incorrect_sides_is_rejected(double a, double b, double c)
		{
			FluentActions.Invoking(()=> new Triangle(a, b, c))
			.Should()
			.Throw<ArgumentOutOfRangeException>();
		}

		[Theory]
		[InlineData(1d, 2d, 4d)]
		[InlineData(4d, 1d, 2d)]
		[InlineData(1d, 2d, 3d)]
		[InlineData(1d, 2d, 6)]
		public void Creation_of_not_existed_triangle_is_rejected(double a, double b, double c)
		{
			FluentActions.Invoking(()=> new Triangle(a, b, c)) .Should().Throw<ArgumentOutOfRangeException>();
		}

		[Fact]
		public void Area_of_triangle_is_calculated()
		{
			//Arrange
			var sidaA = 5;
			var sidaB = 6;
			var sidaC = 7;
			IShapes triangle = new Triangle(sidaA, sidaB, sidaC);
			//Action
			var result = _areaCalculator.calulateArea(triangle);
			//Assert
			Assert.True(result > 0);
		}
		//[Fact]
		//public void Triangle_contains_a_right_angle()
		//{
		//	//Arrange
		//	var sidaA = 3;
		//	var sidaB = 4;
		//	var sidaC = 5;
		//	Triangle triangle = new Triangle(sidaA, sidaB, sidaC);
		//	//Action
		//	var result = triangle.IsRightTraingle();
		//	//Assert
		//	Assert.True(result);
		//}
		//[Fact]
		//public void Triangle_not_contains_a_right_angle()
		//{
		//	//Arrange
		//	var sidaA = 5;
		//	var sidaB = 6;
		//	var sidaC = 7;
		//	Triangle triangle = new Triangle(sidaA, sidaB, sidaC);
		//	//Action
		//	var result = triangle.IsRightTraingle();
		//	//Assert
		//	Assert.False(result);
		//}
		[Theory]
		[InlineData(3d, 4d, 5d, true)]
		[InlineData(5d, 6d, 7d, false)]
		public void Triangle_contains_a_right_angle(double a, double b, double c, bool isRight)
		{
			var triangle = new Triangle(a, b, c);
			triangle.IsRightTraingle().Should().Be(isRight);
		}

		[Fact]
		public void Circle_and_Triangle_are_Shapes()
		{
			var cirle = new Circle(10d);
			var triangle = new Triangle(50d,60d, 70d);
			cirle.Should().BeAssignableTo<IShapes>();
			triangle.Should().BeAssignableTo<IShapes>();
		}
	}
}