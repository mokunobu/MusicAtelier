using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonColorChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeColor()
    {
        Image self = GetComponent<Image>();
        if(self.color == Color.white)
        {
            self.color = Color.yellow;
        }  
        else
        {
            self.color = Color.white;
        }
    }
}
