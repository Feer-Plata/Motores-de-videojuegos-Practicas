using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject item;
    public int waveIndex = 0; //cuantas oleadas vamos a tener
    public float timeOfWaves; //duracion de las oleadas
    public float timer; //cada cuanto se crean los objetos
    public Transform[] pointsArray;
    private void Awake()
    {
        pointsArray = new Transform[transform.childCount]; // reservar los espacios del total de hijos

        for (int i = 0; i < pointsArray.Length; i++)
        {
            pointsArray[i] = transform.GetChild(i);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (waveIndex != 25)
        {
            if (timer <= 0.0f)
            {
                Spawnitem();
                timer = timeOfWaves;
            }
        }
        timer -= Time.deltaTime; //restar tiempo
    }
    public IEnumerator WAVE()
    {
        yield return new WaitForSeconds(0.8f);
    }
    public void Spawnitem()
    {
        int randomPoint = Random.Range(0, pointsArray.Length);
        var obj = Instantiate(item, pointsArray[randomPoint].position, transform.rotation);
    }
}
