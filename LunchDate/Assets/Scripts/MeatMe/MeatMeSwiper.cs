using System;
using UnityEngine;
using UnityEngine.UI;

public class MeatMeSwiper : MonoBehaviour
{
    public GameEvent matchEvent;
    public GameEvent dislikeEvent;

    public MeatMeProfileData currentProfile;

    public void Dislike()
    {
        dislikeEvent.Broadcast(new EventData());
    }

    public void Match()
    {
        matchEvent.Broadcast(new EventData());
    }
}
