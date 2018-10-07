using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string itemName;
    public float itemValue;
    public float weight;

    public float GetPricePerWeight(float itemWeight, float itemPrice)
    {
        float price = itemPrice / itemWeight;
        return price;
    }

    void Update()
    {
    
    }

}
