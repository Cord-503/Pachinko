using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == null) return;

        GameManager.Instance.RegisterHit(collision.gameObject.tag);

        if (collision.gameObject.CompareTag("Chest") || collision.gameObject.CompareTag("Gold"))
        {
            Destroy(collision.gameObject);
        }
    }
}