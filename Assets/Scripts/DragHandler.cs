using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class DragHandler : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public Text topText, leftText, rightText;
    public Image dragImage;
    public float textDisplayDelay = 1f;
    private bool isDragging = false;

    void Start()
    {
        dragImage.gameObject.SetActive(false);
        topText.gameObject.SetActive(false);
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

        if (dragImagePosition.y > buttonCenterPosition.y && dragImagePosition.y == 375 && dragImagePosition.x >280 && dragImagePosition.x<440)
        {
            SceneManager.LoadScene(3);
        }
        else if (dragImagePosition.x < buttonCenterPosition.x && dragImagePosition.x ==225 && dragImagePosition.y>250 && dragImagePosition.y <270)
        {
            Debug.Log("¥ª¤è");
        }
        else if (dragImagePosition.x > buttonCenterPosition.x && dragImagePosition.x == 495 && dragImagePosition.y > 250 && dragImagePosition.y < 270)
        {
            Debug.Log("¥k¤è");
        }

        topText.gameObject.SetActive(false);
        leftText.gameObject.SetActive(false);
        rightText.gameObject.SetActive(false);
    }

    private IEnumerator ShowTextsAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        if (isDragging)
        {
            topText.gameObject.SetActive(true);
            leftText.gameObject.SetActive(true);
            rightText.gameObject.SetActive(true);
        }
    }

    private void UpdateTextColor(Vector3 dragImagePosition, Vector3 buttonCenterPosition)
    {
        if (dragImagePosition.y > buttonCenterPosition.y && dragImagePosition.y == 375 && dragImagePosition.x > 280 && dragImagePosition.x < 440)
        {
            topText.color = Color.green;
            leftText.color = Color.white;
            rightText.color = Color.white;
        }
        else if (dragImagePosition.x < buttonCenterPosition.x &&  dragImagePosition.x == 225 && dragImagePosition.y > 250 && dragImagePosition.y < 270)
        {
            leftText.color = Color.green;
            topText.color = Color.white;
            rightText.color = Color.white;
        }
        else if (dragImagePosition.x > buttonCenterPosition.x && dragImagePosition.x == 495 && dragImagePosition.y > 250 && dragImagePosition.y < 270)
        {
            rightText.color = Color.green;
            topText.color = Color.white;
            leftText.color = Color.white;
        }
        else
        {
            topText.color = Color.white;
            leftText.color = Color.white;
            rightText.color = Color.white;
        }
    }
}
