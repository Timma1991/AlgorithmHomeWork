using BenchmarkDotNet.Attributes;

namespace MyLongHomework
{
    public class PointBenchmarks
    {


        public static readonly int razmer = 10000000; // размер массива данных

        public class PointClass // вариант для ссылочного типа
        {
            public float X;
            public float Y;
        }

        public struct PointStructF // вариант для типа float
        {
            public float X;
            public float Y;
        }

        public struct PointStructD // вариант для типа double
        {
            public double X;
            public double Y;
        }
        // объявляем массивы с данными
        public PointStructF[] masF = new PointStructF[razmer + 1];
        public PointStructD[] masD = new PointStructD[razmer + 1];
        public PointClass[] masC = new PointClass[razmer + 1];

        public float PointDistance1(ref PointClass pointOne, ref PointClass pointTwo) // вариант теста 1
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }

        public float PointDistance2(PointStructF pointOne, PointStructF pointTwo) // вариант теста 2
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }

        public double PointDistance3(PointStructD pointOne, PointStructD pointTwo) // вариант теста 3
        {
            double x = pointOne.X - pointTwo.X;
            double y = pointOne.Y - pointTwo.Y;
            return Math.Sqrt((x * x) + (y * y));
        }

        public float PointDistance4(PointStructF pointOne, PointStructF pointTwo) // вариант теста 4
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return Sqrt((x * x) + (y * y));
        }

        public float Sqrt(float x)
        {
            float s = ((x / 2) + x / (x / 2));
            for (int i = 0; i < 4; i++)
            {
                s = (s + x / s) / 2;
            }
            return s;
        }

        [Benchmark]
        public void First()
        {
            for (int i = 0; i < razmer; i++)
            {
                PointDistance1(ref masC[i], ref masC[i + 1]);
            }
        }

        [Benchmark]
        public void Second()
        {
            for (int i = 0; i < razmer; i++)
            {
                PointDistance2(masF[i], masF[i + 1]);
            }
        }

        [Benchmark]
        public void Third()
        {
            for (int i = 0; i < razmer; i++)
            {
                PointDistance3(masD[i], masD[i + 1]);
            }
        }

        [Benchmark]
        public void Fourth()
        {
            for (int i = 0; i < razmer; i++)
            {
                PointDistance4(masF[i], masF[i + 1]);
            }
        }

    }
}