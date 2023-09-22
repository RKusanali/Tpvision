using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject worldObject;
    public AudioSource collisionSound;
    public GameObject fx;

    void Start()
    {
        worldObject = GameObject.Find("World");
        collisionSound = GameObject.Find("bruitage").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    { // OnCollisionEnter 
        worldObject.SendMessage("AddHit");
        if (other.tag == "Player")
        {
            if (collisionSound)
            {
                collisionSound.Play();
            }
            Instantiate(fx, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
