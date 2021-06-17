using Decorator.Damage;

namespace Decorator.Attack
{
    public abstract class AttackerDecorator: IAttacker
    {
        private readonly IAttacker _attacker;

        protected AttackerDecorator(IAttacker attacker)
        {
            _attacker = attacker;
        }
        
        //Pasamos el atacante y a quien va a hacer daño
        public virtual void Attack(IDamageReceiver damageReceiver)
        {
            _attacker.Attack(damageReceiver);
        }
    }
}