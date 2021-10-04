using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class Player : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Transform Spawnpoint, player;
    public MenuLevel ml;
    public Data dt;
    AudioSource playerDead;
    void Start()
    {
      playerDead  = GetComponent<AudioSource>();
    }
    void Update()
    {
        Movement();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Black"))
        {
            player.transform.position = Spawnpoint.transform.position;
            dt.life--;
            playerDead.Play();
        }
        if (collision.gameObject.CompareTag("Brown"))
        {
            player.transform.position = Spawnpoint.transform.position;
            ml.level++;
            dt.spawn = true;

            if (ml.level == -1)
            {
                ml.level = 0;
            }
        }
        if (collision.gameObject.CompareTag("Star"))
        {
            dt.starCount++;
        }
    }
    void Movement()
    {
        float vertical = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;
        float horizontal = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        transform.Translate(horizontal, vertical, 0);

        if (Input.GetMouseButton(1))
        {
            ml.level++;
        }
    }
}
