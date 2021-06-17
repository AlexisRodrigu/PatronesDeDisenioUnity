using System;
using Battle;
using Hero;
using UnityEngine;

namespace Facade
{
    public class StartBattleConsumer:MonoBehaviour
    {
       [SerializeField] private BattleFacade _battleFacade;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
               _battleFacade.StartBattle();
            }
        }
    }
}


