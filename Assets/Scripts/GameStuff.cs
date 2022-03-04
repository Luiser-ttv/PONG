using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameStuff : MonoBehaviour
{
    const float ImpulseForceRange = 1f;
    const float MinImpulseForce = 3f;

    int ScoreLeftData = 0;
    int ScoreRightData = 0;

    private Vector2 impulso = new Vector2(MinImpulseForce, MinImpulseForce);

    public GameObject Ball;
    public GameObject WallLeft;
    public GameObject WallRight;
    public TextMeshProUGUI ScoreLeftText;
    public TextMeshProUGUI ScoreRightText;
    public TextMeshProUGUI WinnerText;

    Rigidbody2D rb2DBall;

    void Start()
    {
        rb2DBall = Ball.GetComponent<Rigidbody2D>();
        rb2DBall.AddForce(Random.insideUnitCircle * ImpulseForceRange + impulso, ForceMode2D.Impulse);
    }

    void Update()
    {
        float PositionWallL = WallLeft.transform.position.x;
        float PositionWallR = WallRight.transform.position.x;
        float PositionBall = Ball.transform.position.x;
        

       
        if (ScoreRightData == 11)
        {
            StopAllCoroutines();
            WinnerText.text = "Right player is the winner!";
            Ball.SetActive(false);
        }
        else if (ScoreLeftData == 11)
        {
            StopAllCoroutines();
            WinnerText.text = "Left player is the winner!";
            Ball.SetActive(false);
        }
        else
        {
            if (PositionWallL > PositionBall)
            {
                Ball.transform.position = new Vector2(0, 0);
                ScoreRightData += 1;
                ScoreRightText.text = ScoreRightData.ToString();

            }
            else if (PositionWallR < PositionBall)
            {
                Ball.transform.position = new Vector2(0, 0);
                ScoreLeftData += 1;
                ScoreLeftText.text = ScoreLeftData.ToString();
                
            }
        }
    }
}
