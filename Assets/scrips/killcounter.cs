using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class killcounter : MonoBehaviour {
    public float kills = 0;
    public Text killtext;

    void Update()
    {
        killtext.text = "kills: " + kills;
    }
}
