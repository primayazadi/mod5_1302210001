﻿internal class Program
{
    private static void Main(string[] args)
    {
        Penjumlahan<float> penjumlahan = new Penjumlahan<float>();
        penjumlahan.jumlahTigaAngka(13, 02, 21);
    }
}

class Penjumlahan<T>
{
    public void jumlahTigaAngka(T a, T b,T c)
    {

        dynamic aa = a;
        dynamic bb = b;
        dynamic cc = c;
        Console.WriteLine(aa+bb+cc);
    }
}