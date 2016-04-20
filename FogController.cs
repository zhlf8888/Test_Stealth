using UnityEngine;
using System.Collections;

public class FogController : MonoBehaviour {

    public int damage = 20;
    public float timeBetweenDamage = 0.5f;

    GameObject player;
    PlayerHealth playerHealth;
    float timer = 0;

	// Use this for initialization

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
    }
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
	}

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && !Input.GetButton("Fire3") && timer >= timeBetweenDamage && Time.timeScale != 0)
        {
            timer = 0f;
            playerHealth.TakeDamage(damage);
        }
    }
}
