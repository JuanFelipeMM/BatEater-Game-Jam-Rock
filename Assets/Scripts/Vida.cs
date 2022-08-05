using UnityEngine.UI;
using UnityEngine;

public class Vida : MonoBehaviour
{
    public int health =3;
    public int maxHealth =3;
    public Image[] hearts;
    public Sprite heartSprite;

    private void Start()
    {
       
    }

    void Update()
    {
        
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i<health)
            {
                hearts[i].sprite = heartSprite;
            }
            else
            {
                hearts[i].enabled = false;
            }

            /*if (i< maxHealth) {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }*/
        }

        if (health<=0) {
            GameOver.isGameOver = true;
            Destroy(this.gameObject); }
    }
}
