
    using UnityEngine;

    public abstract class Mutants:MonoBehaviour
    {
        [SerializeField] private string _id;
        public string Id => _id;
    }