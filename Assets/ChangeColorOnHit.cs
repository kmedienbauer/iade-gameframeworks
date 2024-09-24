using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnHit : MonoBehaviour
{

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag.CompareTo("Player") == 0)
        {
            Material cachedMaterial = gameObject.GetComponentInChildren<SpriteRenderer>().material;
            cachedMaterial.SetColor("_Color", new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f)));
        }
    }

}
