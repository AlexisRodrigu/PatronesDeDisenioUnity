using UnityEngine;

namespace Avenger
{
    public class FactoryAvengers
    {
        private readonly AvengerConfiguration _avengerConfiguration;

            public FactoryAvengers(AvengerConfiguration avengerConfiguration)
            {
                this._avengerConfiguration = avengerConfiguration;
            }

            public Avenger Create(string id)
            {
                var avenger = _avengerConfiguration.AvengerGetPrefabByID(id);
                return Object.Instantiate(avenger);
            }
        
    }
}