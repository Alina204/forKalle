using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customInput : MonoBehaviour
{
    [SerializeField] GameObject MenuCanvas;
    public void OnMenu() => MenuCanvas.SetActive(!MenuCanvas.activeInHierarchy); // it is important that it is called OnMenu
    
}
