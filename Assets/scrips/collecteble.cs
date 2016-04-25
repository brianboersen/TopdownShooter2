using UnityEngine;
using System.Collections;

public class collecteble : MonoBehaviour {

    public Vector3 rotation;
    public float rotationSpeed;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotation * rotationSpeed * Time.deltaTime);
    }
}
