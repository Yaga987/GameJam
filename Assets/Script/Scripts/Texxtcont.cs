using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Texxtcont : MonoBehaviour
{
    public float timer;
    public TextMeshProUGUI tmesh;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer < 1)
        {
            tmesh.SetText("VENA Sunar...");
        }
        else if (timer > 1)
        {
            tmesh.SetText("VENA sunar mý?");
        }
    }
}
