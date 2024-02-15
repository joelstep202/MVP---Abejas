using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botonelec : MonoBehaviour
{
    public string nivel = "";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Cambio()
    {
        Carga.Loadlevel(nivel);
    }
}
