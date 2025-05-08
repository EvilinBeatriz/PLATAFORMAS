using UnityEngine;

public class Door : MonoBehaviour
{
    public string doorID;
    private Collider2D col;
    private SpriteRenderer sr;

    void Awake()
    {
        col = GetComponent<Collider2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    void OnEnable()
    {
        DoorEventChannel.OnDoorOpenRequested += HandleDoorOpen;
    }

    void OnDisable()
    {
        DoorEventChannel.OnDoorOpenRequested -= HandleDoorOpen;
    }

    private void HandleDoorOpen(string triggeredID)
    {
        if (triggeredID == doorID)
        {
            OpenDoor();
        }
    }

    private void OpenDoor()
    {
        col.enabled = false;
        sr.color = Color.green; // visual feedback
    }
}
