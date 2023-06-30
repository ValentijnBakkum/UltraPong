using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject P1;
    public GameObject P2;

    public float speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W) && P1.transform.localPosition.y < 149){
            P1.transform.position = new Vector3(P1.transform.position.x, P1.transform.position.y + speed, P1.transform.position.z);
        }

        if(Input.GetKey(KeyCode.S) && P1.transform.localPosition.y > -149){
            P1.transform.position = new Vector3(P1.transform.position.x, P1.transform.position.y - speed, P1.transform.position.z);
        }

        if(Input.GetKey(KeyCode.UpArrow) && P2.transform.localPosition.y < 149){
            P2.transform.position = new Vector3(P2.transform.position.x, P2.transform.position.y + speed, P2.transform.position.z);
        }

        if(Input.GetKey(KeyCode.DownArrow) && P2.transform.localPosition.y > -149){
            P2.transform.position = new Vector3(P2.transform.position.x, P2.transform.position.y - speed, P2.transform.position.z);
        }
    }
}
