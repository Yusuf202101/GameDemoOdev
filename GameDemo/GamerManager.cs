using System;

namespace GameDemo
{
    class GamerManager : IGamerService
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+" adlı oyuncu eklendi...");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+" adlı oyuncu silindi...");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+" adlı oyuncu güncellendi...");
        }
    }
}
