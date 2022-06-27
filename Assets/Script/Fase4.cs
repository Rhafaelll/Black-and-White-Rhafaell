using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fase4 : MonoBehaviour
{

    public void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collisionGameObject = collision.gameObject;

        if (collisionGameObject.name == "Player")
        {
            LoadSceneFase4();
        }
    }
    public void LoadSceneFase4()
    {
        SceneManager.LoadScene(5);
    }
}
