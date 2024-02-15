using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_principal : MonoBehaviour
{
    public GameObject imgagen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Cambiar()
    {
        Carga.Loadlevel("Intro");
    }

     public void Credits()
    {
        Carga.Loadlevel("Creditos_pas");
    }

    public void Activar()
    {
        imgagen.SetActive(true);
    }

    public void Desact()
    {
        imgagen.SetActive(false);
    }
}
