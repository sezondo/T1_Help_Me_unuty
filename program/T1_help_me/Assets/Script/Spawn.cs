using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject prefab;
    public float time = 3f ;
    public Transform[] point;
    public int max;
    public int count;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("Create", time, time);
    }
    void Create(){
        if (count >= max)
        {
            return;
        }
        count++;
        int i = Random.Range(0, point.Length);
        Instantiate(prefab, point[i]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
