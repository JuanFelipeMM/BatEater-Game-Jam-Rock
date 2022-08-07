using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    public float horizontal;
    public float speed = 2;
    public Animator animator;
    Rigidbody playerRb;
    private SpriteRenderer sprite;
    public bool fimJogo = false;
    public float xRange = 2.0f;
    public bool facingRight=true;

    // Start is called before the first frame update
    void Start()
    {
       playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
            horizontal = Input.GetAxis("Horizontal");
            animar(); 
    }

    private void FixedUpdate()
    {
            mover();
    }
    void mover()
    {
        //movimento

        transform.Translate(Vector3.right * horizontal * speed * Time.deltaTime);
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z); ;
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z); ;
        }
    }

    public void animar()
    {
            if (horizontal == 0)
            {
                GetComponent<ControladorAnimJogador>().playAnimation("Idle");
            }
            else
            {
                if (horizontal > 0 && !facingRight)
                {
                    print("Entrou>0");
                    Flip();
                }
                if (horizontal < 0 && facingRight)
                {
                    print("Entrou<0");
                    Flip();
                }
                GetComponent<ControladorAnimJogador>().playAnimation("Walking");
            }
    }

    void Flip()
    {
        Vector2 currentScale = gameObject.transform.localScale; 
        currentScale.x *= -1; gameObject.transform.localScale = currentScale;
        facingRight = !facingRight;
    }
}
