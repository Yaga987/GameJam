using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LastPortal : MonoBehaviour
{
    //public SahneController sc;
    //public GameObject destroyer;
    // Start is called before the first frame update
    void Start()
    {
        //destroyer = GameObject.FindGameObjectWithTag("Destroyer");
        //sc = destroyer.GetComponent<SahneController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Application.LoadLevel(0);
        }
    }
}
