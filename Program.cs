using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppkarneortalamasi
{
    class Program
    {
        static void Main(string[] args)
        {


            #region değişkenler

            int mat1,mat2,matSozlu1,matSozlu2,matSozlu3;          

            int fen1,fen2,fenSozlu1, fenSozlu2 ,fenSozlu3;

            int turk1,turk2,turkSozlu1,turkSozlu2,turkSozlu3;

            int ing1,ing2,ingSozlu1,ingSozlu2,ingSozlu3;

            int seçmeli11,seçmeli12,seçmeli1Sozlu1,seçmeli1Sozlu2;

            int seçmeli21,seçmeli22,seçmeli2Sozlu1,seçmeli2Sozlu2;

            int seçmeli31,seçmeli32,seçmeli3Sozlu1,seçmeli3Sozlu2;
                      
            int muzik1,muzik2,muzikSozlu1,muzikSozlu2;

            int beden1,beden2,bedenSozlu1,bedenSozlu2;

            int din1,din2,dinSozlu1,dinSozlu2;

            int gorsel1,gorselSozlu1,gorselSozlu2;

            int tekTas1,tekTas2,tekTasSozlu1,tekTasSozlu2;

            int sos1,sos2,sosSozlu1,sosSozlu2;

            double matOrt, fenOrt, turkOrt, ingOrt, seçmeli1Ort, seçmeli2Ort, seçmeli3Ort, sosOrt,  muzikOrt, bedenOrt, dinOrt, gorselOrt, tekTasOrt;

            double matSozluOrt, fenSozluOrt, turkSozluOrt, ingSozluOrt, seçmeli1SozluOrt, seçmeli2SozluOrt, seçmeli3SozluOrt, sosSozluOrt, muzikSozluOrt, bedenSozluOrt, dinSozluOrt, gorselSozluOrt, tekTasSozluOrt;

            double karneOrt;

            double matDers, fenDers, sosDers, ingDers, turkDers, dinDers, tekTasDers, gorselDers, muzikDers, bedenDers, seçmeli1Ders, seçmeli2Ders, seçmeli3Ders;
       

            #endregion  değişkenler

            Console.WriteLine("   LÜTFEN NOTLARINIZI 100 ÜZERİNDEN DEĞERLENDİREREK YAZINIZ !   " );

            #region Matematik Dersi

            Console.Write("matematik 1. yazılı notunu gir: ");
             mat1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("matematik 2. yazılı notunu gir: ");
            mat2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("matematik 1. sözlü notunu gir: ");
            matSozlu1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("matematik 2. sözlü notunu gir: ");
            matSozlu2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("matematik 3. sözlü notunu gir: ");
            matSozlu3 = Convert.ToInt32(Console.ReadLine());

            matSozluOrt = (matSozlu1 + matSozlu2 + matSozlu3 ) / 3;
            matOrt =( mat1 + mat2 + matSozluOrt ) / 3;
            
            Console.WriteLine("matematik dersi ortalaman  :  " +  matOrt);

            #endregion

            #region fen dersi
            Console.Write("fen bilimleri 1. yazılı notunu gir: ");
            fen1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("fen bilimleri 2.yazılı notunu gir: ");
            fen2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("fen bilimleri 1. sözlü notunu gir: ");
            fenSozlu1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("fen bilimleri 2. sözlü notunu gir: ");
            fenSozlu2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("fen bilimleri 3.  sözlü notunu gir: ");
            fenSozlu3 = Convert.ToInt32(Console.ReadLine());

            fenSozluOrt = (fenSozlu1 + fenSozlu2 + fenSozlu3) / 3;
            fenOrt = (fen1 + fen2 + fenSozluOrt) / 3;

            Console.WriteLine("fen bilimleri dersi ortalaman : " + fenOrt);

            #endregion

            #region turkce
            Console.Write("türkçe 1. yazılı notunu gir: ");
            turk1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("türkçe 2. yazılı notunu gir: ");
            turk2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("türkçe 1. sözlü notunu gir: ");
            turkSozlu1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("türkçe 2. sözlü notunu gir: ");
            turkSozlu2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("türkçe 3. sözlü notunu gir: ");
            turkSozlu3 = Convert.ToInt32(Console.ReadLine());

            turkSozluOrt = (turkSozlu1 + turkSozlu2 + turkSozlu3) / 3;
            turkOrt = (turk1 + turk2 + turkSozluOrt) / 3;

            Console.WriteLine("türkçe dersi ortalaman : " + turkOrt);

            #endregion

            #region ingilizce
            Console.Write("ingilizce 1. yazılı notunu gir: ");
            ing1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("ingilizce 2. yazılı notunu gir: ");
            ing2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("ingilizce 1. sözlü notunu gir: ");
            ingSozlu1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("ingilizce 2. sözlü notunu gir: ");
            ingSozlu2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("ingilizce 3. sözlü notunu gir: ");
            ingSozlu3 = Convert.ToInt32(Console.ReadLine());

            ingSozluOrt = (ingSozlu1 + ingSozlu2 + ingSozlu3 ) / 3;
            ingOrt = (ing1 + ing2 + ingSozluOrt) / 3;

            Console.WriteLine("ingilizce dersi ortalaman : " + ingOrt);
            #endregion


            Console.WriteLine("   AYNI SEÇMELİYİ BİR DAHA YAZMAYINIZ !   ");
            #region seçmeli 1
            Console.Write("seçmeli 1. yazılı notunu gir: ");
            seçmeli11 = Convert.ToInt32(Console.ReadLine());

            Console.Write("seçmeli 2. yazılı notunu gir: ");
            seçmeli12 = Convert.ToInt32(Console.ReadLine());

            Console.Write("seçmeli 1. sözlü notunu gir: ");
            seçmeli1Sozlu1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("seçmeli 2. sözlü notunu gir: ");
            seçmeli1Sozlu2 = Convert.ToInt32(Console.ReadLine());

            seçmeli1SozluOrt = (seçmeli1Sozlu1 + seçmeli1Sozlu2) / 2;
            seçmeli1Ort = (seçmeli11 + seçmeli12 + seçmeli1SozluOrt) / 3;

            Console.WriteLine(" 1.seçmeli dersi ortalaman : " + seçmeli1Ort);
            #endregion

            #region seçmeli 2
            Console.Write("seçmeli 1. yazılı notunu gir: ");
            seçmeli21 = Convert.ToInt32(Console.ReadLine());

            Console.Write("seçmeli 2. yazılı notunu gir: ");
            seçmeli22 = Convert.ToInt32(Console.ReadLine());

            Console.Write("seçmeli 1. sözlü notunu gir: ");
            seçmeli2Sozlu1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("seçmeli 2. sözlü notunu gir: ");
            seçmeli2Sozlu2 = Convert.ToInt32(Console.ReadLine());

            seçmeli2SozluOrt = (seçmeli2Sozlu1 + seçmeli2Sozlu2) / 2;
            seçmeli2Ort = (seçmeli21 + seçmeli22 + seçmeli2SozluOrt) / 3;

            Console.WriteLine(" 2.seçmeli dersi ortalaman : " + seçmeli2Ort);

            #endregion

            #region seçmeli 3
            Console.Write("seçmeli 1. yazılı notunu gir: ");
            seçmeli31 = Convert.ToInt32(Console.ReadLine());

            Console.Write("seçmeli 2. yazılı notunu gir: ");
            seçmeli32 = Convert.ToInt32(Console.ReadLine());

            Console.Write("seçmeli 1. sözlü notunu gir: ");
            seçmeli3Sozlu1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("seçmeli 2. sözlü notunu gir: ");
            seçmeli3Sozlu2 = Convert.ToInt32(Console.ReadLine());

            seçmeli3SozluOrt = (seçmeli3Sozlu1 + seçmeli3Sozlu2) / 2;
            seçmeli3Ort = (seçmeli31 + seçmeli32 + seçmeli3SozluOrt) / 3;

            Console.WriteLine(" 3.seçmeli dersi ortalaman : " + seçmeli3Ort);
            #endregion seçmeli

            #region muzik

            Console.Write("muzik 1. yazılı notunu gir: ");
            muzik1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("muzik 2. yazılı notunu gir: ");
            muzik2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("muzik 1. sözlü notunu gir: ");
            muzikSozlu1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("muzik2. sözlü notunu gir: ");
            muzikSozlu2 = Convert.ToInt32(Console.ReadLine());
 
            muzikSozluOrt = (muzikSozlu1 + muzikSozlu2 ) / 2 ;
            muzikOrt = (muzik1 + muzik2 + muzikSozluOrt) / 3;

            Console.WriteLine("muzik dersi ortalaman : " + muzikOrt);

            #endregion

            #region beden

            Console.Write("beden 1. yazılı notunu gir: ");
            beden1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("beden 2. yazılı notunu gir: ");
            beden2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("beden 1. sözlü notunu gir: ");
            bedenSozlu1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("beden 2. sözlü notunu gir: ");
            bedenSozlu2 = Convert.ToInt32(Console.ReadLine());

            bedenSozluOrt = (bedenSozlu1 + bedenSozlu2) / 2;
            bedenOrt = (beden1 + beden2 + bedenSozluOrt) / 3;

            Console.WriteLine("beden dersi ortalaman : " + bedenOrt);

            #endregion

            #region din
            Console.Write("din 1. yazılı notunu gir: ");
            din1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("din 2. yazılı notunu gir: ");
            din2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("din 1. sözlü notunu gir: ");
            dinSozlu1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("din 2. sözlü notunu gir: ");
            dinSozlu2 = Convert.ToInt32(Console.ReadLine());

            dinSozluOrt = (dinSozlu1 + dinSozlu2) / 2;
            dinOrt = (din1 + din2 + dinSozluOrt) / 3;

            Console.WriteLine("beden dersi ortalaman : " + dinOrt);

            #endregion

            #region gorsel
            Console.Write("gorsel 1. yazılı notunu gir: ");
            gorsel1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("gorsel 1. sözlü notunu gir: ");
            gorselSozlu1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("gorsel 2. sözlü notunu gir: ");
            gorselSozlu2 = Convert.ToInt32(Console.ReadLine());

            gorselSozluOrt = (gorselSozlu1 + gorselSozlu2) / 2;
            gorselOrt = (gorsel1 + gorselSozlu2 + gorselSozluOrt) / 3;

            Console.WriteLine("gorsel dersi ortalaman : " + gorselOrt);
            #endregion


            #region tektas
            Console.Write("teknoloji tasarım  1. yazılı notunu gir: ");
            tekTas1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("teknoloji tasarım  2. yazılı notunu gir: ");
            tekTas2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("teknoloji tasarım  1. sözlü notunu gir: ");
            tekTasSozlu1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("teknoloji tasarım  2. sözlü notunu gir: ");
            tekTasSozlu2 = Convert.ToInt32(Console.ReadLine());

            tekTasSozluOrt = (tekTasSozlu1 + tekTasSozlu2) / 2;
            tekTasOrt = (tekTas1 + tekTas2 + tekTasSozluOrt) / 3;

            Console.WriteLine("teknoloji tasarım dersi ortalaman : " + tekTasOrt);
            #endregion

            Console.WriteLine("   SOSYAL VE İNKILAP AYNI DERSTİR !   ");

            #region sosyal
            Console.Write("sosyal 1. yazılı notunu gir: ");
            sos1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("sosyal 2. yazılı notunu gir: ");
            sos2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("sosyal 1. sözlü notunu gir: ");
            sosSozlu1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("sosyal 2. sözlü notunu gir: ");
            sosSozlu2 = Convert.ToInt32(Console.ReadLine());

            sosSozluOrt = (sosSozlu1 + sosSozlu2) / 2;
            sosOrt = (sos1 + sos2 + sosSozluOrt) / 3;

            Console.WriteLine("sosyal dersi ortalaman : " + sosOrt);

            #endregion

            #region ortalama
            matDers = matOrt * 5 ;
            fenDers = fenOrt * 4;
            sosDers = sosOrt * 2;
            ingDers = ingOrt * 4;
            tekTasDers = tekTasOrt * 2;
            muzikDers = muzikOrt * 1;
            dinDers = dinOrt * 2;
            turkDers = turkOrt * 5;
            seçmeli1Ders = seçmeli1Ort * 2;
            seçmeli2Ders = seçmeli2Ort * 2;
            seçmeli3Ders = seçmeli3Ort * 2;
            bedenDers = bedenOrt * 2;
            gorselDers = gorselOrt * 1;


            karneOrt = (gorselDers + bedenDers + seçmeli1Ders + seçmeli2Ders + seçmeli3Ders + turkDers + dinDers + muzikDers + tekTasDers + ingDers + matDers + fenDers + sosDers) / 34;

            Console.WriteLine("karne notun : " + karneOrt);

            #endregion

            Console.ReadLine();












        }
    }
}
