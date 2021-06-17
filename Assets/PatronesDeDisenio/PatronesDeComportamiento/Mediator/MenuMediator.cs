using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMediator : MonoBehaviour
{
   [SerializeField] private MainMenu _mainMenu;
   [SerializeField] private SettingsMenu _settingsMenu;

   private void Awake()
   {
      //Llamamaos a la funcion de configuracion en los menus y nos pasamos a nosotros mismos el menuMediator
      _mainMenu.Configure(this);
      _settingsMenu.Configure(this);
      
      //Al iniciar el juego desactivamos los demas menu
      _settingsMenu.Hide();
      
   }

   public void StartGame()
   {
      Debug.Log("Inicias el juego");
   }

   public void MoveToSettings()
   {
      _mainMenu.Hide();
      _settingsMenu.Show();
   }

   public void MoveToMainMenu()
   {
      _settingsMenu.Hide();
      _mainMenu.Show();
   }
}
