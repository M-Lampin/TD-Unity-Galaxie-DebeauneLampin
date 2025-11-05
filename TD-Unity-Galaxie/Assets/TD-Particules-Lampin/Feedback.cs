using UnityEngine;

public class Feedback : MonoBehaviour
{
    ParticleSystem ParticleSystem;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ParticleSystem = GetComponent<ParticleSystem>();
        ParticleSystem.Pause();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1)) 
        { 
            ParticleSystem.Play();
                }
    }
}
