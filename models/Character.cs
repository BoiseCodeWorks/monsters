using System;

namespace monsters
{
    public class Character
    {
        int MaxHealth;
        int Health;
        public int MaxDamage;
        public int MinDamage; 

        public int getHealth()
        {
            return Health;
        }
        public void takeHit(int damage){
            Health -= damage;
        }

        public int Hit()
        {
            Random rand = new Random();
            return rand.Next(MinDamage, MaxDamage+1);
        }

        public void Heal()
        {
            Random rand = new Random();
            Health += rand.Next(5,11);
        }

        public void Reset(){
            Health = MaxHealth;
        }
        public Character(int health, int min, int max)
        {
            Health = health;
            MaxHealth = health;
            MinDamage = min;
            MaxDamage = max;
        }
    }
}