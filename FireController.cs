using UnityEngine;
using System.Collections;

public class FireController : MonoBehaviour {
    GameObject Player;
    PlayerHealth playerHealth;
    public int damage = 10;

	// Use this for initialization

    void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = Player.GetComponent<PlayerHealth>();
    }
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerHealth.TakeDamage(damage);
            Debug.Log("take damage, current health" + playerHealth.currentHealth);
        }
    }

    public void PutOut()
    {
        Debug.Log("the fire has been put out");
        Destroy(gameObject);
    }
}
