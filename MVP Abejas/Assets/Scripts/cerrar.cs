using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cerrar : MonoBehaviour
{
    public float cont = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cont -= Time.deltaTime;
        if(cont <= 0f)
        {
            Application.Quit();
        }
    }
}
