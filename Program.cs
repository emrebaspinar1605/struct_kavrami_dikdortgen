using System;

namespace struct_kavrami_dikdörtgen
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen=new Dikdortgen{
                KisaKenar=3,
                UzunKenar=5
            };
            Console.WriteLine("Class Alan Hesabı: {0}",dikdortgen.AlanHesapla());
            Dikdortgen_struct dikdortgen_Struct;
            dikdortgen_Struct.KisaKenar=4;
            dikdortgen_Struct.UzunKenar=6;
            Console.WriteLine("Class Alan Hesabı: {0}",dikdortgen_Struct.AlanHesapla());
        }
    }
    class Dikdortgen
    {
        public int KisaKenar;
        public int UzunKenar;
        public long AlanHesapla()
        {
            return (this.KisaKenar+this.UzunKenar)/2;
        }
        public Dikdortgen()
        {
            KisaKenar=3;
            UzunKenar=4;
        }
    }
    struct Dikdortgen_struct
    {
         public int KisaKenar;
        public int UzunKenar;
        public long AlanHesapla()
        {
            return (this.KisaKenar+this.UzunKenar)/2;
        }
    }
}