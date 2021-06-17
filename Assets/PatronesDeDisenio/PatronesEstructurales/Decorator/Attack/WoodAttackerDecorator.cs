using Decorator.Attack;
using Decorator.Damage;
using UnityEngine;

public class WoodAttackerDecorator : AttackerDecorator
{
    private readonly int _woodDamage;
    public WoodAttackerDecorator(IAttacker attacker, int woodDamage) : base(attacker)
    {
        _woodDamage = woodDamage;
    }

    public override void Attack(IDamageReceiver damageReceiver)
    {
        base.Attack(damageReceiver);
        damageReceiver.ReceiverDamage(_woodDamage, Color.black);
    }
}