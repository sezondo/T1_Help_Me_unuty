using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMove : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void Change(int i){
        SceneManager.LoadScene(i);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
