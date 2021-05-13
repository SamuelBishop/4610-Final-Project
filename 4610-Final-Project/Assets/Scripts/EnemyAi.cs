using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAi : MonoBehaviour
{
    [SerializeField] Transform target;
    NavMeshAgent navMeshAgent;
    [SerializeField] float AttackCooldown = 4.0f;
    int damage = 1;
    public int delayBetweenAttacks = 50;
    public float lastAttackDate;

    // Placeholder
    float distanceToTarget = Mathf.Infinity;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        lastAttackDate = Time.time;
        // var dispDamage = target.GetComponent<DisplayDamange>();
        // dispDamage.Start();
    }

    // Update is called once per frame
    void Update()
    {
        // Logic for attack
        distanceToTarget = Vector3.Distance(target.position, transform.position);
        EngageTarget();
    }

    private void EngageTarget()
    {
        if (distanceToTarget >= navMeshAgent.stoppingDistance)
        {
            ChaseTarget();
        }
        else if (distanceToTarget <= navMeshAgent.stoppingDistance)
        {
            if( (Time.time - lastAttackDate > delayBetweenAttacks)){
                AttackTarget();
            }
        }
    }

    private void ChaseTarget(){
        navMeshAgent.SetDestination(target.position);
    }

    private void AttackTarget(){
        var dispDamage = target.GetComponent<DisplayDamage>();
        var health = target.GetComponent<Health>();
        lastAttackDate = Time.time;
        StartDamage();
        dispDamage.ShowDamageImpact();
        Debug.Log("Player Attacked: Health = " + health.currentHealth);
    }

    // Part of attack
    public void StartDamage()
    {
        StartCoroutine(DoDamage());
    }

    // Timer does not work yet
    IEnumerator DoDamage()
    {
        var health = target.GetComponent<Health>();
        health.TakeDamage(damage);
        yield return new WaitForSeconds(AttackCooldown);
    }
}
