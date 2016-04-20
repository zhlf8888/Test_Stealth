using UnityEngine;
using System.Collections;

public class GroundController : MonoBehaviour {
    GameObject player;
    PlayerHealth playerHealth;
    Animator anim;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
        anim = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
       
        if (other.tag == "Player")
        {
            playerHealth.currentHealth = 0;
        }
    }
}
