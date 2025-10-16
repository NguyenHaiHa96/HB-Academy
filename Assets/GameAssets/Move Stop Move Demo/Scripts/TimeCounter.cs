using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimeCounter 
{
    public UnityAction doneAction;
    public float time;
    public bool IsRunning => time > 0;

    public void Start(UnityAction dAction, float t)
    {
        doneAction = dAction;
        time = t;
    }

    public void Execute()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
            if (time <= 0)
            {
                Exit();
            }
        }
    }

    public void Exit()
    {
        doneAction?.Invoke();
    }

    public void Cancel()
    {
        doneAction = null;
        time = -1;
    }
}
