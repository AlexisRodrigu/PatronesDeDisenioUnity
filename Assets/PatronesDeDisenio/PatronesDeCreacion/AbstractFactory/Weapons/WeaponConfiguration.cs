using System;
using System.Collections.Generic;
using UnityEngine;

namespace Weapons
{
    [CreateAssetMenu(fileName = "Weapon", menuName = "AbstractFactoryWeapon", order = 0)]
    public class WeaponConfiguration : ScriptableObject
    {
        [SerializeField] private Weapon[] _weapons;
        private Dictionary<string, Weapon> idToWeapon;

        private void Awake()
        {
            idToWeapon = new Dictionary<string, Weapon>();
            foreach (var weapon in _weapons)
            {
                idToWeapon.Add(weapon.ID, weapon);
            }
        }

        public Weapon GetWeaponPrefabById(string id)
        {
            if (!idToWeapon.TryGetValue(id, out var weapon))
            {
                throw new Exception($"$Weapon {id} does exist");
            }
            return weapon;
        }
    }
}