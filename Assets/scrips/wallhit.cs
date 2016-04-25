using UnityEngine;
using System.Collections;

public class wallhit : MonoBehaviour {
    public AudioSource hitsound;
	// Use this for initialization
	void Start () {
        hitsound = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("bullet"))
        {

            hitsound.Play();
        }
    }
}
