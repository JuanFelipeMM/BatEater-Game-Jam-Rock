using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerPlateia : MonoBehaviour
{
    float intervalo;
    float comeco;
    public GameObject morcegoPrefab;
    public GameObject lixoPrefab;
    BoxCollider2D m_Collider;
    public float limitePos;
    private float xMin;
    private float yMin;
    private float xMax;
    private float yMax;
    int numRand;
    void Start()
    {
        intervalo = Random.Range(1, 4);
        comeco = Random.Range(1, 4);
        limitePos = 0.5f;
        m_Collider = GetComponent<BoxCollider2D>();
        xMin = m_Collider.bounds.min.x+ limitePos;
        yMin = m_Collider.bounds.min.y+ limitePos;
        xMax = m_Collider.bounds.max.x- limitePos;
        yMax = m_Collider.bounds.max.y- limitePos;

        InvokeRepeating("spawn", comeco, intervalo);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        
    }



    void spawn()
    {
        this.intervalo = Random.Range(1, 6);
        numRand = Random.Range(0, 100);
        if (numRand>=50){
            Instantiate(morcegoPrefab, pegarPosicaoAleatoria(), transform.rotation);
        }
        else{
            Instantiate(lixoPrefab, pegarPosicaoAleatoria(), transform.rotation);
        }
        
    }

    Vector2 pegarPosicaoAleatoria()
    {
        return new Vector2(Random.Range(xMin,xMax),Random.Range(yMin, yMax));
    }
}
