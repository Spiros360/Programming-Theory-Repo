using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolymorphTextScript : ParentTextScript
{
   

    // Start is called before the first frame update
    void Start()
    {
        TextList();
        Opacity = 0.4f;
        ColorR = 0.9f;
        ChangeColor();
    }

    // Update is called once per frame
    void Update()
    {
        Timer();
    }

    public override void TextList()
    {
        TextDisplay.Add("Child overriding");
        TextDisplay.Add("Polymorphism");
       
    }
}
