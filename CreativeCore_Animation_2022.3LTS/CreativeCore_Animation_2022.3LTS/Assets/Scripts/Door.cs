using UnityEngine;

public class Door : MonoBehaviour
{
    public Animator animator;
    private void OnTriggerEnter(Collider other)
    {
        animator.SetTrigger("OpenDoor");
        animator.SetBool("isDoorOpen", !animator.GetBool("isDoorOpen"));
    }

    private void OnTriggerExit(Collider other)
    {
        animator.SetBool("isDoorOpen", !animator.GetBool("isDoorOpen"));
    }
}
