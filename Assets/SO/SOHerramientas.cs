using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Herramientas", menuName = "ScriptableObjects/Herramienta", order = 1)]
public class SOHerramientas : ScriptableObject
{
    [SerializeField] TypeHerramientas nameSettings;
    [SerializeField] GameObject prefabReferencia;
    //public GameObject PrefabReferencia => prefabReferencia;
    public void RetunrObject(Vector3 positionSpanw)
    {
        GameObject tmp = prefabReferencia;
        tmp.AddComponent<GrabInteractable>();
        Instantiate(tmp,positionSpanw,Quaternion.identity);
    }

}
