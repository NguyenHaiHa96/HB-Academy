using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UIDemo
{
    public class UIDemo : MonoBehaviour
    {
        [SerializeField] private Button btnDemo;
        [SerializeField] private Image imgFill;
        [SerializeField] private Transform tfContainer;
        [SerializeField] private CanvasGroup canvasGroup;
        
        [SerializeField] [Range(0, 1)] private float range;
    }
}

