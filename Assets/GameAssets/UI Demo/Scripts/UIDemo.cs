using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace UIDemo
{
    public class UIDemo : MonoBehaviour
    {
        [SerializeField] private Button btnDemo;
        [SerializeField] private Slider slider;
        [SerializeField] private Image imgFill;
        [SerializeField] private Transform tfContainer;
        [SerializeField] private CanvasGroup canvasGroup;
        [SerializeField] private TextMeshProUGUI txtDemo;
        [SerializeField] [Range(0, 1)] private float range;
        [SerializeField] private GameObject goPrefab;
        
        private void Start()
        {
            btnDemo.onClick.AddListener(OnClick);
            slider.value = 0.8f;
            canvasGroup.alpha = range;
            imgFill.fillAmount = range;
            txtDemo.SetText($"<color=black>Demo Text Black</color>. Normal Text");
            SetupCharacterInfos();
        }

        private void SetupCharacterInfos()
        {
            for (int i = 0; i < 10; i++)
            {
                Instantiate(goPrefab, tfContainer);
            }
        }

        private void OnClick()
        {
            Debug.Log("Button Clicked");
            // btnDemo. = false;
        }
    }
}

