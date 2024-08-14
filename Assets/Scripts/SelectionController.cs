using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class SelectionController : MonoBehaviour
{
    public ScrollRect scrollRect; // ScrollView 的 ScrollRect 組件
    public GameObject optionsParent;
    public Button[] options;      // 選項按鈕數組
    public Button controlButton;  // 控制滑動的按鈕

    private int currentIndex = 0; // 當前選中的選項索引
    static public string _checkText;
    static public string _godText;
    static public string _godSpText;

    void Start()
    {
        // 獲取所有子物體中的按鈕組件
        options = optionsParent.GetComponentsInChildren<Button>();
        // 初始化第一个选项为选中状态
        UpdateSelection();
    }

    public void OnClickUp()
    {
        // 按下“上”按鈕時，選擇上方的選項
        MoveSelection(Vector2.up);
    }

    public void OnClickDown()
    {
        // 按下“下”按鈕時，選擇下方的選項
        MoveSelection(Vector2.down);
    }

    public void OnClickLeft()
    {
        // 按下“左”按鈕時，選擇左側的選項
        MoveSelection(Vector2.left);
    }

    public void OnClickRight()
    {
        // 按下“右”按鈕時，選擇右側的選項
        MoveSelection(Vector2.right);
    }

    public void OnCheck()
    {
        CheckGodController.PressBtn++;
        GodCheck();
    }
    public void OnBack()
    {
        CheckGodController.PressBtn--;
    }

    private IEnumerator DelayedMove(Vector2 direction)
    {
        yield return new WaitForSeconds(0.1f); // 延遲0.1秒
        MoveSelection(direction);
    }

    void Update()
    {
        // 檢測鍵盤方向鍵的按下事件
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            MoveSelection(Vector2.up);
            StartCoroutine(DelayedMove(Vector2.up));
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            MoveSelection(Vector2.down);
            StartCoroutine(DelayedMove(Vector2.down));
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MoveSelection(Vector2.left);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            MoveSelection(Vector2.right);
        }
        _checkText = options[currentIndex].name;
    }

    public void GodCheck()
    {
        switch (options[currentIndex].name)
        {
            case "高朋滿座":
                _godText = "張千歲";
                _godSpText = "食品行業";
                break;
            case "步步高升":
                _godText = "徐千歲";
                _godSpText = "風水、地理、升職";
                break;
            case "出入平安":
                _godText = "侯千歲";
                _godSpText = "行車平安";
                break;
            case "一帆風順":
                _godText = "耿千歲";
                _godSpText = "不受官司困擾";
                break;
            case "五谷豐收":
                _godText = "吳千歲";
                _godSpText = "農業豐收";
                break;
            case "業績長紅":
                _godText = "何千歲";
                _godSpText = "業務銷售順利";
                break;
            case "學業進步":
                _godText = "薛千歲";
                _godSpText = "學生學業";
                break;
            case "家庭和睦":
                _godText = "封千歲";
                _godSpText = "家庭和諧";
                break;
            case "國泰民安":
                _godText = "趙千歲";
                _godSpText = "軍警子弟工作平";
                break;
            case "逢兇化吉":
                _godText = "譚千歲";
                _godSpText = "消災、解厄、制煞";
                break;
            case "身體健康":
                _godText = "盧千歲";
                _godSpText = "信者得醫";
                break;
            case "財運亨通":
                _godText = "羅千歲";
                _godSpText = "生意昌隆";
                break;
        }
       
}

    void MoveSelection(Vector2 direction)
    {
        // 根據方向計算新的索引
        int newIndex = currentIndex;
        if (direction == Vector2.up)
        {
            newIndex = Mathf.Max(currentIndex - 1, 0);
        }
        else if (direction == Vector2.down)
        {
            newIndex = Mathf.Min(currentIndex + 1, options.Length - 1);
        }
        else if (direction == Vector2.left)
        {
            newIndex = Mathf.Max(currentIndex - 1, 0);
        }
        else if (direction == Vector2.right)
        {
            newIndex = Mathf.Min(currentIndex + 1, options.Length - 1);
        }

        // 更新選擇
        if (newIndex != currentIndex)
        {
            currentIndex = newIndex;
            UpdateSelection();

        }
    }

    void UpdateSelection()
    {
        // 取消所有按鈕的選中狀態
        foreach (Button button in options)
        {
            button.interactable = true;
        }

        // 設置當前選中按鈕為不可交互狀態
        options[currentIndex].interactable = false;

        // 打印當前選中按鈕的名稱
        //Debug.Log("當前選中按鈕名稱: " + options[currentIndex].name);

        // 滾動 ScrollView 到當前選中按鈕
        RectTransform optionRectTransform = options[currentIndex].GetComponent<RectTransform>();
        Canvas.ForceUpdateCanvases(); // 強制更新畫布
        scrollRect.content.anchoredPosition = (Vector2)scrollRect.transform.InverseTransformPoint(scrollRect.content.position) - (Vector2)scrollRect.transform.InverseTransformPoint(optionRectTransform.position);
    }
}
