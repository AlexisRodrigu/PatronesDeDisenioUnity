using System;
using AbstractFactory;
using UnityEngine;

namespace Weapons
{
    public class Consumer : MonoBehaviour
    {
        private BattleFactory currentBattleFactory;

        public void Configure(BattleFactory battleFactory)
        {
            currentBattleFactory = battleFactory;
        }
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                currentBattleFactory.CreateAvenger("IronMan");
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                currentBattleFactory.CreateAvenger("CaptainAmerica");

            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                currentBattleFactory.CreateWeapon("PowerIronMan");
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                currentBattleFactory.CreateWeapon("ShieldCaptainAmerica");
            }
        }
    }
}