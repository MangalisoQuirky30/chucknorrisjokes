using ChuckNorrisJokesLibrary;
using System.Threading.Tasks;

using System;

namespace ChuckNorrisJokes
{
    class Program
    {
        static async Task Main(string[] args)
        {
            JokeGenerator jokeGenerator = new JokeGenerator();
            string randomJoke = await jokeGenerator.GetRandomJoke();

            string[] catStrArr = await jokeGenerator.GetCategories();

            Console.WriteLine(randomJoke) ;


            for( int i = 0; i < catStrArr.Length; i++ )
            {
                Console.WriteLine(catStrArr[i]);
            }


            
            for(int y = catStrArr.Length -1; y > 0; y--)
            {
                Console.WriteLine(catStrArr[y]);
            }


           
        }
    }
}
