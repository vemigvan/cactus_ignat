using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab8_2v
{

    public class PhoneDisc
    {
        public int year;
        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public PhoneDisc(int year)
        {
            this.year = year;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Telephone\n \tYear: {year}\n");
        }
        
    }

    public class PhoneButton : PhoneDisc
    {
        public string company;

        public string Company
        {
            get { return company; }
            set { company = value; }
        }

        public PhoneButton(int year, string company_name) : base(year)
        {
            company = company_name;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"\tCompany: {company}\n");
        }
    }

    public class PhoneBW : PhoneButton
    {
        public string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public PhoneBW(int year, string company_name, string type) : base(year, company_name)
        {
            this.type = type;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"\tTelephone type: {type}\n");
        }
    }

    public class PhoneColor : PhoneBW
    {
        public byte gnet;
        public byte Gnet
        {
            get { return gnet; }
            set { gnet = value; }
        }

        public PhoneColor(int year, string company_name, string type, byte network_gen) :base(year, company_name, type)
        {
            gnet = network_gen;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"\tNetwork generation: {gnet}G\n");
        }

    }

    public class PhoneIphone : PhoneColor
    {
        public string model;
        public string Model
        {
            get { return type; }
            set { type = value; }
        }

        public PhoneIphone(int year, string company_name, string type, byte network_gen, string model) :base(year, company_name, type, network_gen)
        {
            this.model = model;

        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"\tTelephone model: {model}\n");
        }
    }

    public class PhoneGoogle : PhoneIphone
    {
        public byte size;
        public string Size
        {
            get { return type; }
            set { type = value; }
        }

        public PhoneGoogle(int year, string company_name, string type, byte network_gen, string model, byte size) : base(year, company_name, type, network_gen, model)
        {
            this.size = size;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"\tDevice size: {size}\n");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            PhoneButton phone = new PhoneButton(1996, "Panasonic");
            PhoneGoogle glass = new PhoneGoogle(2016, "Google", "glasses", 4, "Glass2.0", 2);

            phone.Display();
            glass.Display();
            
            Console.ReadKey();
        }
    }
}
