using UnityEngine;

public class EnemyFSM : MonoBehaviour
{
    public Transform player;
    public float speed = 5f;
    public float attackDistance = 10f;

    enum State { Idle, Chase, Attack }
    State currentState;

    void Update()
    {
        float dist = Vector3.Distance(transform.position, player.position);

        switch (currentState)
        {
            case State.Idle:
                if (dist < 20f)
                    currentState = State.Chase;
                break;

            case State.Chase:
                transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);

                if (dist < attackDistance)
                    currentState = State.Attack;
                break;

            case State.Attack:
                transform.LookAt(player);

                if (dist > attackDistance)
                    currentState = State.Chase;
                break;
        }
    }
}