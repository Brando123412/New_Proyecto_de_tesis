using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

public class HandlerManager : MonoBehaviour
{
    [SerializeField] EventListener EventListener;
    public void OnEnable()
    {
        for (int i = 0; i< EventListener.SOEvent.Count; i++)
        {
            EventListener.SOEvent[i].OnEnable();
        }
    }
}

[Serializable]
public class EventListener
{
    public List<GameEventListeners> SOEvent;
}