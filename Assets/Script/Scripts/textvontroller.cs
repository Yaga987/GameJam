using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class textvontroller : MonoBehaviour
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
        if (timer < 5)
        {
            tmesh.SetText("HUH! Burasi neden bembeyaz...");
        }else if (timer > 5 && timer <12)
        {
            tmesh.SetText("Yanlis degilsem gunumuze gelmis olmam lazým.");
        }
        else if (timer > 12 && timer < 17)
        {
            tmesh.SetText("Acaba bi bozunmanin eseri mi?");
        }
        else if(timer > 17){
            tmesh.SetText("");
        }
    }
}
