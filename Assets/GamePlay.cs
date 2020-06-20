using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class GamePlay : MonoBehaviour
{
    
    public AudioClip getkey;
    private AudioSource audioSource;
    public Text keynum;
    public static int count = 0;
    public Animator anim;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("key")) {
           count++;
           audioSource.PlayOneShot(getkey);
           Destroy(other.gameObject);
           keynum.text = count.ToString()+"/6";
           if (count == 6){
               anim.enabled = true;
               keynum.color = new Color(0,255,0,0.7f);
           }
       }
        if (other.CompareTag("monster")) {
            count = 0;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene("GameOver");
       }
        if (other.CompareTag("wingame")) {
            count = 0;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene("WinScene");
       }
    }
}
