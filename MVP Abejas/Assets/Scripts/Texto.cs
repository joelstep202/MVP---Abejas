using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class Texto : MonoBehaviour
{
    //public TextMeshProUGUI textD;

    public string parrafos;
    int index;

    //public GameObject botonquitar;
    public GameObject botonleer;
    public GameObject imagen;
    public GameObject video;

    // Start is called before the first frame update
    void Start()
    {
        //botonquitar.SetActive(false);
        botonleer.SetActive(false);
        imagen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            botonleer.SetActive(true);
            imagen.SetActive(true);
            //Debug.Log("tatatataa");
        }
        else
        {
            botonleer.SetActive(false);
            imagen.SetActive(false);
        }
    }

    public void BotonVer()
    {
        video.SetActive(true);
    }

    public void BotonQuitar()
    {

    }
}
