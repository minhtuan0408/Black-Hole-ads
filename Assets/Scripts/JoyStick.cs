using UnityEngine;
using UnityEngine.EventSystems;

public class Joystick : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler
{
    public RectTransform background; 
    public RectTransform handle;     
    public float handleRange = 50f;
    public GameObject BackGround;

    private Vector2 input = Vector2.zero;
    private Vector2 center = Vector2.zero;

    void Start()
    {
        // Tính tâm background
        center = background.rect.size / 2f;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        BackGround.SetActive(false);
        OnDrag(eventData);
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 pos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(background, eventData.position, eventData.pressEventCamera, out pos);

        Vector2 delta = pos;


        Vector2 clamped = Vector2.ClampMagnitude(delta, handleRange);

        handle.anchoredPosition = clamped;


        input = clamped / handleRange;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        input = Vector2.zero;
        handle.anchoredPosition = Vector2.zero;
        BackGround.SetActive(true);
    }

    public Vector2 GetInput()
    {
        return input;
    }
}
