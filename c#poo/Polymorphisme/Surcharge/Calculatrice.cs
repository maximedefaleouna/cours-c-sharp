using System;

namespace c_poo.Polymorphisme.Surcharge;

public class Calculatrice
{
    public int Additionner(int a, int b)
    {
        return a + b;
    }

    public double Additionner(double a, double b)
    {
        return a + b;
    }

    public int Additionner(int a, int b, int c)
    {
        return a + b + c;
    }
}
