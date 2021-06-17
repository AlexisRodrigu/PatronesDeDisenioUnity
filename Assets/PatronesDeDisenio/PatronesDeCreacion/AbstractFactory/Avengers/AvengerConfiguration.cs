using System;
using System.Collections.Generic;
using UnityEngine;

namespace Avenger
{
    [CreateAssetMenu(fileName = "Avenger", menuName = "AbstractFactoryAvenger", order = 0)]
    public class AvengerConfiguration : ScriptableObject
    {
        [SerializeField] private Avenger[] _avengers;
        private Dictionary<string, Avenger> idToAvenger;

        private void Awake()
        {
            idToAvenger = new Dictionary<string, Avenger>();
            foreach (var avenger in _avengers)
            {
                idToAvenger.Add(avenger.ID,avenger);
            }
        }

        public Avenger AvengerGetPrefabByID(string id)
        {
            if (!idToAvenger.TryGetValue(id,out var avenger))
            {
                throw new Exception($"$Avenger {id} does exist");
            }
            return avenger;
        }
    }
}