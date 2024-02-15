using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
    }

    class Computer : Device
    {

        // kentät ja ominaisuudet
        string processorType;

        public string ProcessorType { get { return processorType; } set { processorType = value; } }

        int amountRAM;
        public int AmountRAM { get { return amountRAM; } set { amountRAM = value; } }

        int storageCapacity;
        public int StorageCapacity { get { return storageCapacity; } set { storageCapacity = value; } }

        //Konstructor
        public Computer(string processorType, int amountRAM, int storageCapacity)
        {
            this.processorType = processorType;
            this.amountRAM = amountRAM;
            this.storageCapacity = storageCapacity;
        }
        public Computer() : base()
        {

        }

        public Computer(string name) : base(name)
        {
        }


        public void ShowInfo()

        {
            Console.WriteLine("Koneen nimi: " + Name);
            Console.WriteLine("Processori: " + ProcessorType);
            Console.WriteLine("Keskimuisti " +  AmountRAM);
            Console.WriteLine("Levytila: " + StorageCapacity);

        }
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

                Device laite = new Device("Opekone");
                Console.WriteLine("Laitteen nimi on: " + laite.Name);
                Console.WriteLine("Ostopäivä oli: " + laite.PurchaseDate);

                // Luodaan uusi tietokone, joka perii laiteluokan (Device)
                // 
                Computer tietokone1 = new Computer();
                Console.WriteLine("Uuden tietokoneen nimi on " + tietokone1.Name);

                tietokone1.Name = "MacBook";
                tietokone1.ProcessorType = "Intel 17";
                tietokone1.AmountRAM = 32;
                tietokone1.StorageCapacity = 31;


                DateTime purchedDay = new DateTime(2024, 1, 12);
                DateTime now = DateTime.Now;

                TimeSpan differanceDays = now - purchedDay;

                Console.WriteLine(differanceDays);




                Console.WriteLine("Uuden tietokoneen nimi " + tietokone1.Name);
                Console.WriteLine("Uuden tietokoneen processorin typppi " + tietokone1.ProcessorType);
                Console.WriteLine("Uuden tietokoneen processorin muisti RAM " + tietokone1.AmountRAM + "GB");
                Console.WriteLine("Uuden tietokoneen  " + tietokone1.StorageCapacity);
                Console.WriteLine();

                Computer tietokone2 = new Computer();
                tietokone2.Name = "Asus";
                tietokone2.ProcessorType = "Intel 22";
                tietokone2.AmountRAM = 19;
                tietokone2.StorageCapacity = 45;
                tietokone2.ShowInfo();


                Console.WriteLine();
                Console.WriteLine("Toinen tietokoneen nimi on " + tietokone2.Name + " ja processori on" + tietokone2.ProcessorType + " muisti on " + tietokone2.AmountRAM + "GB");

                // Pidetään ikkuna auki, kunnes käyttäjä painaa <enter>
                Console.ReadLine();
            }
        }
    }
