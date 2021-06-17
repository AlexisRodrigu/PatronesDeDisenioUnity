using UnityEngine;

namespace Decorator.Damage
{
    public interface IDamageReceiver
    {
        void ReceiverDamage(int damage, Color white);
    }
}