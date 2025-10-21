using UnityEngine;

public class GroundController : MonoBehaviour
{
    private static GroundController _instance;
    
    public static GroundController Instance { get { return _instance; } }
    
    
    [SerializeField] private float groundLength;
    
    [SerializeField] private GameObject[] groundPrefabs;
    
    void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        } else {
            _instance = this;
        }
    }
    
    public void CreateGround(GameObject pivot)
    {
        int index = Random.Range(0, groundPrefabs.Length);
        // Do some funky logic here to figure out the next ground
        Instantiate(groundPrefabs[index], pivot.transform.position + pivot.transform.forward * groundLength/2, pivot.transform.rotation);
    }
}
