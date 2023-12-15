using System;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public Smartphone(string numero, string marca, string modelo)
        {
            Numero = numero;
            Marca = marca;
            Modelo = modelo;
        }

        public void Ligar()
        {
            Console.WriteLine($"Ligando {Marca} {Modelo}...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"Recebendo ligação em {Marca} {Modelo}...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}