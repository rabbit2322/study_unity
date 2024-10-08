using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // 플레이어의 이동 속도를 조절할 변수

    private Rigidbody2D rb; // 플레이어의 Rigidbody2D 컴포넌트

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Rigidbody2D 컴포넌트를 가져옴
    }

    private void Update()
    {
        // 좌우 이동 입력 감지
        float moveInput = Input.GetAxis("Horizontal");

        // Rigidody2D를 이용해 플레이어를 이동
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
    }
}