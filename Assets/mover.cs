using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    public GameObject obj;
    public GameObject btn;
    float objX;
    internal string valorFoco;
    int op = 0;
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
        obj.transform.Translate(Vector2.left *  Time.deltaTime * 2);
        objX = obj.transform.position.x;
        if(objX > -0.80f && objX < 0.80f)
        {
            GameObject.Find("gobj").tag = obj.tag;
            op++;
            Debug.Log(op + obj.name);
        }
        else
        {
            GameObject.Find("gobj").tag = "vazio";
        }   

        if(obj.transform.position.x < -3.5)
        {
            Destroy(obj);
        }
    }

    public void Button_Click(GameObject f)
    {
        
        var t = GameObject.Find("gobj").tag;
        Debug.Log(t);
        
    }
}
