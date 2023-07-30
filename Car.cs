using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ClassInterfaces
{
    public class Car : IVehicle
    {

        public void Drive(int gasoline)
        {
            Console.WriteLine("Qual o montante de combustível do carro?");
            gasoline = Convert.ToInt32(Console.ReadLine());


            if (gasoline == 0)
            {
                Console.WriteLine("O carro está parado, não tem combustível.");
            }
            if (gasoline > 0)
            {
                Console.WriteLine("O carro está em andamento, tem combustível. DRIVING");
            }


            Console.WriteLine("Deseja continuar andar de carro?");
            Console.WriteLine("1 - Continuar.");
            Console.WriteLine("0 - Parar.");
            int escolha = Convert.ToInt32(Console.ReadLine());
            if (escolha == 1)
            {
                Repeat(gasoline);
            }

        }
        public bool Refuel(int gasoline)
        {
            if (gasoline == 0)
            {
                return false;
            }
            return true;

        }
        public void Repeat(int gasoline)
        {
            Drive(gasoline);
         
        }

    }

    
}
        
      
