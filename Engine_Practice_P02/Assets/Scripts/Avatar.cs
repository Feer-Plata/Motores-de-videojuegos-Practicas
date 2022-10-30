using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Avatar : MonoBehaviour
{
    public int AvatarIndex = 0;
    public List<AvatarAttribute> Avatars;
    public TMP_Text Name;
    public TMP_Text Desc;
    public TMP_Text xp;

    // Update is called once per frame
    void Update()
    {
        Name.text = Avatars[AvatarIndex].Name;
        Desc.text = "Information: " + Avatars[AvatarIndex].Description;
        xp.text = Avatars[AvatarIndex].XP.ToString() + "XP";
    }
}
