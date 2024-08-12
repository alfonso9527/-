using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CheckGodController : MonoBehaviour
{
    Transform _canvas,_backgrand, _introduce,_choosegod,_checkgod,_checkText;
    static public CheckGodController instance;
    static public int PressBtn = 0;
    // Start is called before the first frame update
    bool OPController = true;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        _canvas = GameObject.Find("Canvas").GetComponent<Transform>();
        _backgrand = _canvas.Find("背景").GetComponent<Transform>();
        _introduce= _backgrand.Find("介紹文本").GetComponent<Transform>();
        _choosegod= _backgrand.Find("選擇介面").GetComponent<Transform>();
        _checkgod= _backgrand.Find("確認介面").GetComponent<Transform>();
        _checkText= _checkgod.Find("確認文本").GetComponent<Transform>();
    }
    public void OnClick()
    {
        PressBtn++;
    }

    // Update is called once per frame
    void Update()
    {
        switch (PressBtn)
        {
            case 0:
                _introduce.gameObject.SetActive(OPController);
                _choosegod.gameObject.SetActive(!OPController);
                _checkgod.gameObject.SetActive(!OPController);
                break;
            case 1:
                _introduce.gameObject.SetActive(!OPController);
                _choosegod.gameObject.SetActive(OPController);
                _checkgod.gameObject.SetActive(!OPController);
                break;
            case 2:
                _introduce.gameObject.SetActive(!OPController);
                _choosegod.gameObject.SetActive(!OPController);
                _checkgod.gameObject.SetActive(OPController);
                _checkText.GetComponent<Text>().text = "你要實現的願望是:\n\n"+"<b>"+"<color=red>"+SelectionController._godText+"</color>"+"</b>"+"\n\n確定嗎?";
                break;
        }
    }
}
