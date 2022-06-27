using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DeathCounter : MonoBehaviour {

    public static int DeathNum = 0;
    Text death;
    void Start()
    {
        death = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        death.text = "Mortes: " + DeathNum;
    }
}
