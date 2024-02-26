using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Bumper : MonoBehaviour
{
    public Collider bola;
    public float multiplier;
    public float score;

    public AudioManager audioManager;
    public VFXManager vfxManager;
    public ScoreManager scoreManager;

    private Renderer renderer;
    private Animator animator;


    private void Start()
    {
        renderer = GetComponent<Renderer>();
        animator = GetComponent<Animator>();

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == bola)
        {
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplier;

            //Animation
            animator.SetTrigger("HIt");

            //PlaySFX
            audioManager.PlaySFX(collision.transform.position);

            //PlayVFX
            vfxManager.PlayVFX(collision.transform.position);

            //tambah score saat menabrak bumper
            scoreManager.AddScore(score);
        }
    }
}
