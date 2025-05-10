using UnityEngine;

public class EnemyShooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float fireCooldown = 2f;
    public float fireRange = 25f;

    private float lastFireTime = 0f;
    private GameObject target;

    void Update()
    {
        target = FindNearestTarget();
        if (target != null)
        {
            float dist = Vector3.Distance(transform.position, target.transform.position);
            if (dist <= fireRange && Time.time - lastFireTime >= fireCooldown)
            {
                Shoot(target.transform);
                lastFireTime = Time.time;
            }
        }
    }

    void Shoot(Transform target)
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

    GameObject FindNearestTarget()
    {
        GameObject[] possibleTargets = GameObject.FindGameObjectsWithTag("Player"); // 또는 "Ally" 로 바꾸면 npc 공격 가능
        GameObject nearest = null;
        float minDist = Mathf.Infinity;

        foreach (GameObject t in possibleTargets)
        {
            float d = Vector3.Distance(transform.position, t.transform.position);
            if (d < minDist)
            {
                minDist = d;
                nearest = t;
            }
        }

        return nearest;
    }
}
