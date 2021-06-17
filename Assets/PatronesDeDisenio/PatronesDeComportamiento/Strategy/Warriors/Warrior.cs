using System;
using System.Collections;
using System.Collections.Generic;
using Strategy.Warriors;
using Strategy.WeaponWarrior;
using UnityEngine;


public class Warrior : MonoBehaviour,DamageableW
{
    private WeaponWarrior _weaponWarrior;//Tomamos el arma

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            _weaponWarrior.Attack();
        }
    }

    public void DoDamage(int damage)
    {
      Debug.Log("Daño recibido");
    }

    public void SetWeapon(WeaponWarrior weaponWarrior)
    {
        _weaponWarrior = weaponWarrior;
    }
}
