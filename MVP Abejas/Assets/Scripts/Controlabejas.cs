using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlabejas : MonoBehaviour
{
    private Vector2 objetivo;
    public Animator animator;


    //Audio:
    public AudioSource abeja;
    private bool Activo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //animator.SetFloat("Mov", Mathf.Abs(0f));

        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Debug.Log(mousePos);

        if(Input.GetMouseButtonDown(0))
        {
            objetivo = new Vector2(mousePos.x, mousePos.y);

            //audio
            Activo = true;
            abeja.Play();
            
        }

        //audio
        if (Input.GetMouseButtonUp(0))
        {
            Activo = false;

            if (Activo == false)
            { 
                abeja.Pause();
            }   
        }

            transform.position = Vector2.MoveTowards(transform.position, objetivo, Time.deltaTime * 5f);
        animator.SetFloat("Mov", objetivo.x);
        /*if(mousePos.x < 0)
        {
            imagen.flipX = false;
        }
        else
        {
            imagen.flipX = true;
        }*/
    }
}
