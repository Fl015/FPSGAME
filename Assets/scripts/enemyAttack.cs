using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAttack : MonoBehaviour
{

    private enemyMovement enemymovement;
    public Transform player;
    public float attackRange = 10f;

    public Material attackMaterial;
    public Material defaultMaterial;
    private Renderer rend;

    private bool foundPlayer;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        enemymovement = GetComponent<enemyMovement>();
        rend = GetComponent<Renderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, player.position) <= attackRange)
        {
            rend.sharedMaterial = attackMaterial;
            enemymovement.agent.SetDestination(player.position);
            foundPlayer = true;
        }
        else if (foundPlayer == true)
        {
            rend.sharedMaterial = defaultMaterial;
            enemymovement.newLocation();
            foundPlayer = false;
        }
    }
}
