﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            giris();
            int tus;
            do
            {
                ana_menu();
                int a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Console.WriteLine("Çekmek istediğiniz miktarı giriniz");
                        int para_cekme = Convert.ToInt32(Console.ReadLine());
                        para_cekim(para_cekme);
                        break;
                    case 2:
                        Console.WriteLine("Kredi kartına yatırmak için 1");
                        Console.WriteLine("Hesaba yatırmak için 2");
                        Console.WriteLine("Ana menü için 9");
                        Console.WriteLine("Çıkış yapmak için herhangi bir tuşa basın");
                        int para_yatirma = Convert.ToInt32(Console.ReadLine());
                        if (para_yatirma == 1)
                        {
                            kredi_karti();
                        }
                        if (para_yatirma == 2)
                        {
                            Console.WriteLine("Hesaba yatırmak istediğiniz tutarı giriniz");
                            int hesaba_yatirma = Convert.ToInt32(Console.ReadLine());
                            if (hesaba_yatirma > 0)
                            {
                                int bakiye;
                                bakiye = para + hesaba_yatirma;
                                Console.WriteLine("Para hesabınıza yatırılmıştır");
                                Console.WriteLine("Hesap bakiyeniz:{0}", bakiye);

                                para = bakiye;
                                //ana_menu_cikis();
                            }
                            else
                            {
                                Console.WriteLine("Hatalı giriş yaptınız");
                                //ana_menu_cikis();
                            }

                        }
                        if (para_yatirma == 9)
                        {
                            ana_menu();
                        }
                        else
                        {
                            Environment.Exit(0);
                        }


                        break;
                    case 3:
                        Console.WriteLine("Başka hesaba EFT için 1");
                        Console.WriteLine("Başka hesaba havale için 2");
                        int para_gonderme = Convert.ToInt32(Console.ReadLine());
                        if (para_gonderme == 1)
                        {
                            Console.WriteLine("EFT yapacağınız IBAN numarasını giriniz");
                            Console.Write("TR-");
                            long eft;
                            eft = Convert.ToInt64(Console.ReadLine());
                            if (eft >= 100000000000 && eft <= 999999999999)
                            {
                                Console.WriteLine("EFT yapmak istediğiniz tutarı giriniz");
                                int eft_tutar = Convert.ToInt32(Console.ReadLine());
                                if (eft_tutar > 0 && eft_tutar > para)
                                {
                                    Console.WriteLine("Bakiye yetersiz");
                                    //ana_menu_cikis();
                                }
                                else if (eft_tutar > 0 && eft_tutar <= para)
                                {
                                    int bakiye;
                                    bakiye = para - eft_tutar;

                                    para = bakiye;
                                    Console.WriteLine("Girdiğiniz tutar hesaba gönderlmiştir.");
                                    Console.WriteLine("Hesap bakiyeniz:{0}", bakiye);
                                    //ana_menu_cikis();
                                }

                            }

                        }
                        if (para_gonderme == 2)
                        {
                            Console.WriteLine("Havale yapacağınız hesap numarasını giriniz");
                            long havale;
                            havale = Convert.ToInt64(Console.ReadLine());
                            if (havale >= 10000000000 && havale <= 99999999999)
                            {
                                Console.WriteLine("Havale yapmak istediğiniz tutarı giriniz");
                                int havale_tutar = Convert.ToInt32(Console.ReadLine());
                                if (havale_tutar > 0 && havale_tutar > para)
                                {
                                    Console.WriteLine("Bakiye yetersiz");
                                    //ana_menu_cikis();
                                }
                                else if (havale_tutar > 0 && havale_tutar <= para)
                                {
                                    int bakiye;
                                    bakiye = para - havale_tutar;

                                    para = bakiye;
                                    Console.WriteLine("Girdiğiniz tutar hesaba gönderlmiştir.");
                                    Console.WriteLine("Hesap bakiyeniz:{0}", bakiye);
                                    //ana_menu_cikis();
                                }

                            }

                        }
                        //ana_menu_cikis();

                        break;
                    case 4:
                        Console.WriteLine("Eğitim ödemeleri sayfası arızalı");
                        //ana_menu_cikis();
                        break;
                    case 5:
                        Console.WriteLine("Elektrik Faturası       1");
                        Console.WriteLine("Telefon Faturası        2");
                        Console.WriteLine("İnternet faturası       3");
                        Console.WriteLine("Su Faturası             4");
                        Console.WriteLine("OGS Ödemeleri           5");
                        int fatura = Convert.ToInt32(Console.ReadLine());
                        if (fatura > 0 && fatura <= 6)
                        {
                            switch (fatura)
                            {
                                case 1:
                                    Console.WriteLine("Fatura tutarını giriniz");
                                    int fatura1 = Convert.ToInt32(Console.ReadLine());
                                    if (fatura1 > 0 && fatura1 <= para)
                                    {
                                        int bakiye;
                                        bakiye = para - fatura1;
                                        para = bakiye;
                                        Console.WriteLine("Faturanız ödenmiştir.");
                                        Console.WriteLine("Kalan bakiyeniz:" + bakiye);
                                        //ana_menu_cikis();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Bakiye yetersiz");
                                        //ana_menu_cikis();
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("Fatura tutarını giriniz");
                                    int fatura2 = Convert.ToInt32(Console.ReadLine());
                                    if (fatura2 > 0 && fatura2 <= para)
                                    {
                                        int bakiye;
                                        bakiye = para - fatura2;
                                        para = bakiye;
                                        Console.WriteLine("Faturanız ödenmiştir.");
                                        Console.WriteLine("Kalan bakiyeniz:" + (para - fatura2));
                                        //ana_menu_cikis();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Bakiye yetersiz");
                                        //ana_menu_cikis();
                                    }
                                    break;

                                case 3:
                                    Console.WriteLine("Fatura tutarını giriniz");
                                    int fatura3 = Convert.ToInt32(Console.ReadLine());
                                    if (fatura3 > 0 && fatura3 <= para)
                                    {
                                        int bakiye;
                                        bakiye = para - fatura3;
                                        para = bakiye;
                                        Console.WriteLine("Faturanız ödenmiştir.");
                                        Console.WriteLine("Kalan bakiyeniz:" + (para - fatura3));
                                        //ana_menu_cikis();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Bakiye yetersiz");
                                        //ana_menu_cikis();
                                    }
                                    break;

                                case 4:
                                    Console.WriteLine("Fatura tutarını giriniz");
                                    int fatura4 = Convert.ToInt32(Console.ReadLine());
                                    if (fatura4 > 0 && fatura4 <= para)
                                    {
                                        int bakiye;
                                        bakiye = para - fatura4;
                                        para = bakiye;
                                        Console.WriteLine("Faturanız ödenmiştir.");
                                        Console.WriteLine("Kalan bakiyeniz:" + (para - fatura4));
                                        //ana_menu_cikis();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Bakiye yetersiz");
                                        //ana_menu_cikis();
                                    }
                                    break;


                                case 5:
                                    Console.WriteLine("Fatura tutarını giriniz");
                                    int fatura5 = Convert.ToInt32(Console.ReadLine());
                                    if (fatura5 > 0 && fatura5 <= para)
                                    {
                                        int bakiye;
                                        bakiye = para - fatura5;
                                        para = bakiye;
                                        Console.WriteLine("Faturanız ödenmiştir.");
                                        Console.WriteLine("Kalan bakiyeniz:" + (para - fatura5));
                                        //ana_menu_cikis();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Bakiye yetersiz");
                                        //ana_menu_cikis();
                                    }
                                    break;
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Hatalı giriş yaptınız.");
                            //ana_menu_cikis();
                        }
                        break;
                    case 6:
                        Console.WriteLine("Şifre değiştirmek için 1");
                        int degisim = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Yeni şifrenizi girin");
                        string yeni_sifre = Console.ReadLine();
                        pin = yeni_sifre;
                        //ana_menu_cikis();
                        break;

                }

                Console.WriteLine("Ana menü için 9'a basınız");
                Console.WriteLine("Çıkmak için herhangi bir tuşa basınız");
                tus = Convert.ToInt32(Console.ReadLine());
                //ana_menu_cikis(tus);
            } while (tus == 9);

        }
        static int para = 250;
        static string pin = "ab18";
        #region Giriş

        static void giris()
        {


            while (true)
            {
                Console.WriteLine("Kartlı Giriş için 1'e basınız");
                Console.WriteLine("Kartsız Giriş için 2'e basınız");

                try
                {
                    int giris = Convert.ToInt32(Console.ReadLine());
                    if (giris == 1)
                    {

                        int hak = 3;
                        string girilen;
                        while (hak > 0)
                        {
                            Console.Write("Şifre giriniz>>>");
                            girilen = Console.ReadLine();
                            if (girilen == pin)
                            {

                                break;
                            }
                            else hak--;
                        }
                        if (hak == 0) Console.Write("Kart bloke edildi");
                        {
                            Console.ReadKey();
                        }
                    }
                    if (giris == 2)
                    {
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Yanlış tuşlama");
                }
                break;
            }
        }

        #endregion


        #region Ana Menü ve Çıkış
        static void ana_menu_cikis(int tus)
        {
            Console.WriteLine("Ana menü için 9'a basınız");
            Console.WriteLine("Çıkmak için herhangi bir tuşa basınız");
            tus = Convert.ToInt32(Console.ReadLine());
            try
            {
                tus = Convert.ToInt32(Console.ReadLine());
                if (tus == 9)
                {
                    ana_menu();

                }
                else
                {
                    Environment.Exit(0);
                }
            }
            catch (Exception)
            {

                Environment.Exit(0);
            }
        }

        #endregion

        #region Ana Menü
        static void ana_menu()
        {
            Console.WriteLine("Para Çekmek için    1");
            Console.WriteLine("Para yatırmak için  2");
            Console.WriteLine("Para Transferleri   3");
            Console.WriteLine("Eğitim Ödemeleri    4");
            Console.WriteLine("Ödemeler            5");
            Console.WriteLine("Bilgi Güncelleme    6");
        }
        #endregion

        static void para_cekim(int miktar)
        {
            int a = 0;
            do
            {

                try
                {
                    if (miktar > para)
                    {
                        Console.WriteLine("Yetersiz bakiye");
                        //ana_menu_cikis();
                    }
                    else if (para >= miktar)
                    {
                        int bakiye;
                        bakiye = para - miktar;
                        para = bakiye;
                        Console.WriteLine("Kalan bakiye: {0}", bakiye);

                        //ana_menu_cikis();
                    }
                }
                catch (Exception)
                {
                    a++;
                    Console.WriteLine("Yanlış tuşlama.Tekrar giriniz.");

                }
            } while (a > 0);


        }
        static void kredi_karti()
        {
            Console.WriteLine("Kredi kartı numaranızı giriniz");
            long kart_no = Convert.ToInt64(Console.ReadLine());
            if (kart_no >= 100000000000 && kart_no <= 999999999999)
            {
                Console.WriteLine("Kredi kartına yatırmak istediğiniz tutarı giriniz");
                int k_tutar = Convert.ToInt32(Console.ReadLine());
                if (k_tutar > 0 && k_tutar > para)
                {
                    Console.WriteLine("Bakiye yetersiz");
                    //ana_menu_cikis();
                }
                else if (k_tutar > 0 && k_tutar <= para)
                {
                    int bakiye;
                    bakiye = para - k_tutar;
                    para = bakiye;
                    Console.WriteLine("Girdiğiniz tutar kredi kartına yatırılmıştır.");
                    Console.WriteLine("Hesap bakiyeniz:{0}", bakiye);
                    //ana_menu_cikis();
                }
            }
        }
    }
}