using System.Collections.Generic;
using UnityEngine;

namespace Vehicle
{
    public class Vehicle : MonoBehaviour
    {
        //Le pasamos las llantas y el chassis
        private Dictionary<TyrePosition, Tyre> _tyres;
        private Chassis _chassis;
        
        //Obtenemos sus componentes
        public void SetComponents(Dictionary<TyrePosition, Tyre> tyres, Chassis chassis)
        {
            _tyres = tyres;
            _chassis = chassis;
        }
    }
}