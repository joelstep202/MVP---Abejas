using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Video;
public class Videos : MonoBehaviour
{
    public VideoPlayer video;
    void Awake()
    {
        video = GetComponent<VideoPlayer>();
        video.loopPointReached += CheckOver; 
    }
    // Start is called before the first frame update
    void Start()
    {
        video = GetComponent<VideoPlayer>();
        video.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CheckOver(VideoPlayer vp)
    {
        gameObject.SetActive(false);
    }

}
