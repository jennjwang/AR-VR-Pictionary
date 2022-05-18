using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Randomize : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI txt;

    private int index = 0;
    List<string> prompts = new List<string>
            { "Slipper", "Tadpole", "Burrito", "Backseat", "Solar eclipse", "Calendar", "Sticky Notes" , "Book", "Chairs ","Coffee cup","Mummy", "Candy", "Bays", "Squirrels", "Unicorn", "Dog leash", "Newspaper", "Hammock", "Video camera", "Money", "Smiley face"};

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Next()
    {
        index = Random.Range(0, prompts.Count);
        txt.text = prompts[index];
    }
}
