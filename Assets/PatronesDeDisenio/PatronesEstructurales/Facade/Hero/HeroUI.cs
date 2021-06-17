using UnityEngine;

namespace Hero
{
    public class HeroUI : MonoBehaviour
    {
        [SerializeField] private GameObject _alliesUI;
        [SerializeField] private GameObject _enemiesUI;

        public void ShowAlliesUI()
        {
            _alliesUI.SetActive(true);
        }

        public void HideAlliesUI()
        {
            _alliesUI.SetActive(false);
            
        }

        public void ShowEnemiesUI()
        {
            _enemiesUI.SetActive(true);

        }
        public void HideEnemiesUI()
        {
            _enemiesUI.SetActive(false);

        }
    }
}