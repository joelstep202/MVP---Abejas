using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContadorEscena : MonoBehaviour
{
    public float tiempo = 0f;
    public string nivel = "";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempo -= Time.deltaTime;
        if(tiempo <= 0)
        {
            Carga.Loadlevel(nivel);
        }
    }
}
