using System;

namespace xxxIncapsulatiosion1
{
    public class Bot
    {
        private Weapon _weapon;

        public Bot(Weapon weapon)
        {
            _weapon = weapon;
        }

        public void OnSeePlayer(Player player)
        {
            if (player.IsDead) return;

            _weapon.Fire(player);
        }
    }
}
