using UnityEngine;

namespace Strategy.WeaponWarrior
{
    public class Arch : MonoBehaviour,WeaponWarrior
    {
        [SerializeField] private GameObject _arrowPrefab;//Flecha a lanzar
        [SerializeField] private Transform _spawnReference;//Posicion donde hara el spawn
        
        public void Attack()
        {
            var arrow = Instantiate(_arrowPrefab, _spawnReference.position, _spawnReference.rotation);
        }
    }
}