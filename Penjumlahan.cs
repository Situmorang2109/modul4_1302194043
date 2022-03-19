using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302194043
{
    internal class Penjumlahan
    {

            PenjumlahanGeneric<string> penjumlahan = new PenjumlahanGeneric<string>();
            String x = "Anita Situmorang";
            penjumlahan.JumlahAngka(x);

        }
    }
    public class PenjumlahanGeneric<T>
    {
        public void JumlahAngka(T x)
        {
            Console.WriteLine("Jumlah Tiga Angka " + x);

            DataGeneric<String> data = new DataGeneric<string>("1302194043");
            data.PrintData();
        }
    }

    public class DataGeneric<T>
    {
        private T data;
        public DataGeneric(T data)
        {
            this.data = data;
        }
        public void PrintData()
        {
            Console.WriteLine("Jumlah Angka yang tersimpan adalah: " + this.data);

        }
    }
}