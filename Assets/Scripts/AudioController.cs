using UnityEngine;

public class AudioController : MonoBehaviour

{

    public GameObject Mortis;
    public GameObject Jump;
    public static AudioController instance;
    

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
          Jump.SetActive(false);
          Jump.SetActive(true);
        }

    }
}
