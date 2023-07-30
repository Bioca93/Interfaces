using ClassInterfaces;
using System;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    static void Main(string[] args)
    {
        int gasoline = 0;
       
        Car car = new Car();
        
        car.Refuel(gasoline);
        car.Drive(gasoline);
        
       
    }
}