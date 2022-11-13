using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Store", menuName = "Avatar")]
public class AvatarAttribute : ScriptableObject
{
    public string Name;
    public string Description;
    public int XP;
}
