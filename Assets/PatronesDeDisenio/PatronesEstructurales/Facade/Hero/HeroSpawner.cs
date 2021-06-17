using System.Collections.Generic;
using UnityEngine;

namespace Hero
{
    public class HeroSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject[] _alliesToSpawm;
        private List<GameObject> _alliesSpawned;

        [SerializeField] private GameObject[] _enemiesToSpawn;
        private List<GameObject> _enemiesSpawned;

        private void Awake()
        {
            _alliesSpawned = new List<GameObject>();
            _enemiesSpawned = new List<GameObject>();
        }

        public void SpawnAllies()
        {
            foreach (var allyToSpawn in _alliesToSpawm)
            {
                GameObject allyInstantiate = Instantiate(allyToSpawn);
                _alliesSpawned.Add(allyInstantiate);
            }
        }

        public void DestroyAllies()
        {
            foreach (var allyToDestroy in _alliesSpawned)
            {
                Destroy(allyToDestroy);
            }
            _alliesSpawned.Clear();
        }

        public void SpawnEnemies()
        {
            foreach (var enemyToSpawn in _enemiesToSpawn)
            {
                GameObject enemyInstantiate = Instantiate(enemyToSpawn);
                _enemiesSpawned.Add(enemyInstantiate);
            }
        }
        public void DestroyEnemies()
        {
            foreach (var enemyToDestroy in _enemiesSpawned)
            {
                Destroy(enemyToDestroy);
            }
            _enemiesSpawned.Clear();
        }
    }
}