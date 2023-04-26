using UnityEngine;
public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float jumpForce;
    [SerializeField] bool isGrounded = true;

    Rigidbody2D rb;
    GameObject gamemanager;
    public SceneController scenecontroller;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        gamemanager = GameObject.Find("Game Manager");
        scenecontroller = gamemanager.GetComponent<SceneController>();

    }
    void Update()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Death"))
        {
            scenecontroller.LoadGameOver();
        }

        if (collision.gameObject.CompareTag("Victory"))
        {
            scenecontroller.LoadVictory();
        }
    }
}
