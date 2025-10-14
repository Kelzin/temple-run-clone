using UnityEngine;

public class GenerateGround : MonoBehaviour
{

    [SerializeField] private GameObject[] groundPrefabs;
    [SerializeField] private GameObject spawnOrigin;

    private bool hasSpawned = false;

    void CreateGround(Collider other)
    {
        if (other.CompareTag("Player") && !hasSpawned)
        {
            int index = Random.Range(0, groundPrefabs.Length);
            Instantiate(groundPrefabs[0], spawnOrigin.transform.position, Quaternion.identity);
            Debug.Log("Ground created Entered at " + spawnOrigin.transform.position.ToString());

            Destroy(spawnOrigin);

            hasSpawned = true;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        CreateGround(other);
    }
}
