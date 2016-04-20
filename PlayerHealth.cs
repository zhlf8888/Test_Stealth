using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

    public int startingHealth = 100;
    public int currentHealth;
    public Image damageImage;
    Color flashColor = new Color(1f, 0f, 0f, 0.5f);
    public float flashSpeed = 20f;

    bool isDamaged = false;

    void Awake()
    {
        currentHealth = startingHealth;
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (isDamaged)
        {
            damageImage.color = flashColor;
        }
        else
        {
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }
        isDamaged = false;
	}

    public void TakeDamage(int damagePoint)
    {
        isDamaged = true;
        currentHealth -= damagePoint;
        Debug.Log("hurt, current health" + currentHealth);
    }
}
