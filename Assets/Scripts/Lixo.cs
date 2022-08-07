using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lixo : MonoBehaviour
{
    bool cima;
    bool baixo;
    public float speed = 3f;
    public GameObject sonsLixo;

    // Start is called before the first frame update
    void Start()
    {
        transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0.3f);
        transform.GetChild(0).gameObject.GetComponent<Animator>().SetBool("Caindo", false);
        cima = true;
        baixo = false;
    }

    // Update is called once per frame
    void Update()
    {
        respawn();
        condDestroy();
    }

    private void FixedUpdate()
    {
        mover();
    }

    void mover()
    {
        if (baixo == true)
        {
            transform.Translate(Vector2.down * Time.deltaTime * speed);
        }
        if (cima == true)
        {
            transform.Translate(Vector2.up * Time.deltaTime * speed);
        }

    }

    void respawn()
    {
        if (transform.position.y >= 7)
        {
            GetComponent<Transform>().position = (new Vector2(Random.Range(-4f, 4f), 6.5f));
            transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
            transform.GetChild(0).gameObject.GetComponent<Animator>().SetBool("Caindo", true);
            this.baixo = true;
            this.cima = false;
        }
    }
    void condDestroy()
    {
        if (transform.position.y <= -7)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && baixo == true)
        {
            if (collision.GetComponent<Vida>().health>0) { 
                collision.GetComponent<Vida>().health -= 1;
                
            }
            Instantiate(sonsLixo);
            Destroy(this.gameObject);
        }

    }

}
