using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControll : MonoBehaviour
{
    public GameObject carro;
    public Vector3 upCam = new Vector3(0,10,-00);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = carro.transform.position + upCam;
    }
}
