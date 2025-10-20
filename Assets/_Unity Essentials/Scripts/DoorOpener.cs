using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    private Animator doorAnimator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        doorAnimator = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && doorAnimator != null)
        {
            doorAnimator.SetTrigger("Door_Open");
        }
    }
}
