using Decorator.Damage;

namespace Decorator.Attack
{
    public interface IAttacker
    {
        void Attack(IDamageReceiver damageReceiver);
    }
}