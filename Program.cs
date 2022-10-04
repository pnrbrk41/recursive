using System;
namespace recursive
{
    class Program{

        static void Main(string[] args){

            //recursive- özyinelemeli fonksiyon
            int result= 1;
            for(int i=1  ; i < 5; i++){
                result=result* 3;
                Console.WriteLine(result);

                Islemler instance = new();
                Console.WriteLine(instance.Expo(3,4));

                //Extension Metotlar
                string ifade= "Zikriye Ürkmez Cengiz";
                bool sonuc= ifade.CheckSpaces();
                Console.WriteLine(sonuc);

                if(sonuc)
                Console.WriteLine(ifade.RemoveWhiteSpaces());

                Console.WriteLine(ifade.MakeUpperCase());
                Console.WriteLine(ifade.MakeLowerCase());

                int[] dizi={9,3,6,2,1,5,8};
                dizi.SortArray();
                dizi.EkranaYazdir();



            }
        }
    }
        public class Islemler{

            public int Expo(int sayi, int us){

                if(us<2)
                return sayi;
                return Expo(sayi,us-1)* sayi;

            }
        }
}
        public static class Extension{

            public static bool CheckSpaces(this string param){
                return param.Contains(" ");

            }
            public static string RemoveWhiteSpaces(this string param){
                string[] dizi= param.Split(" ");
                return string.Join("*",dizi);

            }
            public static string MakeUpperCase(this string param){
                return param.ToUpper();
            }
            public static string MakeLowerCase(this string param){
                return param.ToLower();
            }

            public static int[] SortArray(this int[] param){
                Array.Sort(param);
                return param;
            }

            public static void EkranaYazdir(this int[] param){
                foreach(int item in param){
                    Console.WriteLine(item);
                }
            }
        }
    
