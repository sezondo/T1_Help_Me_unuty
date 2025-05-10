using UnityEngine;

public class AllyActivator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public bool isActivated {get; private set;} = false; // 외부에서 접근가능 단 값 변경 불가능

    void OnTriggerEnter(Collider other)
    {
        if (!isActivated && other.CompareTag("Player"))
        {
            Debug.Log("접촉완료");
            isActivated = true;
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
