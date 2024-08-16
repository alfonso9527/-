using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections;

public class DragHandlerGod : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public Text topLeftText, topRightText, leftText, rightText;
    public Image dragImage;
    public float textDisplayDelay = 1f;
    private bool isDragging = false;

    void Start()
    {
        dragImage.gameObject.SetActive(false);
        topLeftText.gameObject.SetActive(false);
        topRightText.gameObject.SetActive(false);
        leftText.gameObject.SetActive(false);
        rightText.gameObject.SetActive(false);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        dragImage.gameObject.SetActive(true);
        isDragging = true;
        StartCoroutine(ShowTextsAfterDelay(textDisplayDelay));
    }

    public void OnDrag(PointerEventData eventData)
    {
        RectTransform buttonRectTransform = GetComponent<RectTransform>();
        Vector3[] buttonCorners = new Vector3[4];
        buttonRectTransform.GetWorldCorners(buttonCorners);

        Vector3 dragImagePosition = Input.mousePosition;
        dragImagePosition.x = Mathf.Clamp(dragImagePosition.x, buttonCorners[0].x, buttonCorners[2].x);
        dragImagePosition.y = Mathf.Clamp(dragImagePosition.y, buttonCorners[0].y, buttonCorners[2].y);

        dragImage.transform.position = dragImagePosition;

        UpdateTextColor(dragImagePosition, buttonRectTransform.position);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        dragImage.gameObject.SetActive(false);
        isDragging = false;

        Vector3 dragImagePosition = dragImage.transform.position;
        Vector3 buttonCenterPosition = GetComponent<RectTransform>().position;

        if (dragImagePosition.x < buttonCenterPosition.x && dragImagePosition.y > buttonCenterPosition.y && dragImagePosition.x ==225 && dragImagePosition.y ==375)
        {
            Debug.Log("もオ?办");
        }
        else if (dragImagePosition.x > buttonCenterPosition.x && dragImagePosition.y > buttonCenterPosition.y && dragImagePosition.x ==495 && dragImagePosition.y ==375)
        {
            Debug.Log("も?办");
        }
        else if (dragImagePosition.x < buttonCenterPosition.x && dragImagePosition.y <= buttonCenterPosition.y && dragImagePosition.x == 225)
        {
            Debug.Log("もオ?办");
        }
        else if (dragImagePosition.x > buttonCenterPosition.x && dragImagePosition.y <= buttonCenterPosition.y && dragImagePosition.x == 495)
        {
            Debug.Log("も?办");
        }


        topLeftText.gameObject.SetActive(false);
        topRightText.gameObject.SetActive(false);
        leftText.gameObject.SetActive(false);
        rightText.gameObject.SetActive(false);
    }

    private IEnumerator ShowTextsAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        if (isDragging)
        {
            topLeftText.gameObject.SetActive(true);
            topRightText.gameObject.SetActive(true);
            leftText.gameObject.SetActive(true);
            rightText.gameObject.SetActive(true);
        }
    }

    private void UpdateTextColor(Vector3 dragImagePosition, Vector3 buttonCenterPosition)
    {
        if (dragImagePosition.x < buttonCenterPosition.x && dragImagePosition.y > buttonCenterPosition.y && dragImagePosition.x == 225 && dragImagePosition.y == 375)
        {
            topLeftText.color = Color.green;
            topRightText.color = Color.white;
            leftText.color = Color.white;
            rightText.color = Color.white;
        }
        else if (dragImagePosition.x > buttonCenterPosition.x && dragImagePosition.y > buttonCenterPosition.y && dragImagePosition.x ==495 && dragImagePosition.y == 375)
        {
            topLeftText.color = Color.white;
            topRightText.color = Color.green;
            leftText.color = Color.white;
            rightText.color = Color.white;
        }
        else if (dragImagePosition.x < buttonCenterPosition.x && dragImagePosition.y <= buttonCenterPosition.y && dragImagePosition.x == 225)
        {
            topLeftText.color = Color.white;
            topRightText.color = Color.white;
            leftText.color = Color.green;
            rightText.color = Color.white;
        }
        else if (dragImagePosition.x > buttonCenterPosition.x && dragImagePosition.y <= buttonCenterPosition.y && dragImagePosition.x == 495)
        {
            topLeftText.color = Color.white;
            topRightText.color = Color.white;
            leftText.color = Color.white;
            rightText.color = Color.green;
        }
        else
        {
            topLeftText.color = Color.white;
            topRightText.color = Color.white;
            leftText.color = Color.white;
            rightText.color = Color.white;
        }
    }
}
