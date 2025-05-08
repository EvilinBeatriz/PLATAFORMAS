using UnityEngine;

public class PlatformButton : MonoBehaviour
{
    public string doorIDToTrigger;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            DoorEventChannel.RaiseDoorOpen(doorIDToTrigger);
        }
    }
}
