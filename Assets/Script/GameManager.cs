using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject BlackObj;
    private bool black = true;

    // Start is called before the first frame update
    void Start()
    {
        BlackObj.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (black == true)
            {
                BlackObj.gameObject.SetActive(false);
                black = false;
            }
            else
            {
                BlackObj.gameObject.SetActive(true);
                black = true;
            }
        }
    }
}
