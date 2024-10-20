using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCameraShake : MonoBehaviour
{
    public CameraShake cameraShake;
    [SerializeField] private float durationShake = 0.2f;
    [SerializeField] private float magnitudeShake = 0.3f;
    [SerializeField] private AudioSource playerDeathSound;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        playerDeathSound.Play();
        StartCoroutine(cameraShake.Shake(durationShake, magnitudeShake));
    }

}
