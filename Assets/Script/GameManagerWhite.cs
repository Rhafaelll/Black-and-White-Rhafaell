using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class GameManagerWhite : MonoBehaviour
    {
        [SerializeField] GameObject WhiteObj;
        private bool white = false;

        // Start is called before the first frame update
        void Start()
        {
            WhiteObj.gameObject.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (white == false)
                {
                    WhiteObj.gameObject.SetActive(true);
                    white = true;
                }
                else
                {
                    WhiteObj.gameObject.SetActive(false);
                    white = false;
                }
            }
        }
    }