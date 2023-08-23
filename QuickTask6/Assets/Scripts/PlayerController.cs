using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    private BoxCollider2D boxCollider;
    public GameObject gameOver;
    public GameObject winner;
    public bool isDead = false;
    public float xInput;
    public float force;
    public float speed;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
    }
    void Update()
    {
        if (isDead == false)
        {
            xInput = Input.GetAxis("Horizontal");
            transform.Translate(Vector2.right * Time.deltaTime * speed * xInput);
            if (Input.GetKey(KeyCode.Space))
            {
                rigidBody.velocity = Vector2.zero;
                rigidBody.AddForce(new Vector2(0, force * 100));
            }
        }
        else
        {
            Debug.Log("Game Over!");
            gameOver.SetActive(true);
            Destroy(gameObject);
        }
        if (transform.position.x > 10)
        {
            Debug.Log("Winner!");
            winner.SetActive(true);
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter2D()
    {
        if (isDead == false)
        {
            isDead = true;
        }
    }
}
