using System;
using System.Collections.Generic;

namespace Perimeter
{
	class Polygon
	{
		private List<Point> _points;
		public string Name { get; }


		public Polygon(Point point1, Point point2, Point point3)
		{
			_points = new List<Point> { point1, point2, point3 };

			Name = "Треугольник";
		}

		public Polygon(Point point1, Point point2, Point point3, Point point4)
		{
			_points = new List<Point> { point1, point2, point3, point4 };

			Name = "Четырёхугольник";
		}

		public Polygon(Point point1, Point point2, Point point3, Point point4, Point point5)
		{
			_points = new List<Point> { point1, point2, point3, point4, point5 };

			Name = "Пятиугольник";
		}


		public double Perimeter()
		{
			int lastI = _points.Count - 1;

			double perimeter = 0.0;
			for (int i = 0; i < _points.Count; ++i)
			{
				int nextI =  i == lastI ? 0 : i+1;
				perimeter += Distance2D(_points[i], _points[nextI]);
			}
			return perimeter;
		}

		public override string ToString()
		{
			return $"{Name} с периметром {Perimeter()}.";
		}


		private double Distance2D(Point point1, Point point2)
		{
			return Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
		}

	}
}