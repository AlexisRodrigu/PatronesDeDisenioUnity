using System;
using System.Collections;
using System.Collections.Generic;
using Decorator.Attack;
using Decorator.Damage;
using UnityEngine;

public class ConsumerDecorator : MonoBehaviour
{
    [SerializeField] private DamageReceiver _damageReceiver;
    private RegularAttack _regularAttack;
    private FireAttackerDecorator _fireAttacker;
    private WoodAttackerDecorator _woodAttacker;
    private FireAttackerDecorator _woodWithFireAttacker;


    private void Awake()
    {
        const int damage = 100;
        const int fireAttack = 10;
        const int _woodAttack = 20;
        _regularAttack = new RegularAttack(damage);
        _fireAttacker = new FireAttackerDecorator(_regularAttack,fireAttack);
        _woodAttacker = new WoodAttackerDecorator(_regularAttack, _woodAttack);

        //ATAQUE COMBINADO
        _woodWithFireAttacker = new FireAttackerDecorator(_woodAttacker, fireAttack);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            _regularAttack.Attack(_damageReceiver);
        }
        
        else if (Input.GetKeyDown(KeyCode.S))
        {
            _fireAttacker.Attack(_damageReceiver);
        }
        
        else if (Input.GetKeyDown(KeyCode.D))
        {
            _woodAttacker.Attack(_damageReceiver);
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            _woodWithFireAttacker.Attack(_damageReceiver);
        }
    }
}
