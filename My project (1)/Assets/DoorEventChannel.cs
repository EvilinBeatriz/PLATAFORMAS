using System;

public static class DoorEventChannel
{
    public static Action<string> OnDoorOpenRequested;

    public static void RaiseDoorOpen(string doorID)
    {
        OnDoorOpenRequested?.Invoke(doorID);
    }
}