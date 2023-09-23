using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UItest : MonoBehaviour
{
    public GameObject onClick;
    private Button onClickButton;
    public GameObject pointer;

    // Start is called before the first frame update
    void Start()
    {
        onClickButton = onClick.GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        HotKeys();
    }

    private void HotKeys()
    {
        if(Input.GetKey(KeyCode.Space) && Input.GetKeyDown(KeyCode.C))
        {
            onClickButton.onClick.Invoke();
        }

        if (Input.GetKey(KeyCode.Space) && Input.GetKeyDown(KeyCode.P))
        {
            ExecuteEvents.Execute<IPointerDownHandler>(pointer, new PointerEventData(EventSystem.current), ExecuteEvents.pointerDownHandler);
        }
    }
}
