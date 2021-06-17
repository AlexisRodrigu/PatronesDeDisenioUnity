using System;
using UnityEngine;
using System.Collections;

    public class Carretera : MonoBehaviour
    {
        private CocheClass _coche = new CocheClass();
        [SerializeField] private bool motorEncendido;

        public int ruedas;
        private void Start()
        {
            
        }

        private void Update()
        {
            if (motorEncendido)
            {
                EncenderCoche();
            }
            else
            {
                ApagarCoche();
            }
        }

        void EncenderCoche()
        {
            ruedas = _coche.ruedas.cantidad;
            ruedas = 2;
           
            Debug.Log(ruedas);
            _coche.puerta.cerrojo = true;

            //Llamamos al enumerado
            _coche.ruedas._colorRueda = Ruedas.ColorRueda.azul;
            
            
        }

        void ApagarCoche()
        {
            _coche.ApagarMotor();
        }
    }
