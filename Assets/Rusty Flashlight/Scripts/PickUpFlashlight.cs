using UnityEngine;

public class PickUpFlashlight : MonoBehaviour
{
    public GameObject flashlight;
    private bool playerInRange = false;

    void Start()
    {
        flashlight.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            gameObject.SetActive(false);
            flashlight.SetActive(true);
        }
    }
}

