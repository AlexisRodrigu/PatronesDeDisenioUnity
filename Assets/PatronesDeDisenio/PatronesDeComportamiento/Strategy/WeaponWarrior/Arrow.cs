using System;
using Strategy.Warriors;
using UnityEngine;

namespace Strategy.WeaponWarrior
{
    [RequireComponent(typeof(BoxCollider2D))]
    [RequireComponent(typeof(Rigidbody2D))]
    
    public class Arrow : MonoBehaviour
    {
        [SerializeField] private float _speedArrow;

        private void Awake()
        {
            //Añadimos una fuerza a la derecha
            gameObject.GetComponent<Rigidbody2D>().velocity = transform.right * _speedArrow;
        }

        private void OnTriggerEnter(Collider other)
        {
            var warrior = other.GetComponent<DamageableW>(); //De mi warrior obtenemos el Damageable
            warrior?.DoDamage(10); //Hacemos un daño de 10 
            Destroy(gameObject);//Destruimos al colisionar

        }
    }
}