using UnityEngine;
using System.Collections;

public class LastPlayerSighting : MonoBehaviour {

    public Vector3 position = new Vector3(1000f, 1000f, 1000f);
    public Vector3 resetPosition = new Vector3(1000f, 1000f, 1000f);
    public float lightHighIntensity = 0.25f;
    public float lightLowIntensity = 0f;
    public float fadeSpeed = 7f;
    public float musicFadeSpeed = 1f;

    private AlarmLight alarmScript;
    private Light mainLight;
    private AudioSource music;
    private AudioSource panicAudio;
    private AudioSource[] sirens;
    private const float muteVolume = 0f;
    private const float normalVolume = 0.8f;


    void Awake ()
    {
        alarmScript = GameObject.FindWithTag(Tags.AlarmLight).GetComponent<AlarmLight>();
        mainLight = GameObject.FindWithTag(Tags.MainLight).GetComponent<Light>();
        music = GetComponent<AudioSource>();
        panicAudio = transform.Find("secondarty_music").GetComponent<AudioSource>();
        GameObject[] sirenGameObjects = GameObject.FindGameObjectsWithTag(Tags.Siren);
        sirens = new AudioSource[sirenGameObjects.Length];
        for(int i = 0; i < sirens.Length; ++i)
        {
            sirens[i] = sirenGameObjects[i].GetComponent<AudioSource>();
        }
     }

	void Start () {
	    
	}
	
	void Update () {
	
	}
}
