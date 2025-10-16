using System.Collections;
using System.Collections.Generic;
using PoolingDemo;
using UnityEngine;

public interface IState<T>
{
    void OnEnter(T owner);
    void OnExit(T owner);
    void OnExcute(T owner);
}

public class BotPatrolState : IState<Bot>
{
    public void OnEnter(Bot owner)
    {
        Debug.Log($"{owner.name} has entered Patrol State.");
    }

    public void OnExit(Bot owner)
    {
        Debug.Log($"{owner.name} has exited Patrol State.");
    }

    public void OnExcute(Bot owner)
    {
        Debug.Log($"{owner.name} is patrolling.");
    }
}

public class BotSeekingBrickState : IState<Bot>
{
    public void OnEnter(Bot owner)
    {
        owner.SeekingBrick();
    }

    public void OnExit(Bot owner)
    {
        // Dieu kien chuyen
        if (owner.HasMeetedBrickCondition())
        {
            owner.ChangeState(new BotBuildingState());
        }
        else
        {
            owner.ChangeState(new BotSeekingBrickState());
        }
        
        if (owner.IsReachedTarget())
        {
            owner.ChangeState(new BotSeekingBrickState());
        }
        
    }

    public void OnExcute(Bot owner)
    {
        
    }
}

public class BotBuildingState : IState<Bot>
{
    public void OnEnter(Bot owner)
    {
        
    }

    public void OnExit(Bot owner)
    {
        
    }

    public void OnExcute(Bot owner)
    {
        
    }
}