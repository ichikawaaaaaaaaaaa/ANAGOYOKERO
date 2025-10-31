using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Player : MonoBehaviour
{
    private Rigidbody2D rbody2D;
    private float jumpForce = 500f;
    private int jumpCount = 0;

    void Start()
    {
        rbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 移動
        if (Input.GetKey(KeyCode.D))
        {
            Vector2 pos = transform.position;
            pos.x += 0.05f;
            transform.position = pos;
        }

        if (Input.GetKey(KeyCode.A))
        {
            Vector2 pos = transform.position;
            pos.x -= 0.05f;
            transform.position = pos;
        }

        // ジャンプ
        if (Input.GetKey(KeyCode.Space) && jumpCount < 1)
        {
            rbody2D.AddForce(transform.up * jumpForce);
            jumpCount++;
        }

        // 落下判定（画面外に落ちたら GAMEOVER シーンへ）
        if (transform.position.y < -5f)
        {
            Debug.Log("落下判定発動！");
            SceneManager.LoadScene("GAMEOVER"); 
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            jumpCount = 0;
        }
    }
}