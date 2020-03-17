using System;


namespace Vector3D
{
	class Program
	{
		static void Main()
		{
			var vector1 = new Vector3D(1, 2, 3);
			var vector2 = new Vector3D(3, 3, 3);

			Console.WriteLine($"Длина: {vector1.Length()}.");
			Console.WriteLine($"Скалярное произведение: {vector1.ScalarMultiplication(vector2)}.");
			Console.WriteLine($"Векторное произведение: {vector1.VectorMultiplication(vector2)}.");
			Console.WriteLine($"Угол: {vector1.Angle(vector2)}.");
			Console.WriteLine($"Сумма: {vector1.Sum(vector2)}.");
			Console.WriteLine($"Разность: {vector1.Difference(vector2)}.");

			Console.ReadKey();
		}
	}
}