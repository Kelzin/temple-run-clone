using UnityEngine;

public class EraseGround : MonoBehaviour
{
    
    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject, 0f);
    }
}
