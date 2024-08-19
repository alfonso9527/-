using UnityEngine;
using UnityEngine.UI;

public class ButtonClickHandler : MonoBehaviour
{
    static public string ChooseGod;
    public void OnButtonClicked()
    {
        string buttonName = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
        Debug.Log("Button clicked: " + buttonName);
        ChooseGod = buttonName;
    }
}
