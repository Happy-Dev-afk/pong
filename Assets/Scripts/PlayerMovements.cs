using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 8f;
    [SerializeField] private GameObject player1;
    [SerializeField] private GameObject player2;
    

    private void Update()
    {
        
        float verticalMovement = Input.GetAxis("Vertical");
        float yMovement = verticalMovement * moveSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.UpArrow))
        {

            player2.transform.Translate(new Vector2(0f, yMovement));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {

            player2.transform.Translate(new Vector2(0f, yMovement));
        }
        if (Input.GetKey(KeyCode.W))
        {

            player1.transform.Translate(new Vector2(0f, yMovement));
        }
        if (Input.GetKey(KeyCode.S))
        {

            player1.transform.Translate(new Vector2(0f, yMovement));
        }

    }
}
