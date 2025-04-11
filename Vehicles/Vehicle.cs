using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconEx3.Vehicles;

abstract class Vehicle
{
    private string brand;
    private string model;
    private int year;
    private double weight;

    public Vehicle(string b,string m, string y, string w)
    {
        
            Brand = b;
            Model = m;
            Year = int.Parse( y);
            Weight = double.Parse( w);
        
    }

    public string Brand { get => brand; 
        set {
            if (value.Length >= 2 && value.Length <= 20)
                brand = value;
            else throw new AggregateException($"Invalid size on String");
        }
    }
    public string Model { get => model; 
        set { 
            model = value; 
        } 
    }
    public int Year { get => year; 
        set {
            if (value >= 1886&& value<= DateTime.Now.Year)
            year = value;
            else throw new AggregateException($"Invalid Year");
        } 
    }
    public double Weight { get => weight; 
        set {
            if (value > 0)
                weight = value;
            else throw new AggregateException("Weight must be positive");
        } 
    }
    public abstract string StartEngine();

    public virtual string AtributesInString()
    {
        return $"Brand: {Brand} Model: {Model} Year: {Year} Weight: {Weight} ";
    }
}
