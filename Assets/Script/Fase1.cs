using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fase1 : MonoBehaviour
{

    public void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collisionGameObject = collision.gameObject;

        if (collisionGameObject.name == "Player")
        {
            LoadSceneFase1();
        }
    }
    public void LoadSceneFase1()
    {
        SceneManager.LoadScene(2);
    }
}
