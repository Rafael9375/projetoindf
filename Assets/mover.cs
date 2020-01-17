using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    public GameObject obj;
    public void Lanca(){
        Vector2 vector2 = new Vector2(4, 3.45f);
        obj.transform.position = vector2;
        Instantiate(obj, obj.transform);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.Translate(Vector2.left *  Time.deltaTime * 3);
    }
}
