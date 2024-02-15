using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BotonRetro : MonoBehaviour
{
    public GameObject desactivado;
    public GameObject Activado;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseOver()
    {
        desactivado.SetActive(false);
        Activado.SetActive(true);
        Debug.Log("Encima");
    }
    public void OnMouseExit()
    {
        Activado.SetActive(false);
        desactivado.SetActive(true);
        //Debug.Log("Fuera");
    }
}
