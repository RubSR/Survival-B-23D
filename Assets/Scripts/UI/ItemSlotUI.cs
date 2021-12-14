using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlotUI : MonoBehaviour
{
    //Boton
    public Button button;
    //Icono
    public Image icono;
    //Texto cantidad
    public TextMeshProUGUI cantidadText;
    //Slot actual
    private ItemSlot slotActual;
    //Borde que se pintará en el objeto equipado
    private Outline outline;
    public int indice;
    public bool equipado;

    private void Awake()
    {
        outline = GetComponent<Outline>();
    }

    private void OnEnable()
    {
        outline.enabled = equipado;
    }
    
    //Parte visual del Slot
    public void Set(ItemSlot slot)
    {
        slotActual = slot;
        //Activamos el icono
        icono.gameObject.SetActive(true);
        //Le ponemos el icono
        icono.sprite = slot.item.icono;
        //Pintamos la cantidad
        cantidadText.text = slot.cantidad > 1 ? slot.cantidad.ToString() : string.Empty;
        //Controlamos el outline
        if (outline != null)
            outline.enabled = equipado;
        
    }
    
    //Limpiar el slot
    public void LimpiarSlot()
    {
        slotActual = null;
        icono.gameObject.SetActive(false);
        cantidadText.text = string.Empty;

    }

    public void PresionarBoton()
    {
        Inventario.instancia.SelectItem(indice);
    }
}
