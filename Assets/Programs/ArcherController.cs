using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Vector3 tmp = this.transform.position;
            this.transform.position += new Vector3 (tmp.x + 1, tmp.y, tmp.z); 
        }
    }
}
