using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class playerhealth : MonoBehaviour
{
    public AudioSource playerhitsound;
    public AudioClip playerhurtsclip;
    public AudioClip playerhitsoundclip;
    public float hittime = 0.3f;
    public float nexthit = 0.0f;
    public float health;
    public Text hp;
    // Use this for initialization
    void Start()
    {
        
        playerhitsound = GetComponent<AudioSource>();
        health = 10;
    }

    // Update is called once per frame
    void Update()
    {
        hp.text = "hp: " + health;
        if (health <= 0)
        {
            if (playerhitsound.isPlaying)
            {

                float delay = playerhitsound.clip.length - playerhitsound.time;
                Destroy(gameObject,delay);
            }
            
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            if (Time.time > nexthit)
            {
                
                playerhitsound.PlayOneShot(playerhitsoundclip);
                playerhitsound.PlayOneShot(playerhurtsclip);
                health -= 1;
                nexthit = Time.time + hittime;
            }
        }
    }
}
