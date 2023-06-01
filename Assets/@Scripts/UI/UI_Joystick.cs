using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UI_Joystick : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    [SerializeField] Image _bg;
    [SerializeField] Image _handler;

    Vector2 _touchPos;
    float _joysticRadius;
    Vector2 _moveDir;

    PlayerController _player;

    void Start()
    {
        _joysticRadius = _bg.gameObject.GetComponent<RectTransform>().sizeDelta.y / 2;
        _player = GameObject.Find("Slime_01(Clone)").GetComponent<PlayerController>();
    }



    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
        _bg.transform.position = eventData.position;
        _handler.transform.position = eventData.position;
        _touchPos = eventData.position;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _handler.transform.position = _touchPos;
        _moveDir = Vector2.zero;

        
        
        Managers.MoveDir = _moveDir;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 touchDir = (eventData.position - _touchPos);

        float moveDist = Mathf.Min(touchDir.magnitude, _joysticRadius);
        _moveDir = touchDir.normalized;

        Vector2 newPosition = _touchPos + _moveDir * moveDist;
        _handler.transform.position = newPosition;

        _player._moveDir = _moveDir;

        Managers.MoveDir = _moveDir;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("OnPointerClick");
    }





}
