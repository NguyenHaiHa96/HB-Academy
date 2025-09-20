using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum EUiShopItemState
{
    None = 0,
    Buy = 1, 
    Bought = 2, 
    Equipped = 3, 
    Selecting = 4
}

public class UIShopItem : MonoBehaviour
{
    [SerializeField] private GameObject[] goStateObjects;
    [SerializeField] private Color[] colorBg;
    [SerializeField] private Image imgIcon;
    [SerializeField] private Image imgBgIcon;
    [SerializeField] private Button btnSelect;
    [SerializeField] private EUiShopItemState currentState;
    private void Start()
    {
        btnSelect.onClick.AddListener(OnClickSelectItem);
    }

    private void OnClickSelectItem()
    {
        UIManager.Ins.GetUI<CanvasShop>().SelectItem(this);
    }
    
    public void SetState(EUiShopItemState state)
    {
        for (int i = 0; i < goStateObjects.Length; i++)
        {
            goStateObjects[i].SetActive(false);
        }

        goStateObjects[(int)state].SetActive(true);

        this.currentState = state;
    }
}
