using TMPro;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private float ballSpeed = 10f;
    [SerializeField] private Rigidbody2D rb;
    public int player2Score = 0;
    public int player1Score = 0;
    public TextMeshProUGUI p1Score;
    public TextMeshProUGUI p2Score;
    private Vector2 startPosition;


    private void Start()
    {
        startPosition = transform.position;
        Launch();
    }
    private void Update()
    {

    }

    private void Launch()
    {
        int randomNumberX = Random.Range(0, 2);
        float x;

        if (randomNumberX == 0)
        {
            x = -1;
        }
        else
        {
            x = 1;
        }

        int randomNumberY = Random.Range(0, 2);
        float y;

        if (randomNumberY == 0)
        {
            y = -1;
        }
        else
        {
            y = 1;
        }

        float xMovement = x * ballSpeed;
        float yMovement = y * ballSpeed;
        rb.linearVelocity = new Vector3(xMovement, yMovement);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player1Goal"))
        {
            player2Score++;
            p2Score.text = player2Score.ToString();
            ResetBall();
        }
        if (collision.CompareTag("Player2Goal"))
        {
            player1Score++;
            p1Score.text = player1Score.ToString();
            ResetBall();
        }

    }

    private void ResetBall()
    {
        transform.position = startPosition;
        Launch();
    }



}
