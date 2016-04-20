using UnityEngine;
using System.Collections;

public class GameOverController : MonoBehaviour {

    PlayerHealth playerHealth;
    GameObject player;
    Animator anim;
    bool isDead = false;
	// Use this for initialization

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
        anim = GetComponent<Animator>();
    }
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (playerHealth.currentHealth <= 0 && !isDead)
        {
            anim.SetTrigger("GameOver");
            isDead = true;
        }
    }
}
