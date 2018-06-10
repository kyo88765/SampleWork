using UnityEngine;
using UnityEngine.EventSystems;

public class TouchController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [SerializeField]
    MainObjectCamera mainObjectCamera;

    public void OnPointerDown(PointerEventData data)
    {
    }

    public void OnPointerUp(PointerEventData data)
    {
    }

    public void OnBeginDrag(PointerEventData data)
    {
    }

    public void OnDrag(PointerEventData data)
    {
        mainObjectCamera.AddRotation(data.delta.y, data.delta.x);
    }

    public void OnEndDrag(PointerEventData data)
    {
    }
}
