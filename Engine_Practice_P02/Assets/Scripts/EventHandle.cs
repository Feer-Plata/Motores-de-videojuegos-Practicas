using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class EventHandle : MonoBehaviour
{
    int counter;
    TMP_Text Notification;
    public void UpdateEvents()
    {
        Debug.Log("UpdateEvents");
        if (counter == 15)
        {
            Notification.text = "New Goal 15 XP";
            Debug.Log("New Goal 15 XP - Event Reached");
            PlayerPrefs.SetString("Logros", Notification.text);
        }
        if (counter == 25)
        {
            Notification.text = "New Goal 25 XP";
            Debug.Log("New Goal 15 XP - Event Reached");
            PlayerPrefs.SetString("Logros", Notification.text);
        }
    }

    public void LeaveGame()
    {
        PlayerPrefs.SetInt("Points", counter);
        SceneManager.LoadScene("LeaderBoard");
    }
        

}
