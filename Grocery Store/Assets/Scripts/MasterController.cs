using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterController : MonoBehaviour
{
    public Transform startPosition;
    // Start is called before the first frame update
    void Start()
    {
        if(startPosition !=null)
        {
            transform.position = startPosition.position;
            transform.rotation = startPosition.rotation;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
