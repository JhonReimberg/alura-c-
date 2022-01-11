using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class TiposDeValor : IAulaItem
    {
        public void Executar()
        {
            int tamanho;
            tamanho = 3;
            Console.WriteLine(tamanho);

            int Peso;
            Peso = 450006;
            Console.WriteLine(Peso);

            int CopiaTamanho = tamanho;
            Console.WriteLine($"tamanho: {tamanho}");

            Console.WriteLine($"CopiaTamanho: {CopiaTamanho}");
            Console.WriteLine($"Peso: {Peso}");
        } 
        
        

    }
}
