using UnityEngine;

namespace Strategy.Warriors
{
    public class EnemyWarrior: MonoBehaviour,DamageableW
    {
        public void DoDamage(int damage)
        {
            Debug.Log("DamageRecevied");
        }
    }
}