using System;

namespace Shapes
{
	public class Ball : Shape
	{
		private double _radius;


		public Ball(double r)
		{
			_radius = r;
		}

		public override string Name => "Шар";

		public override double Volume()
		{
			return (4.0 / 3.0) * Math.PI * Math.Pow(_radius, 3); 
		}
	}
}