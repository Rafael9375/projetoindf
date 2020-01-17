using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teste : MonoBehaviour
{
    public GameObject GerarSeqM(){
        var obj = GameObject.Find("seqM");
        return obj;
    }

    public GameObject GerarSeqB(){
        var obj = GameObject.Find("seqB");
        return obj;
    }
    
    public GameObject GerarSeqU(){
        var obj = GameObject.Find("seqU");
        return obj;
    }

    public GameObject GerarSeqL(){
        var obj = GameObject.Find("seqL");
        return obj;
    }

    public void GerarItemSeq(){
        Vector2 vector2 = new Vector2(Random.Range(-2, 2), Random.Range(-2, 2));
        var op = Random.Range(0, 3);
        GameObject item;
        switch(op){
            case 0:
                item = GerarSeqB();
                item.transform.position = vector2;
            break;
            case 1:
                item = GerarSeqM();
                item.transform.position = vector2;
            break;
            case 2:
                item = GerarSeqU();
                item.transform.position = vector2;
            break;
            case 3:
                item = GerarSeqL();
                item.transform.position = vector2;
            break;
        }
    }

    public GameObject banana;

    // Start is called before the first frame update
    void Start()
    {
        banana = GerarSeqB();
        Vector2 vector2 = new Vector2(0, 0);
        banana.transform.position = vector2;
    }

    // Update is called once per frame
    void Update()
    {
        var t = banana.transform.position;
        t.x += -1;
        banana.transform.Translate(Vector2.left * Time.deltaTime * 5);
    }
}
