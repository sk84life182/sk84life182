using System;


namespace Perimeter
{
	class Program
	{
		private static void Main()
		{
			Point point1 = new Point(0, 0,   nameof(point1));
			Point point2 = new Point(0, 3,   nameof(point2));
			Point point3 = new Point(1.5, 4, nameof(point3));
			Point point4 = new Point(3, 3,   nameof(point4));
			Point point5 = new Point(3, 0,   nameof(point5));

			Polygon polygon1 = new Polygon(point1, point2, point5);
			Polygon polygon2 = new Polygon(point1, point2, point4, point5);
			Polygon polygon3 = new Polygon(point1, point2, point3, point4, point5);

			Console.WriteLine(polygon1);
			Console.WriteLine(polygon2);
			Console.WriteLine(polygon3);

			Console.ReadKey();
		}
	}
}