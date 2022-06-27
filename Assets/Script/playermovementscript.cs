using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovementscript : MonoBehaviour 
{
    public float MovementSpeed = 1;
    public float JumpForce = 1;
    public AudioSource fonteAudio;
    public AudioClip[] sons;

    private Rigidbody2D _rb;


    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        fonteAudio = this.GetComponent<AudioSource>();
    }

    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;


        if (!Mathf.Approximately(0, movement))
            transform.rotation = movement > 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;

        if (Input.GetKeyDown(KeyCode.W) && Mathf.Abs(_rb.velocity.y) < 0.001f)
        {
            _rb.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
            fonteAudio.PlayOneShot(sons[1]);
        }
}

























}

