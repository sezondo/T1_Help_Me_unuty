using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public RawImage imgBar;
    int hp = 100;

    public void Damage(int amount){
        if (hp <= 0)
        {
            return;
        }

        hp -= amount;
        imgBar.transform.localScale = new Vector3(hp/100.0f, 1,1);
        if (hp<=0)
        {
            GetComponent<Animator>().SetTrigger("Death");
            GetComponent<NavMeshAgent>().enabled = false;

            Destroy(gameObject,2);
            GameObject.Find("GameManager").GetComponent<Spawn>().count--;
        }
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
