using UnityEngine;

public class GenerateGround : MonoBehaviour
{

    [SerializeField] private GameObject[] groundPrefabs;
    [SerializeField] private GameObject spawnOrigin;
    private int index;

    private bool hasSpawned = false;

    void CreateGround(Collider other, int index)
    {
        if (other.CompareTag("Player") && !hasSpawned)
        {
            Instantiate(groundPrefabs[index], spawnOrigin.transform.position, Quaternion.identity);
            Debug.Log("Ground created Entered at " + spawnOrigin.transform.position.ToString());

            Destroy(spawnOrigin);

            hasSpawned = true;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        CreateGround(other,index = Random.Range(0, groundPrefabs.Length));
    }
}
