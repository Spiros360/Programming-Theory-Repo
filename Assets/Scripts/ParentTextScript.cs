using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParentTextScript : MonoBehaviour
{
    [SerializeField] private TextMesh Text;
    [SerializeField] private List<string> TextToDisplay;
    private float TimeToNextText = 0.0f;
    private int CurrentText = 0;

    [SerializeField] private MeshRenderer Renderer;
    private float opacity = 0.9f;
    private float colorR = 0.1f;
    private float colorG = 0.8f;
    private float colorB = 0.5f;

    public float ColorR
    {
        get { return colorR; }
        set { colorR = value; }
    }

    public List<string> TextDisplay
    {
        get { return TextToDisplay; }
        set { TextToDisplay = value; }
    }

    public float Opacity
    {
        get { return opacity; }
        set
        {
            if (value < 0.0f)
            {
                Debug.Log("You can't set negarive number");
            }
            else
            {
                opacity = value;
            }
        }
    }

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

    public void Timer()
    {
        TimeToNextText += Time.deltaTime;

        if (TimeToNextText > 1.5f)
        {
            TimeToNextText = 0.0f;
            CurrentText++;

            if (CurrentText >= TextToDisplay.Count)
            {
                CurrentText = 0;
                Text.text = TextToDisplay[CurrentText];
            }
            Text.text = TextToDisplay[CurrentText];
        }
    }

    public virtual void TextList()
    {
        TextToDisplay.Add("Parent with private varisbles");
        TextToDisplay.Add("Encapsulation");
        Text.text = TextToDisplay[0];
    }

    public virtual void ChangeColor()
    {
        Material material = Renderer.material;
        material.color = new Color(colorR, colorG, colorB, opacity);
    }
}