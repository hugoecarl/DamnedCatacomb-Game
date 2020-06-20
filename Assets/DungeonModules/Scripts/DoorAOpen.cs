using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAOpen : MonoBehaviour
{

    public AudioClip doorsound;
    private AudioSource audioSource;
    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnTriggerEnter(Collider other)
    {
        audioSource.PlayOneShot(doorsound);
        StartCoroutine(Play());
        GetComponent<Animator>().SetTrigger("DoorATrigger");
    }

    IEnumerator Play(){
        yield return new WaitForSeconds(2);
        audioSource.enabled = false;
        }
}