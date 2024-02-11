using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class RandomHilex : MonoBehaviour
{
    public Material[] allMats;
    public string[] Tags;
    // Start is called before the first frame update
    void Start()
    {
        RandomMaterials();
    }

    void RandomMaterials()
    {
        foreach (Transform child in transform)
        {
            int r = Random.Range(0, allMats.Length);
            child.tag = Tags[r];
            if (r==2)
            {
                child.GetComponent<MeshRenderer>().enabled = false;
                child.GetComponent<MeshCollider>().convex = true;
                child.GetComponent<MeshCollider>().isTrigger = true;
                child.transform.localScale = new Vector3(child.localScale.x, child.localScale.y, child.localScale.z-1);
            }
            else
            {
                child.GetComponent<Renderer>().material = allMats[r];
            }
            //if(!child.GetComponent<MeshCollider>().isTrigger)
            //{
            //    child.GetComponent<Renderer>().material = allMats[r];
            //    child.tag = Tags[r];
            //}
            //else
            //{
            //    child.tag = Tags[r];
            //}
        }
    }
    // Update is called once per frame
    //void Update()
    //{
        
    //}
}
