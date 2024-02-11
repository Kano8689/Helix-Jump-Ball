using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Looser : MonoBehaviour
{
    public GameObject lsrObj;
    public Text ScoreBox;
    BallController ballController;
    SceneManager sceneManager;
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        ballController = GetComponent<BallController>();
        
        ScoreBox.text = score.ToString();
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}

    public void onClickRestart()
    {
        lsrObj.SetActive(false);
        SceneManager.LoadScene("Play");
    }
}
