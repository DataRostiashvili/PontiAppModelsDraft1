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
           // context.Entry<User>().Entity.UserGuestEvents.
            var query = context.Users
                .Include(user => user.UserGuestEvents)
                .ThenInclude(userEvent => userEvent.Event);

            
            
        }
    }
}
