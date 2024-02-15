using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Carga : MonoBehaviour
{
    public static string nextlevel;

    public static void Loadlevel(string name)
    {
        nextlevel = name;
        SceneManager.LoadScene("Pantalla_Carga");
    }

}
