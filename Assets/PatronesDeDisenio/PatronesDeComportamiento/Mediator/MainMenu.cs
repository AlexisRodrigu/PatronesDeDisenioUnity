using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    [SerializeField] private Button _startButton;
    [SerializeField] private Button _settingsButton;
    [SerializeField] private CanvasGroup _canvasGroup;

    private MenuMediator _menuMediator;


    private void Awake()
    {
        _startButton.onClick.AddListener(() => _menuMediator.StartGame());
        _settingsButton.onClick.AddListener(()=> _menuMediator.MoveToSettings());
    }

    public void Configure(MenuMediator menuMediator)
    {
        _menuMediator = menuMediator;
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
