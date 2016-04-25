using UnityEngine;
using System.Collections;

public class enemyhealth : MonoBehaviour
{
    private float health;
    public AudioSource enemyHitSound;
    public killcounter counter;
    public bool dead = false;
    // Use this for initialization
    void Start()
    {
        counter = FindObjectOfType<killcounter>();
       
        health = 3;
        enemyHitSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(health <= 0)
        {
            if (dead == false)
            {
                counter.kills += 1;
            }
            dead = true;

            if (enemyHitSound.isPlaying)
            {
                
                float delay = enemyHitSound.clip.length - enemyHitSound.time;
                Destroy(gameObject, delay);   
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("bullet"))
        {
            enemyHitSound.Play();
            health -= 1;
        }
    }
}
