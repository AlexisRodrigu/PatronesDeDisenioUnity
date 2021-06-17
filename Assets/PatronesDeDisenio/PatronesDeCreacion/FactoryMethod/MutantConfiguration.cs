using System;
using System.Collections.Generic;
using UnityEngine;

    [CreateAssetMenu(fileName = "Mutant Configuration", menuName = "CreateMutant", order = 0)]
    public class MutantConfiguration : ScriptableObject
    {
        [SerializeField] private Mutants[] _mutants;
        private Dictionary<string, Mutants> _idToMutants;
        
        private void Awake()
        {
            //Creamos el diccionario
            _idToMutants = new Dictionary<string, Mutants>();

            //Cada mutant en la clase mutants, lo añadimos al diccionario idToMutants
            foreach (var mutant in _mutants)
            {
                _idToMutants.Add(mutant.Id, mutant);
            }
        }

        //Creamos al mutante
        public Mutants GetMutantPrefab(string id)
        {
            Mutants mutant;
            //Si no existe lanzamos el error
            if (!_idToMutants.TryGetValue(id,out mutant))
            {
                throw new Exception($"Mutant {id}, does exist ");
            }

            return mutant;
        }
    }
