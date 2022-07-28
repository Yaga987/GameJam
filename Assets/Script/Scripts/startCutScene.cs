using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startCutScene : MonoBehaviour
{
    public Animator cutAnim;
    public bool isCutScene;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "player")
        {
            isCutScene = true;
            cutAnim.SetBool("cutscreen1", true);
            Invoke(nameof(StopCutScene),3f);
        }
    }
    void StopCutScene()
    {
        isCutScene = false;
        cutAnim.SetBool("cutscreen1", false);
    }
}
