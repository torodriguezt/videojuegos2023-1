using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;

public class mainMenu : MonoBehaviour
{
    [SerializeField] private Button _startButton;

    private void Start()
    {
        _startButton.onClick.AddListener(OnStartButtonClicked);
    }

    public void OnStartButtonClicked()
    {
        _startButton.interactable = false;
        GameManager.Instance.MainMenu();
    }
}
