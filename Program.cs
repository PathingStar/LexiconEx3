namespace LexiconEx3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           VehicleHandler.Meny();
        }
    }
}
/*
F: Vad händer om du försöker lägga till en Car i en lista av Motorcycle?
A: Error

F: Vilken typ bör en lista vara för att rymma alla fordonstyper?
A: Vehicle

F: Kommer du åt metoden Clean() från en lista med typen List<Vehicle>? 
A: Nja, du behöver kolla om Vehicle är ICleanable ock sen kasta den till ICleanable för at komma ot Clean()

F: Vad är fördelarna med att använda ett interface här istället för arv?
A: Du kan ha hur många interface som hälst men bara ett arv 

*/