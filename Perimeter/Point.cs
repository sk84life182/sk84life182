namespace Perimeter
{
	public class Point
	{
		public Point(double x, double y, string name)
		{
			X = x;
			Y = y;
			Name = name;
		}


		public double X { get; }

		public double Y { get; }

		public string Name { get; }
	}
}