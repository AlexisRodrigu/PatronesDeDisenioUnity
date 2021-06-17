using System;
using TMPro;
using UnityEngine;

namespace Decorator.Damage
{
    public class DamageReceiver : MonoBehaviour, IDamageReceiver
    {
        [SerializeField] private TextMeshProUGUI[] _damageTxts;
        private int _lastTextUsed;

        private void Awake()
        {
            foreach (var damageTxt in _damageTxts)
            {
                damageTxt.SetText(String.Empty);
            }
        }

        public void ReceiverDamage(int damage, Color color)
        {
            int textIndex = GetTextIndexToUse();
            _damageTxts[textIndex].SetText(damage.ToString());
            _damageTxts[textIndex].color = color;

            _lastTextUsed = textIndex;
        }

        private int  GetTextIndexToUse()
        {
            return (_lastTextUsed + 1) % _damageTxts.Length;
        }
    }
}