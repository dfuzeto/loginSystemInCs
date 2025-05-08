using System;
using System.Collections.Generic;
using operations;

namespace operations;

class Program
{
    static List<User> users = new List<User>();

    static void Main()
    {
        Console.Write("Digite um número!\n1. Login\n2. Registro\nEscolha: ");
        int choice;

        if (!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.WriteLine("Entrada inválida. Tente novamente.\n");
            Main();
            return;
        }

        switch (choice)
        {
            case 1:
                Console.Write("Digite seu nome de usuário: ");
                string loginUser = Console.ReadLine();

                Console.Write("Digite sua senha: ");
                string loginPass = Console.ReadLine();

                bool loginSuccess = false;
                foreach (var user in users)
                {
                    if (user.Username == loginUser && user.Password == loginPass)
                    {
                        Console.WriteLine("Login concluído!\n");
                        loginSuccess = true;
                        break;
                    }
                }

                if (!loginSuccess)
                {
                    Console.WriteLine("Falha no login!\n");
                }

                Main();
                break;

            case 2:
                Console.Write("Digite um nome de usuário: ");
                string newUser = Console.ReadLine();

                Console.Write("Digite uma senha: ");
                string newPass = Console.ReadLine();

                users.Add(new User(newUser, newPass));
                Console.WriteLine("Usuário registrado com sucesso!\n");

                Main();
                break;

            default:
                Console.WriteLine("Opção inválida.\n");
                Main();
                break;
        }
    }
}
