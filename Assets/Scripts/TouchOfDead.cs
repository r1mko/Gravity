using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TouchOfDead : MonoBehaviour
{
    public GravityController gravityController;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gravityController.PlayerDeath();
        StartCoroutine(RestartLevel());
    }

    IEnumerator RestartLevel()
    {
        yield return new WaitForSeconds(0.85f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
