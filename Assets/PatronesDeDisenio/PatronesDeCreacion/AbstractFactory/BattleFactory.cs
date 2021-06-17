using Avenger;
using Weapons;

namespace AbstractFactory
{
    public class BattleFactory
    {
        private readonly FactoryAvengers _factoryAvengers;
        private readonly FactoryWeapon _factoryWeapon;

        public BattleFactory(FactoryAvengers factoryAvengers, FactoryWeapon factoryWeapon)
        {
            this._factoryAvengers = factoryAvengers;
            this._factoryWeapon = factoryWeapon;
        }

        public Avenger.Avenger CreateAvenger(string avengerById)
        {
            return _factoryAvengers.Create(avengerById);
        }

        public Weapon CreateWeapon(string weaponById)
        {
            return _factoryWeapon.Create(weaponById);
        }
    }
}