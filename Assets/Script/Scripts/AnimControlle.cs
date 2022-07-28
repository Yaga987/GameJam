using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControlle : MonoBehaviour
{
    private Animator anim;
    private enum MovementState { idle }
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateAnimationState();
    }
    private void UpdateAnimationState()
    {
        MovementState state;

        state = MovementState.idle;

        anim.SetInteger("state", (int)state);
    }
}
