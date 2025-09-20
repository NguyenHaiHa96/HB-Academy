using System;
using System.Collections.Generic;
using System.Linq;

public class EventDispatcher
{
    private static EventDispatcher _instance;
    public static EventDispatcher Instance
    {
        get
        {
            if (_instance == null) _instance = new EventDispatcher();
            return _instance;
        }
    }

    private Dictionary<EventID, Action<object>> _eventActionDict;
    private Dictionary<EventID, Action<object>> EventActionDict
    {
        get
        {
            if (_eventActionDict == null) _eventActionDict = new Dictionary<EventID, Action<object>>();
            return _eventActionDict;
        }
    }

    public void PostEvent(EventID eventID, object eventData = null)
    {
        var dictList = EventActionDict.ToList();

        for (int i = dictList.Count - 1; i >= 0; i--)
        {
            var kvp = dictList[i];
    
            if (kvp.Key == eventID)
            {
                if (kvp.Value != null) kvp.Value(eventData);
            }
        }

        // foreach (var kvp in EventActionDict)
        // {
        //     if (kvp.Key == eventID)
        //     {
        //         if (kvp.Value != null) kvp.Value(eventData);
        //     }
        // }
    }

    public void RegisterListener(EventID eventID, Action<object> callback)
    {
        if (EventActionDict.ContainsKey(eventID))
        {
            EventActionDict[eventID] += callback;
        }
        else
        {
            EventActionDict.Add(eventID, callback);
        }
    }

    public void RemoveListener(EventID eventID, Action<object> callback)
    {
        if (EventActionDict.ContainsKey(eventID))
        {
            EventActionDict[eventID] -= callback;
        }
    }
}

public enum EventID
{
    None,
    EndLevel,
    ShowHidePopup,
    PauseGame,
    StartLoadScene,
    EndLoadScene,
    EndLoadLevel,
    UserLoginNewDay,
    NextStage,
    NextWave,
    EnemyKilled,
    SummonHero,
    FinishCampaignChapter,
    FinishCampaignDifficulty,
    OnWaveCampaignSpawned,
}