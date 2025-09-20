using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VFXDemo
{
    public class LineRenderer3DDemo : MonoBehaviour
    {
        [SerializeField] private LineRenderer lineRenderer;
        [SerializeField] private List<Transform> points;

        private void Start()
        {
            lineRenderer.positionCount = points.Count;
            for (int i = 0; i < points.Count; i++)
            {
                if (points[i] != null)
                {
                    lineRenderer.SetPosition(i, points[i].position);
                }
            }
        }
        
        private void Update()
        {
            for (int i = 0; i < points.Count; i++)
            {
                if (points[i] != null)
                {
                    lineRenderer.SetPosition(i, points[i].position);
                }
            }
        }
    }
}

