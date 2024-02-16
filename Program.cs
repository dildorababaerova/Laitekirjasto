using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Laitekirjasto
{
    // Yleinen laiteluokka, yliluokka tietokoneille, tableteille ja puhelimille

    class Device
    {
        // Luodaan kenttä (field) name, esitellään (define) ja annetaan arvo (set initial value)
        string name = "Uusi laite";
        // Luodaan kenttää vastaava ominaisuus (property) Name ja sille asetusmetodi set ja lukumetodi get. Ne voi kirjoittaa joko yhdelle tai useammalle riville
        public string Name { get { return name; } set { name = value; } }

        string purchaseDate = "1.1.1900";
        public string PurchaseDate { get { return purchaseDate; } set { purchaseDate = value; } }

        // Huomaa jälkiliite d (suffix)
        double price = 0.0d;
        public double Price { get { return price; } set { price = value; } }

        int warranty = 12;
        public int Warranty { get { return warranty; } set { warranty = value; } }


        string processorType = "N/A";
        public string ProcessorType { get { return processorType; } set { processorType = value; } }


        int amountRAM = 0;
        public int AmountRAM { get { return amountRAM; } set { amountRAM = value; } }


        int storageCapacity = 0;
        public int StorageCapacity { get { return storageCapacity; } set { storageCapacity = value; } }



        // Konstruktori eli olionmuodostin (constructor) ilman argumentteja
        public Device()
        {

        }

        // Konstruktori nimi-argumentilla
        public Device(string name)
        {
            this.name = name;
        }

        // Konstruktori kaikilla argumenteilla
        public Device(string name, string purchaseDate, double price, int warranty)
        {
            this.name = name;
            this.purchaseDate = purchaseDate;
            this.price = price;
            this.warranty = warranty;
        }


        // Yliluokan metodit

        public void ShowPurchaseInfo()
        {
            Console.WriteLine("Laitteen nimi: " + this.name);
            Console.WriteLine("Ostopäivä: " + this.purchaseDate);
            Console.WriteLine("Hinta: " + this.price);
            Console.WriteLine("Takuu: " + this.warranty + " kk");

        }

        public void ShowBasicTechnicalInfo()

        {
            Console.WriteLine("Koneen nimi: " + Name);
            Console.WriteLine("Processori: " + ProcessorType);
            Console.WriteLine("Keskimuisti " + AmountRAM);
            Console.WriteLine("Levytila: " + StorageCapacity);

        }

    }
    class Computer : Device
    {

        // kentät ja ominaisuudet
       
        //Konstructor
        
        public Computer() : base() { }
        public Computer(string name) : base(name) { }




    }
        class Smartphone : Device
        {

        }

        class Tablet : Device
        {
        string operatingSystem;
        public string OperatingSystem { get {  return operatingSystem; } set {  operatingSystem = value; } }


        bool stylusEnabled = false;
        public bool StylusEnabled { get { return stylusEnabled; } set { stylusEnabled = value; } }

        public Tablet() : base() { }

        public Tablet(string name) : base(name) { }

        public void TabletInfo() 
        {
            Console.WriteLine("Käyttöjärjestelämä:" + OperatingSystem);
            Console.WriteLine("Kynätuki: " + StylusEnabled);
        }



        }

        // Pääohjelman luokka, josta tulee Program.exe
        internal class Program
        {
            static void Main(string[] args)
            {
                // Ohjelman varsinaiset toiminnot tapahtuvat täällä
                // Ohjelma kysyy käyttäjältä tietoja laitteista ja
                // vastaamalla kysymyksiin tiedot tallennetaan muuttujiin.

                // Luodaan uusi laite Device-luokasta

                //Device laite = new Device("Opekone");
                //Console.WriteLine("Laitteen nimi on: " + laite.Name);
                //Console.WriteLine("Ostopäivä oli: " + laite.PurchaseDate);

                // Luodaan uusi tietokone, joka perii laiteluokan (Device)
                // 
                Computer tietokone1 = new Computer();

                tietokone1.Name = "MacBook";
                tietokone1.ProcessorType = "Intel 17";
                tietokone1.AmountRAM = 32;
                tietokone1.StorageCapacity = 31;
                tietokone1.PurchaseDate = "15.2.2024";
                tietokone1.Price = 2000.45d;
                tietokone1.Warranty = 24;
                

                Console.WriteLine("Tietokone 1:n hankintateidot ");
                Console.WriteLine("__________________________________");
                tietokone1.ShowBasicTechnicalInfo();
                tietokone1.ShowPurchaseInfo();

            



                //Console.WriteLine("Uuden tietokoneen nimi " + tietokone1.Name);
                //Console.WriteLine("Uuden tietokoneen processorin typppi " + tietokone1.ProcessorType);
                //Console.WriteLine("Uuden tietokoneen processorin muisti RAM " + tietokone1.AmountRAM + " GB");
                //Console.WriteLine("Uuden tietokoneen  " + tietokone1.StorageCapacity);
                //Console.WriteLine("_________________________________________________________");

                Computer tietokone2 = new Computer();
                tietokone2.Name = "Asus";
                tietokone2.ProcessorType = "Intel 22";
                tietokone2.AmountRAM = 19;
                tietokone2.StorageCapacity = 45;
                




                Console.WriteLine("Tietokone 2:n hankintateidot ");
                Console.WriteLine("____________________________________________________________");
                tietokone2.ShowBasicTechnicalInfo();




            Tablet tabletti1 = new Tablet("iPad");
            tabletti1.PurchaseDate = "1.10.2022";
            tabletti1.OperatingSystem = "IOS";
            tabletti1.StylusEnabled = true;


            Console.WriteLine("Tabletti 1:n hankintateidot ");
            Console.WriteLine("____________________________________________________________");
            tabletti1.ShowBasicTechnicalInfo();
            tabletti1.ShowPurchaseInfo();
            tabletti1.TabletInfo();




            //Console.WriteLine("Toinen tietokoneen nimi on " + tietokone2.Name + " ja processori on" + tietokone2.ProcessorType + " muisti on " + tietokone2.AmountRAM + " GB");

            // Pidetään ikkuna auki, kunnes käyttäjä painaa <enter>
            Console.ReadLine();
            }
        }
    }
