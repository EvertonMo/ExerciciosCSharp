using System;
using System.Collections.Generic;

namespace ExerciciosCSharp
{
    public class AgendaTelefonica
    {
        public List<Contact> Contatos { get; set; } = new List<Contact>();

        public void FazerChamada()
        {
            if (Contatos.Count == 0)
            {
                Console.WriteLine("Você não tem contato!");
            }
            else
            {

                Console.WriteLine("Fazendo chamada!");
            }
        }

        public void AdicionarContato(Contact novoContato)
        {

            Contatos.Add(novoContato);
        }

        public void VizualizarContatos()
        {
            if (Contatos.Count == 0)
            {
                Console.WriteLine("Você ainda não tem contato salvo");
            }

            else
            {
                foreach (var contato in Contatos)
                {
                    Console.WriteLine(
                        contato.Nome +
                        contato.Telefone +
                        contato.Endereço);
                }
            }


        }
        public void RemoverContato(string nome)
        {
            if (Contatos.Count == 0)
            {
                Console.WriteLine("Você não tem contato!");
            }
            else
            {
                var contatoEncontrado = Contatos.Find(contato => contato.Nome == nome);

                if (contatoEncontrado == null)
                {

                    Console.WriteLine("Contato não encontrado!");
                }
                else
                {
                    Contatos.Remove(contatoEncontrado);

                    Console.WriteLine($"Contato {nome} removido!");
                }
            }
        }
    }
}