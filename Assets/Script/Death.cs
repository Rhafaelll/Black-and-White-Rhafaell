using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public GameObject Player;
    public GameObject Spawn;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            DeathCounter.DeathNum += 1;
            Player.transform.position = Spawn.transform.position;
        }
    }
}
