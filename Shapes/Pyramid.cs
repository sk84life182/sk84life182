namespace Shapes
{
	public class Pyramid : Shape
	{
		private double _s;
		private double _h;

		public Pyramid(double s, double h)
		{
			_s = s;
			_h = h;
		}

		public override string Name => "Пирамида";

		public override double Volume()
		{
			return _s * _h / 3.0;
		}
	}
}