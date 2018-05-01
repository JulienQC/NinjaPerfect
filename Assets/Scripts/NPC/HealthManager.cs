using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class HealthManager : MonoBehaviour {

    public int lifePoints;

    private delegate void CollisionHandler(GameObject collision);
    private CollisionHandler m_handler;

    private void Start()
    {
        if (gameObject.CompareTag("Player"))
            m_handler = PlayerCollisionHandler;
        else
            m_handler = EnemyCollisionHandler;
    }

    private void OnCollisionEnter(Collision collision)
    {
        --lifePoints;
        m_handler(collision.gameObject);
    }

    private void PlayerCollisionHandler(GameObject collision)
    {

    }

    private void EnemyCollisionHandler(GameObject collision)
    {
        if (lifePoints == 0)
            Destroy(gameObject);
    }
}
