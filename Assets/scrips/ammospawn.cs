using UnityEngine;
using System.Collections;

public class ammospawn : MonoBehaviour {

    public GameObject[] spawnpoints2;
    public GameObject ammo;
    public GameObject[] ammos;

    void Start()
    {
        spawnpoints2 = GameObject.FindGameObjectsWithTag("ammospawn");
    }

    // Update 
    void Update()
    {
       
        ammos = GameObject.FindGameObjectsWithTag("Ammo");
        if (ammos.Length >= 2)
        {

        }
        else
        {
            InvokeRepeating("spawnammo",10, 20f);
        }
    }
    void spawnammo()
    {
        int spawnpos = Random.Range(0, (spawnpoints2.Length - 0));

        
        Instantiate(ammo, spawnpoints2[spawnpos].transform.position, transform.rotation);
        CancelInvoke();
    }
}
