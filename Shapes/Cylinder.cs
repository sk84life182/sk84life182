using System;

namespace Shapes
{
	public class Cylinder : Shape
	{
		private double _radius;
		private double _height;

		public Cylinder(double r, double h)
		{
			_radius = r;
			_height = h;
		}

		public override string Name => "Цилиндр";
		public override double Volume()
		{
			return Math.PI * Math.Pow(_radius, 2)  * _height;
		}
	}
}