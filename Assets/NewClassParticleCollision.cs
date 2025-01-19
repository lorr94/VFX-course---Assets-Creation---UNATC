using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewClassParticleCollision : MonoBehaviour
{

    public ParticleSystem myParticleSystem;

    private void OnParticleCollision(GameObject other)
    {
        Debug.Log("Particle hit wall.");

        if (other.CompareTag("EnemyGunNR1"))
        {
            Debug.Log("Enemy 1 hit wall.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            Debug.Log("K key pressed.");
            var emission = myParticleSystem.emission;
            emission.rateOverDistance = 5f;

        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            Debug.Log("L key pressed.");
            var emission = myParticleSystem.emission;
            emission.rateOverDistance = 0f;

        }
    }
}
