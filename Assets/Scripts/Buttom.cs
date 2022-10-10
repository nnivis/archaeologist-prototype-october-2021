using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using Button = UnityEngine.UI.Button;

public class Buttom : MonoBehaviour
{
    public UnityEngine.UI.Button yourButton;
    public UnityEngine.UI.Button.ButtonClickedEvent btnclick;
    public GameObject panelToAttachButtonsTo;

    public void CreateButton(string name, int i)//Creates a button and sets it up
    {
        UnityEngine.UI.Button btn = yourButton.GetComponent<Button>();
        btn.transform.SetParent(panelToAttachButtonsTo.transform);//Setting button parent
        btn.onClick.AddListener(OnClick);

        //Next line assumes button has child with text as first gameobject like button created from GameObject->UI->Button
        btn.transform.GetChild(0).GetComponent<Text>().text = name;//Changing text

        Debug.Log(i);
    }
    void OnClick()
    { }


}
