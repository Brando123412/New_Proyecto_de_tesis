using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEditor;
using System;

[Serializable]
public class GameEventListeners
{
    [SerializeField] private string nameEventListener;
    [SerializeField] public GameIntEvent gameIntEvent;
    public UnityEvent<int> responde;
    public void OnEnable()
    {
        gameIntEvent.RegistryListaner(this);
    }
    public void OnDisable()
    {
        gameIntEvent.UnRegistryListaner(this);
    }
    public void OnRaiseNotified(int value)
    {
        responde?.Invoke(value);
    }

}