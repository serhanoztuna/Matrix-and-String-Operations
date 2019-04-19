/******************************************************************************
 **                       SAKARYA ÜNİVERSİTESİ    
 **                  BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ        
 **                     BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ        
 **                    NESNEYE DAYALI PROGRAMLAMA DERSİ     
 **                          2014-2015 BAHAR DÖNEMİ 
 **                             
 **                  ÖDEV NUMARASI..........: 1    
 **                  
 **                                     
 **                  
 *****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ndp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 0;
            while(y==0)//genel bir while döngüsü tanımlanıyor kullanıcı çıkış yapmak isteyene kadar y değeri sabit kalıyor ve döngüden çıkmıyor
            { 
            int secim;
            Console.WriteLine("..::İşlemler::..");//ana menü
            Console.WriteLine("1-Matris İşlemleri");
            Console.WriteLine("2-String İşlemleri");
            Console.WriteLine("3-Çıkış");
            Console.Write("Seçiminiz:");//ana menüden seçim yaptırılıyor
            secim = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (secim)//yapılan secime göre switch case yapısına giriyor
                {
                    case 1:
                        int msatir, girdi;
                        Console.Clear();
                        Console.WriteLine("..:: Matris İşlemleri ::..");
                        Console.Write("Matrisin satır sayısını giriniz(1-10 arasında):");
                        msatir = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        if (msatir > 0 && msatir < 11)//girilen matris sınırının 1-10 arasında olup olmadıgı kontrol ediliyor,değilse ana menüye dönüyor
                        {
                            int[,] matris = new int[(msatir + 1), (msatir + 1)];//matrisler tanımlanıyor
                            int[] enbuyuk = new int[(msatir + 1)];
                            int[] stoplam = new int[(msatir + 1)];
                            for (int i = 1; i <= msatir; i++)
                            {
                                for (int j = 1; j <= msatir; j++)//sırayla matris değerleri kullanıcıdan alınıyor
                                {
                                    Console.Write("[{0},{1}]=", i, j);
                                    girdi = Convert.ToInt32(Console.ReadLine());
                                    matris[i, j] = girdi;

                                }
                            }
                            for (int i = 1; i <= msatir; i++)//satırdaki en büyük batris değerleri bulunuyor
                            {
                                int toplam = 0, mak = 0;
                                for (int j = 1; j <= msatir; j++)
                                {
                                    Console.Write(matris[i, j]);
                                    Console.Write(" ");
                                    toplam = toplam + matris[i, j];
                                    if (mak < matris[i, j])
                                    {
                                        mak = matris[i, j];
                                    }

                                }
                                enbuyuk[i] = mak;
                                stoplam[i] = toplam;
                                toplam = 0;
                                mak = 0;
                                Console.WriteLine();
                            }



                            int secim2;
                            Console.WriteLine("1-Satir En Büyük");
                            Console.WriteLine("2-Satir Toplam");
                            Console.Write("Seçiminiz:");
                            secim2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            if (secim2 == 1)//seçime göre satir toplamı yada satirdaki büyük değerler yazdırılıyor.
                            {
                                for (int i = 1; i <= msatir; i++)
                                {
                                    Console.Write(enbuyuk[i]);
                                    Console.Write(" ");
                                }
                                Console.WriteLine("Devam etmek için tıklayınız");
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            }


                            if (secim2 == 2)
                            {
                                for (int i = 1; i <= msatir; i++)
                                {
                                    Console.Write(stoplam[i]);
                                    Console.Write(" ");
                                }
                                Console.WriteLine();
                                Console.WriteLine("Devam etmek için tıklayınız");
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            }
                            Console.WriteLine();
                            if (secim2 != 1 || secim2 != 2)// 1 veya 2 seçeneği seçilmezse hatalı seçim yazdırılıyor ve menüye dönüyor
                            {
                                Console.WriteLine("Hatalı Seçim");
                                Console.WriteLine("Devam etmek için tıklayınız");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("lütfen 1-10 arası sayı giriniz");// matris değerlerini kurala uygun girmezse hata veriyor.
                            Console.WriteLine("Devam etmek için tıklayınız");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                        break;
                    case 2:
                        string kelime;
                        char harf;

                        Console.Clear();
                        Console.WriteLine("..:: String İşlemleri ::..");// string değer isteniyor
                        Console.Write("İşlem Yapılacak Stringi giriniz:");
                        kelime = Console.ReadLine();
                        Console.Write("İstenen harf:");
                        harf = char.Parse(Console.ReadLine());
                        Console.WriteLine();
                        
                        int sayac = 0;
                        foreach (char i in kelime)//istenen harf string değerde 2 kez varsa işlem yapılıyor yoksa hata veriyor.
                        {
                            if (i == harf)
                            {
                                sayac++;
                            }

                        }
                        if (sayac ==  2)//eğer 2 harf string değerde bulunduysa aşağıdaki işlemler yapılıyor.
                        {
                            int islemsecim;
                            Console.WriteLine("1-Ara Metni Tersten Yaz");
                            Console.WriteLine("2-Ara Metni Tekrarlı Yaz");
                            Console.Write("Seçiminiz:");
                            islemsecim = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            if (islemsecim == 1)
                            {
                                int index1, index2;
                                index1 = kelime.IndexOf(harf);
                                index2 = kelime.LastIndexOf(harf);
                                for (int i = (index1 + 1); i <= index2 - 1; i++)//tersten yazma işlemi
                                {
                                    Console.Write(kelime[kelime.Length - i - 1]);
                                }
                                Console.WriteLine();
                                Console.WriteLine("Devam etmek için tıklayınız");
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            }
                            if (islemsecim == 2)
                            {
                                int index1, index2;
                                index1 = kelime.IndexOf(harf);
                                index2 = kelime.LastIndexOf(harf);
                                for (int k = 0; k < 5; k++)//string değer 5 kez yazdırılıyor
                                {
                                    for (int i = (index1 + 1); i < index2; i++)
                                    {
                                        Console.Write(kelime[i]);
                                    }
                                    Console.WriteLine();
                                }
                                Console.WriteLine();
                                Console.WriteLine("Devam etmek için tıklayınız");
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine("Aranan harf cümle içerisinde bulunamamıştır.");// eğer koşulları sağlamıyorsa hata veriyor.
                            Console.WriteLine("Devam etmek için tıklayınız.");
                            Console.ReadKey();
                            Console.Clear();
                            break;


                        }
                        break;
                    case 3:
                        Console.WriteLine("Çıkış yapmak");// çıkış yapmak istediğinde buraya yönlendiriyor ve herhangi bir tuşa basarsa ana menüye dönüyor.
                        Console.WriteLine("Devam etmek için tıklayınız");
                        Console.ReadKey();
                        y = 1;
                        break;
                    default :
                        Console.WriteLine("Hatalı Seçim");//eğer istenilen değerler girilmediyse ekrana hata mesajı yazip ana menüye dönüyor.
                        Console.WriteLine("Devam etmek için tıklayınız");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                }
            }
        }
        }
    }

