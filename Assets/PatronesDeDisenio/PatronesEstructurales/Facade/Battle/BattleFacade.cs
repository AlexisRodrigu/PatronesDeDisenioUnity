using Hero;
using UnityEngine;

namespace Battle
{
    public class BattleFacade : MonoBehaviour
    {
        [SerializeField] private HeroSpawner _heroSpawner;
        [SerializeField] private HeroUI _heroUI;
        [SerializeField] private ScreenFade _screenFade;

        public void StartBattle()
        {
            _screenFade.Show();
            _heroSpawner.SpawnAllies();
            _heroSpawner.SpawnEnemies();
            _heroUI.ShowAlliesUI();
            _heroUI.ShowEnemiesUI();
            _screenFade.Hide();
        }

        public void EndBattle()
        {
            _screenFade.Hide();
            _heroSpawner.DestroyAllies();
            _heroSpawner.DestroyEnemies();
            _heroUI.HideAlliesUI();
            _heroUI.HideEnemiesUI();
            _screenFade.Show();
        }
    }
}