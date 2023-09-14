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
			IAreaFigure circle = new Circle(radius);
			//Action
			var result = _areaCalculator.calulateArea(circle);
			//Assert
			Assert.True(result > 0);
		}
		[Fact]
		public void Area_of_triangle_is_calculated()
		{
			//Arrange
			var sidaA = 5;
			var sidaB = 6;
			var sidaC = 7;
			IAreaFigure triangle = new Triangle(sidaA, sidaB, sidaC);
			//Action
			var result = _areaCalculator.calulateArea(triangle);
			//Assert
			Assert.True(result > 0);
		}
		[Fact]
		public void Triangle_contains_a_right_angle()
		{
			//Arrange
			var sidaA = 3;
			var sidaB = 4;
			var sidaC = 5;
			Triangle triangle = new Triangle(sidaA, sidaB, sidaC);
			//Action
			var result = triangle.IsRightTraingle();
			//Assert
			Assert.True(result);
		}
		[Fact]
		public void Triangle_not_contains_a_right_angle()
		{
			//Arrange
			var sidaA = 5;
			var sidaB = 7;
			var sidaC = 12;
			Triangle triangle = new Triangle(sidaA, sidaB, sidaC);
			//Action
			var result = triangle.IsRightTraingle();
			//Assert
			Assert.False(result);
		}
	}
}