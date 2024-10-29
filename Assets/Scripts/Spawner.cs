using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject BallPrefab;
    [SerializeField] private float moveSpeed = 5f;
    private Vector3 spawnPosition;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (rb == null)
        {
            Debug.LogError("Rigidbody2D component not found on the GameObject.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = Vector2.zero;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            movement += Vector2.up * moveSpeed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            movement += Vector2.down * moveSpeed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            movement += Vector2.left * moveSpeed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            movement += Vector2.right * moveSpeed;
        }

        //rb.position += movement * Time.deltaTime;
        rb.velocity = movement;

        spawnPosition = new Vector3(rb.position.x, rb.position.y - 0.6f, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(BallPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
