using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogController : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Attempting to configure fog settings...");
        RenderSettings.fog = true;

        RenderSettings.fogMode = FogMode.Linear;

        RenderSettings.fogColor = new Color(0.7f, 0.7f, 0.7f, 1.0f);

        RenderSettings.fogStartDistance = 30f;
        RenderSettings.fogEndDistance = 100f;
    }
}
