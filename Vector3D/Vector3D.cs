using System;


namespace Vector3D
{
	public class Vector3D
	{
		private readonly double _x;
		private readonly double _y;
		private readonly double _z;


		public Vector3D(double x, double y, double z)
		{
			_x = x;
			_y = y;
			_z = z;
		}


		public double Length()
		{
			return Math.Sqrt(
				_x * _x +
				_y * _y +
				_z * _z);
		}

		public double ScalarMultiplication(Vector3D other)
		{
			return
				_x * other._x +
				_y * other._y +
				_z * other._z;
		}

		public Vector3D VectorMultiplication(Vector3D other)
		{
			return new Vector3D(
				_y * other._z - _z * other._y,
				_z * other._x - _x * other._z,
				_x * other._y - _y * other._x);
		}

		public double Angle(Vector3D other)
		{
			double length = Length();
			double otherLength = other.Length();
			if (length == 0 || otherLength == 0)
			{
				Console.WriteLine("Ошибка\nНевозможно получить угол для нулевого вектора");
				return default;
			}

			return ScalarMultiplication(other) / (length * otherLength);
		}

		public Vector3D Sum(Vector3D other)
		{
			return new Vector3D(
				_x + other._x,
				_y + other._y,
				_z + other._z);
		}

		public Vector3D Difference(Vector3D other)
		{
			return new Vector3D(
				_x - other._x,
				_y - other._y,
				_z - other._z);
		}

		public override string ToString()
		{
			return $"(Vector {{{_x}, {_y}, {_z}}})";
		}
	}
}