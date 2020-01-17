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

    public GameObject GerarItemSeq(){
        int op = 0;
        GameObject item;
        switch(op){
            case 0:
                item = GerarSeqB();
                return item;
            case 1:
                item = GerarSeqM();
                return item;
            case 2:
                item = GerarSeqU();
                return item;
            case 3:
                item = GerarSeqL();
                return item;
            
        }
        return new GameObject();
    }

    public GameObject banana;
    public GameObject go1;
    public GameObject go2;
    // Start is called before the first frame update
    void Start()
    {
        // Vector2 v1 = new Vector2(4, 3.45f);
        // Vector2 v2 = new Vector2(2.8f, 3.4f);
        // go1 = GerarItemSeq();
        // go1.transform.position = v1;
        
    }


    // Update is called once per frame
    void Update()
    {
        
        // var t = banana.transform.position;
        // t.x += -1;
        // banana.transform.Translate(Vector2.left * Time.deltaTime * 5);
    }
}
