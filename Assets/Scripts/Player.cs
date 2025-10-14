using UnityEngine;

public class Player : MonoBehaviour
{
    private Animator animator;
    private Rigidbody rigidbody;
    private bool jumping;
    [SerializeField] private float jumpForce;
    [SerializeField] private float velocity = 2;
    

    void Start()
    {
        jumping = false;
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumping = true;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Slide();
        }

        float move = Input.GetAxis("Horizontal");
        rigidbody.linearVelocity = new Vector3(move * velocity, rigidbody.linearVelocity.y, 0);
        //Vector3.right * move * velocity;
    }

    void FixedUpdate()
    {
        if (jumping && Mathf.Abs(rigidbody.linearVelocity.y) < 0.05)
        {
            jumping = false;
            animator.SetBool("Jump", true);
            rigidbody.linearVelocity = Vector3.up * jumpForce;
        }
    }

    public void Slide()
    {
        animator.SetBool("Slide", true);
        transform.rotation = Quaternion.Euler(0, 90, 0);
    }

    public void StopSlide()
    {
        animator.SetBool("Slide", false);
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ground"))
        {
            animator.SetBool("Jump", false);
        }
        if (other.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
        }
    }
}
