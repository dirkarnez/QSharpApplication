using System;

using Microsoft.Quantum.Simulation.Simulators;

namespace Quantum.QSharpApplication
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var qsim = new QuantumSimulator())
            {
                HelloQ.Run(qsim).Wait();
            }
            Console.ReadLine();
        }
    }
}