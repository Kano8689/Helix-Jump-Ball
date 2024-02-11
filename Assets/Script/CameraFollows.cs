using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollows : MonoBehaviour
{
    public GameObject Player;
    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - Player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, Player.transform.position.y, transform.position.z);
        transform.LookAt(Player.transform.position);
    }
}
