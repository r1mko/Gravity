using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect : MonoBehaviour
{
    [SerializeField] private AudioSource touchSound;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        touchSound.Play();
    }
}
