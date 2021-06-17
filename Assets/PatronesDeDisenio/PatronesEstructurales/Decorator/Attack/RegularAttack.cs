using Decorator.Damage;
using UnityEngine;

namespace Decorator.Attack
{
    public class RegularAttack: IAttacker
    {
        private readonly int _damage;

        public RegularAttack(int damage)
        {
            _damage = damage;
        }

        public void Attack(IDamageReceiver damageReceiver)
        {
            damageReceiver.ReceiverDamage(_damage, Color.white);
        }
    }
}