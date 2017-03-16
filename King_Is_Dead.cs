using System;

namespace King_Is_Dead
{
    class Program
    {
        
       
        static int Main(string[] args)
        {
            Game game = new Game();
            HomeScreen s = new HomeScreen(game);
            
            s.display();
            return 0;
        }

    }
}
