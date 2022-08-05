using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Text textScore;
    public int scorePoint;
    public string texto;
    private void Start()
    {
        scorePoint = 0;
        texto = textScore.text;
    }
    void Update()
    {
        textScore.text = texto + scorePoint.ToString();
    }
}
