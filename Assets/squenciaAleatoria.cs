using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class squenciaAleatoria : MonoBehaviour
{
    public GameObject[] spawnees;
    GameObject gameObject;
    int randomInt;

    // Start is called before the first frame update
    void Start()
    {
        randomInt = Random.Range(0, 3);
        gameObject = new GameObject();
        gameObject = spawnees[randomInt];
        Vector2 v2 = new Vector2(0, 0);
        gameObject.transform.position = v2;
        Instantiate(gameObject, gameObject.transform);

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 v2 = new Vector2(4, 3.45f);
        

    }
}
