namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
   public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo) : base(numero, "Nokia", modelo)
        {
            // TODO: Implementar a lógica específica do construtor, se necessário
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} na plataforma Nokia...");
        }
    }
}