using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechMindbox
{
    public class Triangle : ITriangle
    {
        public Triangle(double eadgeA, double eadgeB, double eadgeC)
        {
            if (eadgeA < 0)
                throw new ArgumentException("Неверное зачение.", nameof(eadgeA));
            if (eadgeB < 0)
                throw new ArgumentException("Неверное зачение.", nameof(eadgeB));
            if (eadgeC < 0)
                throw new ArgumentException("Неверное зачение.", nameof(eadgeC));

            double largeEadge = Math.Max(eadgeA, Math.Max(eadgeB, eadgeC));
            double perimeter = eadgeA + eadgeB + eadgeC;

            if ((perimeter - largeEadge) < 0)
                throw new Exception("Наибольшая сторона треугольника не может быть больше суммы остальных сторон.");

            EadgeA = eadgeA;
            EadgeB = eadgeB;
            EadgeC = eadgeC;

            _isRightTriangle = new Lazy<bool>(GetIsRightTriangle);

        }

        private bool GetIsRightTriangle()
        {
            double hypotenuse = Math.Max(EadgeA, Math.Max(EadgeB, EadgeC));
            double b, c;
            if (hypotenuse == EadgeA)
            {
                b = EadgeB;
                c = EadgeC;
            }
            if (hypotenuse == EadgeB)
            {
                b = EadgeA;
                c = EadgeC;
            }
            else { b = EadgeB; c = EadgeA; }

            return Math.Pow(hypotenuse, 2) == (Math.Pow(b, 2) + Math.Pow(c, 2));
        }

        public double EadgeA { get; }

        public double EadgeB { get; }

        public double EadgeC { get; }

        private readonly Lazy<bool> _isRightTriangle;
        public bool IsRightTriangle => _isRightTriangle.Value;

        public double GetSquare()
        {
            // Формула Герона

            double halfPeriment = (EadgeA + EadgeB + EadgeC) / 2d;
            return Math.Sqrt(halfPeriment * (halfPeriment - EadgeA) *
                (halfPeriment - EadgeB) *
                (halfPeriment - EadgeC)); 

        }
    }
}
