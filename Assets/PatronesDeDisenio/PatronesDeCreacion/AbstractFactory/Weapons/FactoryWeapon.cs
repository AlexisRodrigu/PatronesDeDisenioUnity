
using UnityEngine;

namespace Weapons
{
    public class FactoryWeapon
    {
        private readonly WeaponConfiguration _weaponConfiguration;

            public FactoryWeapon(WeaponConfiguration weaponConfiguration)
            {
                this._weaponConfiguration = weaponConfiguration;
            }

            public Weapon Create(string id)
            {
                var weapon = _weaponConfiguration.GetWeaponPrefabById(id);
                return Object.Instantiate(weapon);
            }
    }
}