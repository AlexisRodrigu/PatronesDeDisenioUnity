using System;
using UnityEngine;

    public class SpawnerMutants : MonoBehaviour
    {
        [SerializeField] private MutantConfiguration _mutantConfiguration;
        private MutantsFactory _mutantsFactory;

        private void Awake()
        {
            //Le pasamos la instancia de la configuracion
            _mutantsFactory = new MutantsFactory(Instantiate(_mutantConfiguration));
        }

        private void Update()
        {
            if (Input.GetKey(KeyCode.A))
            {
                _mutantsFactory.Create("Cyclops");
            }
            
            else if (Input.GetKey(KeyCode.D))
            {
                _mutantsFactory.Create("Wolverine");
            }
        }
    }
