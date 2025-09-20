using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasMainMenu : UICanvas
{
    [Header("Canvas Main Menu")]
    [SerializeField] private Button btnPlay;

    public override void Setup()
    {
        base.Setup();
        btnPlay.onClick.AddListener(OnClickPlay);
    }
    
    private void OnClickPlay()
    {
        Debug.Log("Play button clicked. Starting game...");
    }
}
