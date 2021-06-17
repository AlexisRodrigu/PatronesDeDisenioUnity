using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    [SerializeField] private Button _backButton;
    [SerializeField] private CanvasGroup _canvasGroup;
    private MenuMediator _menuMediator;
    
    public void Configure(MenuMediator menuMediator)
    {
        _menuMediator = menuMediator;
    }
    private void Awake()
    {
        _backButton.onClick.AddListener(() => _menuMediator.MoveToMainMenu());
       
    }
    
    public void Hide()
    {
        //importamos libreria tweening, hacemos un fade para esconder
        _canvasGroup.DOFade(0.0f, 0.5f);
    }

    public void Show()
    {
        _canvasGroup.DOFade(1.0f, 0.5f);
    }
}
