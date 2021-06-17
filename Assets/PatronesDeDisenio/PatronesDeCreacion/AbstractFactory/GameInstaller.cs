using System;
using Avenger;
using UnityEngine;
using Weapons;

namespace AbstractFactory
{
    public class GameInstaller :MonoBehaviour
    {
        [SerializeField] private AvengerConfiguration _avengerConfiguration;
        [SerializeField] private WeaponConfiguration _weaponConfiguration;
        
        //nueva weaponconfiguration de newWeapon
        [SerializeField] private WeaponConfiguration _newWeaponConfiguration;

        private Consumer _consumer;
        
        private FactoryAvengers avengerFactory;
        private FactoryWeapon weaponFactory, _newWeaponFactory;
        
        private BattleFactory _battleFactory;
        private BattleFactory _newBattleFactory;


        private void Start()
        {
            avengerFactory = new FactoryAvengers(Instantiate(_avengerConfiguration));
            weaponFactory = new FactoryWeapon(Instantiate(_weaponConfiguration));
            
            //Factoria de nuevas armas
           _newWeaponFactory = new FactoryWeapon(Instantiate(_newWeaponConfiguration));

            var consumerObject = new GameObject();
            _consumer = consumerObject.AddComponent<Consumer>();
            
            _battleFactory = new BattleFactory(avengerFactory,weaponFactory);
            //FACTORIA DE NUEVAS ARMAS
            _newBattleFactory = new BattleFactory(avengerFactory,_newWeaponFactory);

            _consumer.Configure(_battleFactory);
        }

        private void Update()
        {
            // Al presionar q y despues uno de los botones del installer ya cambiara sirve por si hay una temporada de hallowen somelike that
            if (Input.GetKeyDown(KeyCode.Q))
            {
                _consumer.Configure(_newBattleFactory);
            }
        }
    }
  
   
}