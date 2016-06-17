using UnityEngine;
using System.Collections;

public class AnimationManager : MonoBehaviour
{
    public void SetAnimator(AnimatorOverrideController animator)
    {
        GetComponent<Animator>().runtimeAnimatorController = animator;
    }

    public void SetTrigger(string parameter)
    {
        GetComponent<Animator>().SetTrigger(parameter);
    }
}
