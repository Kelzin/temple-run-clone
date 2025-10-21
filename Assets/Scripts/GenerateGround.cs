using UnityEngine;

public class GenerateGround : MonoBehaviour
{
    [SerializeField] private GameObject spawnPivot;

    private bool hasSpawned = false;

    void CreateGround(Collider other)
    {
        if (other.CompareTag("Player") && !hasSpawned)
        {
            GroundController.Instance.CreateGround(spawnPivot);
            //Debug.Log("Ground created Entered at " + spawnPivot.transform.position.ToString());

            Destroy(spawnPivot);

            hasSpawned = true;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        CreateGround(other);
    }
}
