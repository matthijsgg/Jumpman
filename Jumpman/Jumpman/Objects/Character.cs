using System;

namespace Jumpman.Objects
{
    public class Character
    {
        private float Height;
        private float Velocity;
        private float Acceleration;

        public Character() {
            Height = 0;
            Velocity = 0;
            Acceleration = 0;
        }

        public void ChangeHeight() => Height += Velocity;
        
        public void ChangeVelocity() => Velocity += Acceleration;

        public void ChangeAcceleration() {
            Acceleration -= 1;
        }

        public void ResetValues() {
            Height = 0;
            Velocity = 0;
            Acceleration = 0;
        }
        
        public void Jump() => Acceleration += 4;

        public void CharacterInfo() {
            Console.WriteLine($"Height: {Height} Velocity: {Velocity} Acceleration: {Acceleration}");
        }

        public void UpdateCharacter() {
            ChangeHeight();
            ChangeVelocity();

            if (Height > 0) {
                ChangeAcceleration();
            }

            if (Height < 0) {
                ResetValues();
            } 
        }
    }
}