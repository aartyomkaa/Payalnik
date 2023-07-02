using System;

namespace xxxIncapsulatiosion1
{
    public class Player
    {
        private int _health;

        public Player(int health)
        {
            if (health <= 0)
                throw new ArgumentOutOfRangeException(nameof(health));
            else
                _health = health;
        }

        public bool IsDead => _health <= 0;

        public void TakeDamage(int damage)
        {
            if (IsDead) return;

            _health -= damage;
        }
    }
}