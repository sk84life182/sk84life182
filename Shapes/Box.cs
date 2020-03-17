using System;
using System.Collections.Generic;

namespace Shapes
{
	public class Box : Shape
	{
		private double _height;
		private double _filledVolume;

		private List<Shape> _shapes = new List<Shape>();

		public Box(double height)
		{
			_height = height;
		}

		public override string Name => "Куб";

		public List<Shape> Shapes { get; private set; } = new List<Shape>();

		public double RemainingVolume()
		{
			return Volume() - _filledVolume;
		}
		public bool Add(Shape shape)
		{
			double remainingVolume = RemainingVolume();
			double shapeVolume = shape.Volume();

			if (remainingVolume >= shapeVolume)
			{
				_shapes.Add(shape);
				_filledVolume += shapeVolume;
				return true;
			}
			else
			{
				return false;
			}
		}


		public override double Volume()
		{
			return Math.Pow(_height, 3);
		}
	}
}