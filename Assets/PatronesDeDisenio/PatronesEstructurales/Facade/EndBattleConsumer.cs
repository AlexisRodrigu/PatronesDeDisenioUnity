using Battle;
using Hero;
using UnityEngine;

namespace Facade
{
    public class EndBattleConsumer:MonoBehaviour
    {
        [SerializeField] private BattleFacade battleFacade;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
             battleFacade.EndBattle();
            }
        }
    }

}