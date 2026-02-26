using UnityEngine;

public class ThiefMoviment : MonoBehaviour
{

    [SerializeField] private GameObject thiefInstance;
    [SerializeField] private Transform thiefSpawnPoint;
    [SerializeField] private Transform targetPosition;
    [SerializeField] private float maxZ = 5f;
    [SerializeField] private float minZ = -5f;
    
    [SerializeField] private float maxX = 5f;

    public static ThiefMoviment Instance { get; private set; }

    public float speed = 5.0f; 

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    // Update is called once per frame

    public void MoveTowardsTargetAndClamp()
    {
        
        float step = speed * Time.deltaTime;

        Vector3 nextPosition = Vector3.MoveTowards(thiefSpawnPoint.position, targetPosition.position, step);


        nextPosition.x -= Random.Range(0, maxX);
        nextPosition.z = Random.Range(minZ, maxZ); 

        transform.position = nextPosition;

        if (thiefSpawnPoint.position.x <= targetPosition.position.x)
        {
            Debug.Log("Thief reached the target position!");
        }
    }

}
