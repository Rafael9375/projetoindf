using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instSc : MonoBehaviour
{
    public GameObject obj;
    // Start is called before the first frame update
    public void Lanca(){
        Vector2 vector2 = new Vector2(4, 3.45f);
        obj = new GameObject();
        obj.transform.position = vector2;
        Instantiate(obj, obj.transform);
    }
    void Start()
    {
        Lanca();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 v2 = new Vector2(obj.transform.position.x, obj.transform.position.y);
        if(v2.x < 2.8f){

        }

    }
}
