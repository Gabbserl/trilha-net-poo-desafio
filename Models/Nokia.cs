namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia:Smartphone
    {
        public Nokia(string numero, string imei, string modelo, int memoria) : base (numero, imei, modelo, memoria)
        {
            
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Deseja instalar o app " + nomeApp + "no Nokia?  \n 1 = Sim \n 2 = Não");
            int resposta = int.Parse(Console.ReadLine());
            if (resposta == 1){
                Console.WriteLine($"{nomeApp} instalado.");
            }
            else if (resposta == 2){
                Console.WriteLine("${nomeApp} não instalado.");
            }
            else{
                Console.WriteLine("Resposta inválida. Insira um valor válido: ");
                int.Parse(Console.ReadLine());
            }
        }
    }
}