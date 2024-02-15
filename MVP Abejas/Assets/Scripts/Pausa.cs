using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour
{
    [SerializeField] private GameObject botonPausa;
    [SerializeField] private GameObject menuPausa;
    public string nombre = "Elecciones";

    private void Start()
    {
        
    }
    // Start is called before the first frame update
    public void Pausafun()
    {
        Time.timeScale = 0f;
        botonPausa.SetActive(false);
        menuPausa.SetActive(true);
    }

    // Update is called once per frame
    public void Reanudar()
    {
        Time.timeScale = 1f;
        botonPausa.SetActive(true);
        menuPausa.SetActive(false);
    }

    public void Volver()
    {
        Carga.Loadlevel(nombre);
        Time.timeScale = 1f;
        botonPausa.SetActive(true);
        menuPausa.SetActive(false);

    }

    public void Salir()
    {
        Debug.Log("Cerrado");
        Application.Quit();
    }
}
