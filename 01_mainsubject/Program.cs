using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_mainsubject
{
    internal class Program
    {
        static void Main(string[] args)
        {  
           // Console.WriteLine("hellooo zubo");
            
            #region Değişkenler
            string costumeremail, district, city;
            string costumername;
            string costumersurname;
            string costumerphone;

            costumeremail = "zubeydeozudogru1907@gmail.com";
            costumersurname = "özüdoğru";
            costumerphone = "05510322931";
            costumername = "zübeyde";
            district = "eryaman";
            city = "ankara";

            Console.WriteLine("---REZERVASYON KARTI---");
            Console.WriteLine();
            Console.WriteLine("İsim:"+costumername); ;
            Console.WriteLine("Soyisim:"+costumersurname);
            Console.WriteLine("Telefon:"+costumerphone);
            Console.WriteLine("E-mail:"+costumeremail);
            Console.WriteLine("Şehir:"+city);
            Console.WriteLine("İlçe:"+district);



            #endregion;
            Console.Read();

        }
    }
}
