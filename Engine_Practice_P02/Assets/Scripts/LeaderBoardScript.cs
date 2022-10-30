using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class LeaderBoardScript : MonoBehaviour
{
    //Atributos
    public int puntos;
    public string logros;

    public TMP_Text pointTxt;
    public TMP_Text logrosTxt;
    // Start is called before the first frame update
    void Start()
    {
        puntos = PlayerPrefs.GetInt("Points");
        puntos = PlayerPrefs.GetInt("Logros");
        pointTxt.text = puntos.ToString();
        logrosTxt.text = logros;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
