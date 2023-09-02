using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    //public Button S1;
    //public Button S2;
    //public Button S3;
    //public Button Back;

    [SerializeField]
    bool s1;
    [SerializeField]
    bool s2;
    [SerializeField]
    bool s3;

    // Start is called before the first frame update
    public void Start()
    {
        //S1.onClick.AddListener(ChangingScene);
        //S2.onClick.AddListener(ChangingScene);
        //S3.onClick.AddListener(ChangingScene);
        //Back.onClick.AddListener(BackToMain);
    }

    public void ChangingScene()
    {
        if (s1 == true)
        {
            SceneManager.LoadScene("S1");
        }
        else if (s2 == true)
        {
            SceneManager.LoadScene("S2");
        }
        else if (s3 == true)
        {
            SceneManager.LoadScene("S3");
        }
    }

    public void BackToMain()
    {
        SceneManager.LoadScene(0);
    }
}
