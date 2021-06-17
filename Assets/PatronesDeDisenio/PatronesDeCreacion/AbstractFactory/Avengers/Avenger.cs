using UnityEngine;

namespace Avenger
{
    public class Avenger : MonoBehaviour
    {
        [SerializeField] protected string _id;
        public string ID => _id;
    }
}