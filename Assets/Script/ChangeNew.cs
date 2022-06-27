using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeNew : MonoBehaviour
{

    public void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collisionGameObject = collision.gameObject;

        if (collisionGameObject.name == "Player")
        {
            LoadSceneFase3();
        }
    }
    public void LoadSceneFase3()
    {
        SceneManager.LoadScene(4);
    }
}
