using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5RPPOON
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //zadatak 1,2
            Product Shoes = new Product("Balenciagas",1.4, 950);
            Product BottledWater = new Product("Smartwater", 1.1, 1.99);

            Box ChosenItems = new Box("Products");
            ChosenItems.Add(Shoes);
            ChosenItems.Add(BottledWater);

            Console.WriteLine("Total product price:"+ChosenItems.Price);
            Console.WriteLine("Total product weight:"+ChosenItems.Weight);
            Console.WriteLine("Product description:"+ChosenItems.Description());

            ShippingService Delivery = new ShippingService(2.99);
            Console.WriteLine("Shipping price for box:" + Delivery.CalculatePrice(ChosenItems));
            Console.WriteLine("Shipping price for Shoes only:" + Delivery.CalculatePrice(Shoes));
		    Console.WriteLine("Shipping price for Bottled Water only:" + Delivery.CalculatePrice(BottledWater));

            Console.ReadKey();
            */
            
            /*
            //zadatak 5
            LightTheme lightTheme = new LightTheme();
            MyTheme yellowTheme = new MyTheme();
            ReminderNote firstnote = new ReminderNote("Is this working?", lightTheme);
            firstnote.Show();
            ReminderNote secondnote = new ReminderNote("This one is pretty!", yellowTheme);
            secondnote.Show();
            Console.ReadKey();
            */

            /*
            //zadatak 6
            LightTheme lightTheme = new LightTheme();
            MyTheme yellowTheme = new MyTheme();

            GroupNote Flathearthers = new GroupNote("Earth is flat!", "Macht", lightTheme);
            Flathearthers.Add("Labbie");
            Flathearthers.Add("Edith");
            Flathearthers.Add("Trump");
            Flathearthers.Show;

            GroupNote Presidents = new GroupNote("I do solemnly swear that I will faithfully execute the Office of President.", "Obama", yellowTheme);
            Presidents.Add("Putin");
            Presidents.Add("Vucic");
            Presidents.Add("Grabar Kitarovic");
            Presidents.Add("Milanovic");
            Presidents.Show;

            Flathearthers.Remove("Edith");
            Flathearthers.Remove("Donald");
            Flathearthers.Show();

            Presidents.Remove("Grabar Kitarovic");
            Presidents.Add("Trump");
            Presidents.Show();

            Console.ReadKey();
            */

            //zadatak7
            LightTheme lightTheme = new LightTheme();
            MyTheme yellowTheme = new MyTheme();

            GroupNote Doctors = new GroupNote("U casu kada stupam medu clanove lijecnicke profesije, svecano obecajem da cu svoj zivot staviti u sluzbu humanosti", "Hipokrat", lightTheme);
            Doctors.Add("Markotic");
            Doctors.Add("Beros");
            Doctors.Add("Bahtijarevic");

            GroupNote MinistersOfHealth = new GroupNote("Tako mi Bog pomogao", "Hebrang", yellowTheme);
            MinistersOfHealth.Add("Ostojic");
            MinistersOfHealth.Add("Milinovic");
            MinistersOfHealth.Add("Kujundzic");

            MinistersOfHealth.Remove("Kujundzic");
            MinistersOfHealth.Add("Beros");
            
            Notebook firstnotebook = new Notebook();
            notebook.AddNote(MinistersOfHealth);
            notebook.AddNote(Doctors);
            notebook.Display();

            notebook = new Notebook(yellowTheme);
            notebook.AddNote(MinistersOfHealth);
            notebook.AddNote(Doctors);
            notebook.Display(); ;

            Console.ReadKey();


        }
    }
}
