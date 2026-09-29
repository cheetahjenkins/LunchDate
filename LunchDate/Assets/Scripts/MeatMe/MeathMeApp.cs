using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeathMeApp: MonoBehaviour
{
    public GameEvent onReloadVictimSprite;
    public GameEvent onReloadProfileText;
    public GameEvent onChangeCurrentMeatMeProfile;

    public List<MeatMeProfileData> allProfiles = new List<MeatMeProfileData>();
    public MeatMeProfileData currentProfile;
    public int currentProfileIndex = 0;

    public Image profilePicture;

    public GameEvent onVictimGreeting;

    private void Start()
    {
        ReloadProfile();
    }

    public void ChangeProfile()
    {
        currentProfileIndex++;

        if (currentProfileIndex == allProfiles.Count)
        {
            currentProfileIndex = 0;
        }
        currentProfile = allProfiles[currentProfileIndex];
        ReloadProfile();
    }

    public void ReloadProfile()
    {
        onReloadVictimSprite.Broadcast(new EventData(data: currentProfile.photo));
        onChangeCurrentMeatMeProfile.Broadcast(new EventData(data: currentProfile));
        profilePicture.sprite = currentProfile.photo;
        onVictimGreeting.Broadcast(new EventData(data: currentProfile.greetings[0]));
    }
}