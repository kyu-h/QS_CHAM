using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace test_kyu
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var qsim = new QuantumSimulator())
            {
                // Try initial values
                Result[] initials = new Result[] { Result.Zero, Result.One };
                var res = CHAM_64x128.Run(qsim, 1000, Result.Zero).Result;
                
                var (ct00, ct01, ct02, ct03) = res;
                string strHex00 = Convert.ToString(ct00, 16);
                string strHex01 = Convert.ToString(ct01, 16);
                string strHex02 = Convert.ToString(ct02, 16);
                string strHex03 = Convert.ToString(ct03, 16);
                System.Console.WriteLine(
                    $"ct00={strHex00,-4} ct01={strHex01,-4} ct02={strHex02,-4} ct03={strHex03,-4}");
            }

            System.Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}