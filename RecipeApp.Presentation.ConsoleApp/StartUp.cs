using RecipeApp.Domain.Models;
using RecipeApp.Infra.Data.Repositories;
using System;

namespace RecipeApp.Presentation.ConsoleApp
{
    public class StartUp
    {
        public StartUp()
        {
        }

        public void Run(string[] args)
        {
            // Todos de um user

            Console.WriteLine("1. Listar User");
            Console.WriteLine("2. Criar User");
            Console.WriteLine("3. Atualizar User");
            Console.WriteLine("4. Remover User");

            // CR

        }
    }

    public class UserConsole
    {
        private readonly IUserRepository userRepository;

        public UserConsole(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public void Start()
        {
            userRepository.Create(new User()
            {
                Name = "Roberto Rocha"
            });
        }
    }
}

