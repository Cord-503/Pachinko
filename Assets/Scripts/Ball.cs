using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == null) return;

        switch (collision.gameObject.tag)
        {
            case "Chest":
                DestroyGameObject(collision.gameObject, 50, "Chest destroyed, adding 50 points");
                break;
            case "Gold":
                DestroyGameObject(collision.gameObject, 100, "Golden Chest destroyed, adding 100 points");
                break;
            case "Goal":
                GameManager.Instance.AddScore(10);
                Debug.Log("Goal!!!!!!, adding 10 points");
                break;
            case "Target":
                GameManager.Instance.AddScore(30);
                Debug.Log("Goal!!!!!!, adding 10 points");
                break;
        }
    }

    private void DestroyGameObject(GameObject obj, int scoreToAdd, string logMessage)
    {
        Destroy(obj);
        Debug.Log(logMessage);
        GameManager.Instance.AddScore(scoreToAdd);
    }
}

