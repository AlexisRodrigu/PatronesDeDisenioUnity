using System;
using Strategy.WeaponWarrior;
using UnityEngine;

namespace Strategy
{
    public class InstallerStrategy : MonoBehaviour
    {
        [SerializeField] private Warrior _warriorPrefab;
        [SerializeField] private Sword _swordPrefab;
        [SerializeField] private Arch _archPrefab;

        [SerializeField] private bool _useSword;

        private void Awake()
        {
            var warrior = Instantiate(_warriorPrefab);
            var weapon = GetWeapon(warrior.transform);//Obtenemos el arma
            warrior.SetWeapon(weapon);//La pasamos al warrior
        }

        private WeaponWarrior.WeaponWarrior GetWeapon(Transform parent)
        {
            //Si usamos la espada instanciamos la espada, sino instanciamos el archo
            if (_useSword)
            {
                return Instantiate(_swordPrefab, parent);
            }
            return Instantiate(_archPrefab, parent);
        }
    }
}