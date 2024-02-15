using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSeleccion : MonoBehaviour
{
    public AudioSource sound;
    public AudioClip abeja;

    public void Abejas()
    {
        sound.clip = abeja;

        sound.enabled = false;
        sound.enabled = true;
    }
    
}
