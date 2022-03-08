namespace GameDemo
{
    class IValidationSystemManager : IValidationSystemService
    {
        public void Verify(Gamer gamer)
        {
            if(gamer.IdentityNumber == 123456789)
            {
                System.Console.WriteLine("Doğrulandı...");
            }
            else
            {
                System.Console.WriteLine("Doğrulanamadı");
            }
        }
    }
}
