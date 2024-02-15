using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Video;

public class Adelantar : MonoBehaviour
{
    public UnityEvent OnHold;
    bool isHolding;

    public VideoPlayer player;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        isHolding = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isHolding = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isHolding)
        {
            OnHold.Invoke();
        }
    }

    public void Adelantando()
    {
        player.playbackSpeed = player.playbackSpeed * 3f;
    }
}
