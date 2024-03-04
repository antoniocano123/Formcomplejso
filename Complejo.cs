using System;

namespace Formcomplejso
{
    internal class Complejo
    {
        private float real;
        private float imaginaria;

        public Complejo(float real, float imaginaria)
        {
            this.real = real;
            this.imaginaria = imaginaria;
        }


        public static Complejo Leer(string complejo)
        {
            string[] realComplejo = complejo.Split('+');
            float real = float.Parse(realComplejo[0]);
            float imaginaria = float.Parse(realComplejo[1].Replace('i', ' '));
            return new Complejo(real, imaginaria);

        }
        public override string ToString()
        {
            if (Complejo == -)
            {

            }

            return String.Format("{0}  {1}i", real, imaginaria);
        }

        public static Complejo operator +(Complejo c1, Complejo c2)
        {
            return new Complejo(c1.real + c2.real, c1.imaginaria + c2.imaginaria);
        }

        public static Complejo operator -(Complejo c1, Complejo c2)
        {
            return new Complejo(c1.real - c2.real, c1.imaginaria - c2.imaginaria);
        }


        public static Complejo operator *(Complejo c1, Complejo c2)
        {
            return new Complejo((c1.real * c2.real) + (c1.real * c2.imaginaria) + (c1.imaginaria * c2.real) + (c1.imaginaria * c2.imaginaria));
        }



    }

}
