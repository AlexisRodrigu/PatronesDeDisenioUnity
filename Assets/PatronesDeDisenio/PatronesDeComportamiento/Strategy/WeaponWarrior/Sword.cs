
using Strategy.Warriors;
using UnityEngine;

namespace Strategy.WeaponWarrior
{
    public class Sword : MonoBehaviour, WeaponWarrior
    {
        [SerializeField] private Transform _damageZoneCenter; //Punto donde sera el area de colision
        [SerializeField] private float _damageZoneRadius;//Radio
        private readonly Collider2D[] _hitColliders = new Collider2D[10]; //Collider como maximo 10 para evitar que se sature la memoria
    
        public void Attack()
        {
            //Detectamos un radio en la espada si hay un enemigo le aplicamos daño
            var size = Physics2D.OverlapCircleNonAlloc(_damageZoneCenter.position, _damageZoneRadius, _hitColliders);//Overlap para ver que collider estan en la zona

            //Recorremos el numero de colliders que ha encontrado
            for (int i = 0; i < size; i++)
            {
                var hitCollider = _hitColliders[i];
                var warrior = hitCollider.GetComponent<DamageableW>();
                    
                //SI EL COLLIDER NO ES null aplicamos 10 de daño
                    warrior?.DoDamage(10);
            }
        }

       
    }

}