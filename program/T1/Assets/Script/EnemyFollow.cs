using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{

    private GameObject player;
    private PlayerHealth playerSave;
    private EnemyHealth enemyHealth;
    
    private NavMeshAgent agent;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        if (player != null) playerSave = player.GetComponent<PlayerHealth>();

        agent = GetComponent<NavMeshAgent>();
        enemyHealth = GetComponent<EnemyHealth>();

    }

    // Update is called once per frame
    void Update()
    {
        
        if (player != null && !playerSave.playerDie && !enemyHealth.enemyDie)
        {
            agent.SetDestination(player.transform.position);
        }
    }
}
