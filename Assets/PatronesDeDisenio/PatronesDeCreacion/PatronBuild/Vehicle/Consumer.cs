using UnityEngine;

namespace Vehicle
{
    public class Consumer : MonoBehaviour
    {
        //Nuestro jugador al iniciar sin carro y sin chasis
        private void Awake()
        {
            var vehicleBuilder = new VehicleBuilder();
            vehicleBuilder
                .WithChassis(null)
                .WithTyre(TyrePosition.FrontLeft, null)
                .WithTyre(TyrePosition.FrontRight, null)
                .Build();
            
            vehicleBuilder.WithPosition(new Vector3(1,2,3))
                .Build();
        }
    }
}