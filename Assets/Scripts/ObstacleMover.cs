using UnityEngine;

public class ObstacleMover : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float obstacleSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.transform.Translate(Vector3.back * obstacleSpeed * Time.deltaTime);
    }
}
