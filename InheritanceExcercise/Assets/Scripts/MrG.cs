using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MrG : MonoBehaviour
{
    public float dampTime, offset, antal;
    public Vector2 orgPos;
    SpriteRenderer sprite;


    void Start()
    {
        orgPos = transform.position;
        sprite = GetComponent<SpriteRenderer>();
    }


    public IEnumerator Damp()
    {
        sprite.color = new Color(1, 0, 0);
        for (int i = 0; i < antal; i++)
        {
            transform.position = new Vector2(Random.Range(orgPos.x - offset, orgPos.x + offset), Random.Range(orgPos.y - offset, orgPos.y + offset));
            yield return new WaitForSeconds(dampTime);
        }
        transform.position = orgPos;
        sprite.color = new Color(1, 1, 1);
    }
}
