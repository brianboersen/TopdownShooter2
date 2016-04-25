using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playerShooting : MonoBehaviour
{
    public AudioClip shootsound;
    public AudioClip reloadsound;
    public AudioClip picupsound;
    public AudioSource sound;
    public bullets bullets1;
    public Transform muzzle;

    public Text ammoText;
    public float mag = 9;
    public float cap = 18;
    public bool eenkeer = true;

    public float bulletspeed;
    public float firerate = 0.1f;
    public float nextfire = 0.0f;


    void Awake()
    {
        sound = GetComponent<AudioSource>();
    }
    void Update()
    {
        ammoText.text = mag + "/" + cap + " snot";

        if (Input.GetMouseButton(0) && Time.time > nextfire && mag > 0)
        {
            Shoot();
            nextfire = Time.time + firerate;
            mag -= 1;
        }
        if (mag <= 0 && eenkeer == true && cap > 0)
        {
            sound.PlayOneShot(reloadsound);
            Invoke("reload", 2f);
            eenkeer = false;
        }
    }
    private void Shoot()
    {
        sound.PlayOneShot(shootsound);
        bullets newbullets = Instantiate(bullets1, muzzle.position, muzzle.rotation) as bullets;
        newbullets.setspeed(bulletspeed);
    }
    void reload()
    {
        
            cap -= 9;
            mag += 9;
            eenkeer = true;
       
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ammo"))
        {
            sound.PlayOneShot(picupsound);
            cap += 45;
            Destroy(other.gameObject);
        }
    }
}