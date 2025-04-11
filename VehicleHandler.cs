using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LexiconEx3.Vehicles;

namespace LexiconEx3;
enum MenyMod
{
    Main,Select, Mod,Make
}
static class VehicleHandler
{
    
    private const string item1 = "1";
    private const string item2 = "2";
    private const string item3 = "3";
    private const string item4 = "4";
    private const string item0 = "X";

    private const string mBrand = "Brand: ";
    private const string mModel = "Model: ";
    private const string mYear = "Year: ";
    private const string mWeight = "Weight: ";

    public static void Meny()
    {
        List<SystemError> errors = new List<SystemError>() { new EngineFailureError() , new BrakeFailureError(), new TransmissionError() } ;
        MenyMod mod = MenyMod.Main;
        bool run=true;
        bool subMeny;
        int index=0;
        List<Vehicle> vehicles = new List<Vehicle>();
        while (run)
        {
            if (mod == MenyMod.Main) 
                Console.WriteLine($"Writ {item1} to add new vehicle, {item2} to see the list of cars,{item3} to see list of errors {item0} to end");
            else if (mod == MenyMod.Mod) 
                Console.WriteLine($"Writ {item1} to change bran, {item2} to change model, {item3} to change year,{item4} to change Weight,{item0} to go back"); 
            else if (mod == MenyMod.Make) 
                Console.WriteLine($"Writ {item1}  to add new cat, {item2}  to add new truck, {item3}  to add new motorcycle ,{item4} to add new electric scooter ,{item0} to go back");
            else if (mod == MenyMod.Select)
                Console.WriteLine($"Writ {item1} to select a car to modefy, {item0} to go back");
            switch (Console.ReadLine().ToUpper())
            {
                case item1 :

                    if (mod == MenyMod.Main) mod = MenyMod.Make;
                    else if (mod == MenyMod.Select)
                    {
                        mod = MenyMod.Mod;
                        while (true)
                        {
                            try
                            {
                                Console.Write("Car index: ");
                                index = int.Parse(Console.ReadLine());
                                break;
                            }
                            catch (Exception e) { Console.WriteLine(e.ToString()); }
                        }
                    }
                    else if (mod == MenyMod.Mod) ChangeVehicleValue(vehicles[index], mBrand);
                    else if (mod == MenyMod.Make) { NewCar(vehicles); mod = MenyMod.Main; }
                    else WrongInput();
                    break;


                case item2 :


                    if (mod == MenyMod.Main)
                    {
                        
                        PrintVehicles(vehicles);
                        mod = MenyMod.Select;
                    }
                    else if (mod == MenyMod.Mod) ChangeVehicleValue(vehicles[index], mModel);
                    else if (mod == MenyMod.Make) { NewTruck(vehicles); mod = MenyMod.Main; }
                    else WrongInput();

                    break;

                case item3 :

                    if (mod == MenyMod.Main) foreach (var e in errors) Console.WriteLine(e.ErrorMessage());
                    else if (mod == MenyMod.Mod) ChangeVehicleValue(vehicles[index], mYear);
                    else if (mod == MenyMod.Make) { NewMotorcycle(vehicles); mod = MenyMod.Main; }
                    else WrongInput();
                    break;

                case item4 :

                    if (mod == MenyMod.Mod) ChangeVehicleValue(vehicles[index], mWeight);
                    else if (mod == MenyMod.Make) { NewElectricScooter(vehicles); mod = MenyMod.Main; }
                    else WrongInput();
                    break;

                case item0 :

                    if(mod == MenyMod.Main )  run = false;
                    else mod =MenyMod.Main;
                        
                    break;

                default:
                    WrongInput();
                    break;
            }
        }
    }
    static void WrongInput()
    {
        Console.WriteLine("wrong input");
    }
    //static void VehicleModMeny(List<Vehicle> vehicles)
    //{
    //    bool run = true;
    //    while (run)
    //    {

    //    }

    //}
    //static List<String> NewBaseVehicle()
    //{

    //    return new List<string>() { prompt(mBrand), prompt(mModel), prompt(mYear), prompt(mWeight) };

        


    //}
    static void NewCar(List<Vehicle> vehicles)
    {
        while (true)
        {
            try
            {
                vehicles.Add(new Car(prompt(mBrand), prompt(mModel), prompt(mYear), prompt(mWeight),
                    (prompt($"thes it have a roof({item1} for yes,{item2} for no)")== item1)? true : false
                    )) ;
                break ;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    static void NewTruck(List<Vehicle> vehicles)
    {
        while (true)
        {
            try
            {
                vehicles.Add(new Truck(prompt(mBrand), prompt(mModel), prompt(mYear), prompt(mWeight),
                    prompt($"Cargo Capacity: ") 
                    ));
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }static void NewMotorcycle(List<Vehicle> vehicles)
    {
        while (true)
        {
            try
            {
                vehicles.Add(new Motorcycle(prompt(mBrand), prompt(mModel), prompt(mYear), prompt(mWeight),
                   (prompt($"thes it have a Sidecar({item1} for yes,{item2} for no)") == item1) ? true : false
                    ));
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    static void NewElectricScooter(List<Vehicle> vehicles)
    {
        while (true)
        {
            try
            {
                vehicles.Add(new ElectricScooter(prompt(mBrand), prompt(mModel), prompt(mYear), prompt(mWeight),
                    prompt($"Battery Range: ")
                    ));
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    static string prompt(string message) {
        Console.Write(message);
        return Console.ReadLine(); 
    }
    static void ChangeVehicleValue(Vehicle vehicle, string message) {
        while (true)
        {
            try
            {

                Console.Write(message);
                string value = Console.ReadLine();
                if (message == mBrand) vehicle.Brand = value;
                else if (message == mModel) vehicle.Model = value;
                else if (message == mYear) vehicle.Year = int.Parse(value);
                else if(message== mWeight) vehicle.Weight= double.Parse(value);
                break;
            }
            catch (Exception ex) {Console.WriteLine(ex.Message); }
        }
    }
    static void PrintVehicles(List<Vehicle> vehicles)
    {
        for (int i = 0; i < vehicles.Count; i++)
        {

            Console.WriteLine(i + ": " + vehicles[i].AtributesInString());
            Console.WriteLine(vehicles[i].StartEngine());
            if (vehicles[i] is ICleanable) (vehicles[i] as ICleanable).Clean();


        }
    }

}
