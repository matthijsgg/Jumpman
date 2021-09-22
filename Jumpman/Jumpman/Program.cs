using System;
using System.Threading;
using Jumpman.Objects;

namespace Jumpman
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character = new Character();
            var x = 0;

            while (true) {
                character.CharacterInfo();
                
                if (x == 0) {
                    x = 1;
                    character.Jump();
                }

                character.UpdateCharacter();

                Thread.Sleep(200);
            }
        }
    }
}
