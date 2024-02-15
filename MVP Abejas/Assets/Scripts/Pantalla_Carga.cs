using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pantalla_Carga : MonoBehaviour
{
    void Start()
    {
        string levetoload = Carga.nextlevel;

        StartCoroutine(this.MakeTheLoad(levetoload));
    }

    IEnumerator MakeTheLoad(string level)
    {
        //yield return new WaitForSeconds(1f);
        AsyncOperation operation =  SceneManager.LoadSceneAsync(level);

        while (operation.isDone == false)
        {
            yield return null;
        }
    }
}
