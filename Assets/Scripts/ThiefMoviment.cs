using UnityEngine;

public class ThiefMoviment : MonoBehaviour
{

    [SerializeField] private GameObject thiefInstance;
    [SerializeField] private Transform thiefSpawnPoint;
    [SerializeField] private float maxY = 5f;
    [SerializeField] private float minY = -5f;
    [SerializeField] private float maxX = 5f;
    [SerializeField] private float minX = -5f;

    public static ThiefMoviment Instance { get; private set; }

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
    public void MoveThief()
    {
        Vector3 newPosition = thiefInstance.transform.position;
        newPosition.x =  Random.Range(minX, maxX);
        newPosition.y = Mathf.Clamp(newPosition.y, minY, maxY);
        thiefInstance.transform.position = newPosition;
    }

}
