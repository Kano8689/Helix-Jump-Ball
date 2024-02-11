using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    public GameObject winObj;
    SceneManager sceneManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}
    public void onClickContinue()
    {
        winObj.SetActive(false);
        SceneManager.LoadScene("Play");
    }
}
