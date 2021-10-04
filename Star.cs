using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Star : MonoBehaviour
{
    public MenuLevel ml;
    public Data dt;
    AudioSource starCollect;
    private void Start()
    {
        starCollect = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            starCollect.Play();
            Destroy(gameObject, 0.15f);
        }
    }
}
