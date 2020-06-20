using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public AudioClip Clip;
    public AudioClip Clip2;
    private AudioSource audioSource;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(Clip2);
    }

    public void PlayGame()
    {
        audioSource.PlayOneShot(Clip);
        SceneManager.LoadScene("StartScene");
    }
}