using UnityEngine;
using System.Collections;

public class enemyspawn : MonoBehaviour {

    public GameObject[] spawnpoints;
    public GameObject Enemy;


	void Start () {
        spawnpoints = GameObject.FindGameObjectsWithTag("Spawn");
	}
	
	// Update is called once per frame
	void Update () {
        GameObject[] enemies;
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        if(enemies.Length >= 10)
        {
            
        }
        else
        {
            InvokeRepeating("spawnenemies", 1, 2f);
        }
	}
    void spawnenemies()
    {
        int spawnpos = Random.Range(0, (spawnpoints.Length - 0));

        Instantiate(Enemy, spawnpoints[spawnpos].transform.position,transform.rotation);
        CancelInvoke();
    }
}
