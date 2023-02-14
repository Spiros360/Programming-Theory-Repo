using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InheritTextScript : ParentTextScript
{
    // Start is called before the first frame update
    void Start()
    {  
        TextList();
        ChangeColor();
    }

    // Update is called once per frame
    void Update()
    {
        Timer();
    }
    
    public override void ChangeColor()
    {
        base.ChangeColor();
    }

    public override void TextList()
    {
        TextDisplay.Add("Child");
        TextDisplay.Add("Inheritance");

    }
}
