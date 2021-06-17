
using System;
using UnityEngine;

public abstract class Chassis:MonoBehaviour
{

    [SerializeField] private Transform _frontRightTyrePosition;
    [SerializeField] private Transform _frontLeftTyrePosition;
    [SerializeField] private Transform _backRightTyrePosition;
    [SerializeField] private Transform _backLeftTyrePosition;
    
    public Transform GetTyrePosition(TyrePosition tyrePosition)
    {
        switch (tyrePosition)
        {
            case TyrePosition.FrontLeft: return _frontLeftTyrePosition;
            case TyrePosition.FrontRight: return _frontRightTyrePosition; 
            case TyrePosition.BackLeft: return _backLeftTyrePosition;
            case TyrePosition.BackRight: return _backRightTyrePosition;
        }

        //Si no se cumple el case 
        throw new ArgumentOutOfRangeException(nameof(tyrePosition), tyrePosition, null);
    }

    protected abstract void OnCollisionEnter(Collision other);
}