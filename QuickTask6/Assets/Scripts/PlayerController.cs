using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    private PlayerController playerController;
    public bool isDead = false;
    public float xInput;
    public float force;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        playerController = GetComponent<PlayerController>();
    }
    void Update()
    {
        if (isDead == false)
        {
            xInput = Input.GetAxis("Horizontal");
            transform.Translate(Vector2.right * Time.deltaTime * force * xInput);
            if (Input.GetKey(KeyCode.Space))
            {
                rigidBody.velocity = Vector2.zero;
                rigidBody.AddForce(new Vector2(0, force * 100));
            }
        }
    }
}
