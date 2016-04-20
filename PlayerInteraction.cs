using UnityEngine;
using System.Collections;

public class PlayerInteraction : MonoBehaviour {

    //GameObject player;
    public float range = 5f;

    Ray sight;
    RaycastHit sightHit;
    int shootableMask;
    FireController firecontroller;
    LineRenderer line;


    void Awake()
    {
        //player = GameObject.FindGameObjectWithTag("Player");
        shootableMask = LayerMask.GetMask("Interact");
    }
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Fire1"))
        {
            interact();
        }
	}

    void interact()
    {
        sight.origin = gameObject.transform.position;
        sight.direction = gameObject.transform.forward;
        if (Physics.Raycast(sight, out sightHit, range, shootableMask))
        {
            firecontroller = sightHit.collider.GetComponent<FireController>();
            firecontroller.PutOut();
        }
    }
}
