using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float jumpHeight;
    public float moveSpeed;
    private Rigidbody2D rb;
    private bool isJumping = false;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
	void Update()
    {
        jump();
    }

    void jump()
    {
        if(!isJumping)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                print("jump");
                rb.velocity = new Vector2(moveSpeed * Time.deltaTime, 0);
            }
        }
    }
}
