using System;

namespace ExerciciosCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var agendaTelefonica = new AgendaTelefonica();

            agendaTelefonica.VizualizarContatos();




            var contato = new Contact()
            {
                Nome = "Everton",
                Telefone = 996381399,
                Endereço = "Rua José alfredo"
            };
            agendaTelefonica.AdicionarContato(contato);

            agendaTelefonica.VizualizarContatos();

            var contato2 = new Contact()
            {
                Nome = "Albertino",
                Telefone = 323387623,
                Endereço = "Rua Juan"
            };
            agendaTelefonica.AdicionarContato(contato2);

            agendaTelefonica.VizualizarContatos();

            agendaTelefonica.FazerChamada();

            agendaTelefonica.RemoverContato("Everton");

            agendaTelefonica.VizualizarContatos();




        }

    }
}
