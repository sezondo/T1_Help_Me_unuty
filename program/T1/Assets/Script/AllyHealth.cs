using UnityEngine;
using UnityEngine.UI;

public class AllyHealth : MonoBehaviour
{

    public float hp = 100f;
    public RawImage imgBar;

    public void SetHp(int value){
        hp = value;
        imgBar.transform.localScale = new Vector3(hp/100.0f,1,1);
    }
    public void TakeDamage(float damage)
    {
        Debug.Log("아군 대미지 입음");

        hp -= damage;
        if (hp <= 0f)
        {
            Destroy(gameObject);
        }
        imgBar.transform.localScale = new Vector3(hp/100.0f,1,1);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
