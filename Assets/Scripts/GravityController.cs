using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GravityController : MonoBehaviour
{
    [SerializeField] private GameObject deathParticle;
    [SerializeField] private AudioSource changeSound;


    void Start()
    {
        if (Physics2D.gravity.y > 0f)
        {
            Physics2D.gravity = -Physics2D.gravity;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Space))
        {
            Physics2D.gravity = -Physics2D.gravity;
            changeSound.Play();
        }
    }

    public void PlayerDeath()
    {
        GameObject explosion = Instantiate(deathParticle, transform.position, transform.rotation);
        Destroy(gameObject);
        Destroy(explosion, 0.75f);
    }
}
