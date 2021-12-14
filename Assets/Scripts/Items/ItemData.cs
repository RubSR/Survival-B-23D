using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "Pepe", menuName = "Nuevo Pepe")]
public class ItemData : ScriptableObject
{
    [Header("info")] 
    public string nombre;

    public string descripcion;
    public Sprite icono;
    public GameObject prefabDrop;
    public ItemType tipo;

    [Header("Stackable")] 
    public bool puedeStackear;
    public int maxNumStack;

    [Header("Consumible")] public ItemDataConsumible[] stats;

    [Header("Prefab equipable")] 
    public GameObject equipoPrefab;

}
public enum ItemType
{
    Recurso,
    Equipable,
    Consumible
}

public enum TipoStatConsumible
{
    Hambre,
    Sed,
    Vida,
    Sueño
}

[System.Serializable]
public class ItemDataConsumible
{
    public TipoStatConsumible tipo;
    public float valor;
}
