using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Food : Consumable
{
    MrG mrG;
    public Text text;

    public float saturation;

    public void Start()
    {
        mrG = GameObject.FindGameObjectWithTag("MrTag").GetComponent<MrG>();
    }

    public void Consume()
    {
        if (usesLeft > 0)
        {
            usesLeft--;
            text.text = "You yeeted 1 " + itemName + " and it gave " + saturation + " saturation, you now have " + usesLeft + " uses left";
            Debug.Log("You yeeted 1 " + itemName + " and it gave " + saturation + " saturation, you now have " + usesLeft + " uses left");
            Instantiate(Resources.Load("Yeet"), transform.position, Quaternion.identity);
            mrG.StartCoroutine(mrG.Damp());
        }
        else
        {
            text.text = "You have no uses left";
            Debug.Log("You have no uses left");
        }
    }

    public void OnMouseEnter()
    {
        text.text = itemName + " costs " + GetPricePerWeight(weight, itemValue) + " riksdaler per Kg and it gives you " + saturation + " saturation, you have " + usesLeft + " / " + maxUses + " left";
        Debug.Log(itemName + " costs " + GetPricePerWeight(weight, itemValue) + " riksdaler per Kg and it gives you " + saturation + " saturation, you have " + usesLeft + " / " + maxUses + " left");
    }

    public void OnMouseUpAsButton()
    {
        Consume();
    }

}