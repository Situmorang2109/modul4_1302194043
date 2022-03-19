using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302194043
{
    class Program
    {
        static void Main(string[] args)
        {
            KodeFilm table_KodeFilm = new KodeFilm();
            Console.WriteLine("=== GET KODE FILM ===");
            table_KodeFilm.getKodeFilm("AADC");
            Console.WriteLine("==== GET ALL KODE FILM ====");
            table_KodeFilm.getAllkodeFilm();

        }

    }
    class KodeFilm
    {

        Dictionary<string, string> dic = new Dictionary<string, string>() {
            {"AADC", "A10"},
            {"Dear Nathan","D11" },
            {"Kukira Kau Rumah"  ,"K12" },
            {"Sobat Ambyar"    ,"S13" },
            {"June dan Kopi"  ,"J14"},
            {"Affliction" ,"A15" },
            {"Guru-guru Gokil","G16"},
            {"Dua Garis Biru" ,"D17" }, };

        public void getKodeFilm(string kel)
        {

            if (dic.ContainsKey(kel))
            {
                Console.WriteLine(kel + " : " + dic[kel]);
            }
            else
            {
                Console.WriteLine(kel + " tidak ditemukan");
            }
        }

        public void getAllkodeFilm()
        {
            foreach (KeyValuePair<string, string> ele1 in dic)
            {
                Console.WriteLine("{0} \t\t {1}", ele1.Key, ele1.Value);
            }
        }
    }
}
