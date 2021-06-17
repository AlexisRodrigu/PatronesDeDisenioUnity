using UnityEngine;

namespace Weapons
{
    public class Weapon: MonoBehaviour
    {
        [SerializeField] protected string id;

        public string ID => id;
    }
}