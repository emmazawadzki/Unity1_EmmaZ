using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        //Faire pivoter le cube
        transform.Rotate(new Vector3(0f,100f,0f) * Time.deltaTime);

    }
}
