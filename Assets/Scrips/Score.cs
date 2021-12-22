using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public int GameScore { get; set; }
    // Update is called once per frame
    void Update()
    {
        scoreText.text = "SCORE: " + GameScore.ToString();
    }
}
