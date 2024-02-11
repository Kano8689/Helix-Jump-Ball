using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePipe : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}

    private void OnMouseDrag()
    {
        float horizontal = Input.GetAxis("Mouse X") * Time.deltaTime * 100f;
        transform.Rotate(Vector3.up * (-horizontal));
    }
}
