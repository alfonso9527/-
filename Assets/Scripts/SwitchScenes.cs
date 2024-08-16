using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScenes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SwitchScenes01()
    {
        SceneManager.LoadScene(0);
    }
    public void SwitchScenes02()
    {
        SceneManager.LoadScene(1);
    }
    public void SwitchScenes03()
    {
        SceneManager.LoadScene(2);
    }
    public void SwitchScenes04()
    {
        SceneManager.LoadScene(3);
    }
    public void SwitchScenes05()
    {
        SceneManager.LoadScene(4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
