using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public GameObject pipeScript;
    public GameObject lsrObj, winObj;
    Rigidbody rb;
    bool isForced = false;
    internal int score=0;
    
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<BallController>().enabled = true;
        pipeScript.gameObject.GetComponent<RotatePipe>().enabled = true;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isForced)
        {
            addForceToBall();
        }
    }

    void addForceToBall()
    {
        isForced = false;
        rb.velocity = Vector3.zero;
        rb.AddForce(Vector3.up * 250);
    }

    private void OnCollisionEnter(Collision collision)
    {
        isForced = true;
        
        if(collision.gameObject.tag=="helix")
        {
            //Debug.Log("Yellow");
        }
        
        if (collision.gameObject.tag == "dangerHelix")
        {
            Debug.Log("Looser");
            this.gameObject.GetComponent<BallController>().enabled = false;
            pipeScript.gameObject.GetComponent<RotatePipe>().enabled = true;
            lsrObj.SetActive(true);
        }
        
        if (collision.gameObject.tag == "over")
        {
            winObj.SetActive(true);
            Debug.Log("Winner");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "score")
        {
            Debug.Log("Next Helix Ring");
            score++;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "score")
        {
            GameObject parentObj = other.transform.parent.gameObject;
            if(parentObj != null)
            {
                foreach(Transform child in parentObj.transform)
                {
                    if(child.tag != "score")
                    {
                        child.GetComponent<Rigidbody>().isKinematic = false;
                        child.GetComponent<MeshCollider>().convex = true;
                        //child.GetComponent<Rigidbody>().AddExplosionForce(1f,Vector3.down,1f);
                    }
                    Destroy(child.gameObject, 1f);
                }
            }
        }
    }
}
