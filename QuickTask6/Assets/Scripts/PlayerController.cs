using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    private PlayerController playerController;
    public float xInput;
    public float speed;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        playerController = GetComponent<PlayerController>();
    }
    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * Time.deltaTime * speed * xInput);
    }
}
