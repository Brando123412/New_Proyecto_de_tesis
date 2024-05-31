using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TypeHerramientas {Perno, Tuerca, Destornillador, Llave, Candato, Manguera}
public enum TypeObjetosSegurity {Casco, ZapatoSeguridad, ChallecoSeguridad, Mameluco}
public class GameController : MonoBehaviour
{
    [SerializeField] SOHerramientas soHerramientas;
    private void Start()
    {
        soHerramientas.RetunrObject(Vector3.zero);
    }
}
