using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class Video : MonoBehaviour
{
    public RawImage raw;
    public VideoPlayer video;
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Play());
    }
    
    IEnumerator Play(){
        video.Prepare();
        WaitForSeconds wait = new WaitForSeconds(0.001f);
        while (!video.isPrepared){
            yield return wait;
        }
        raw.texture = video.texture;
        video.Play();
        audio.Play();
    }

}
