using System;
using Microsoft.EntityFrameworkCore;
using PontiAppModelsDraft1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new ApplicationDbContext();

            var query = context.Users
                .Include(user => user.UserEvents)
                .ThenInclude(userEvent => userEvent.Event);

            
            
        }
    }
}
