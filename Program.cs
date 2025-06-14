using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeEmaileSenha_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gerador de Emails e Senhas");

            Console.Write("Digite seu primeiro nome:");
            string nome = Console.ReadLine();

            Console.Write("Digite seu sobre nome:");
            string sobrenome = Console.ReadLine();
       

            //Gera o E-mail

            string email = GerarEmail(nome, sobrenome);

            //Gera a Senha
            string senha = GerarSenha(12); // Aqui vc pode mudar o tamanho (comprimento) da senha.

            Console.WriteLine($"Email: {email}"); // Aqui é onde imprimimos o email gerado no console.
            Console.WriteLine($"Senha: {senha}");  // Aqui é onde imprimimos a senha gerada no console.

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();

        }

        static string GerarEmail(string nome, string sobrenome)
        {
            Random random = new Random ();
            string dominio = "exemplo.com"; // Altere para o domínio desejado   
            int numeroAleatorio = random.Next(1000, 9999); // Gera um número aleatório entre 1000 e 9999
            string email = $"{nome.ToLower()}.{sobrenome.ToLower()}{numeroAleatorio}@{dominio}";
            return email;

        }

        static string GerarSenha(int tamanho)
        {
            const string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_+[]{}|;:,.<>?"; // Aqui estão os caracteres que podem ser usados na senha, você pode adicionar ou remover conforme necessário.
            StringBuilder stringBuilder = new StringBuilder (tamanho);
            Random random = new Random ();

            for (int i = 0; i < tamanho; i++)
            {
                int indiceAleatorio = random.Next(caracteres.Length);

                //GerarSenha(caracteres[indiceAleatorio]);


                stringBuilder.Append(caracteres[indiceAleatorio]); //aqui  onde adicionamos o caracter aleatório à senha, ele vai fazer a senha por aqui.
            }
            return stringBuilder.ToString();
        }
    }
    }

