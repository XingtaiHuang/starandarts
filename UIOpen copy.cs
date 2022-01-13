using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIOpen : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject UI;

    public void OpenUI()
    {
        if(UI != null)
        {
            UI.SetActive(true);
        }
    }

}
