using UnityEngine;
using System.Collections;

public class bullets : MonoBehaviour {

    private float _speed;
	
    void Start()
    {
        Destroy(gameObject, 3f);
    }

	void Update () {
        transform.Translate(Vector3.up * _speed * Time.deltaTime);
	}

    public void setspeed(float value)
    {
        _speed = value;
    }
    void OnTriggerEnter(Collider other) { 
        if (other.CompareTag("Enemy"))
        {
            
            Destroy(gameObject);
        }
        if (other.CompareTag("wall"))
        {
            
            Destroy(gameObject);
        }
    }

}
