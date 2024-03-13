using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSteps : MonoBehaviour
{
    public AudioClip footstepSound;
    public AudioSource audioSource;

    CharacterController characterController;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (characterController.isGrounded && characterController.velocity.magnitude > 0)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.clip = footstepSound;
                audioSource.Play();
            }
        }
    }
}
