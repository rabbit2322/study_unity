using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // �÷��̾��� �̵� �ӵ��� ������ ����

    private Rigidbody2D rb; // �÷��̾��� Rigidbody2D ������Ʈ

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Rigidbody2D ������Ʈ�� ������
    }

    private void Update()
    {
        // �¿� �̵� �Է� ����
        float moveInput = Input.GetAxis("Horizontal");

        // Rigidody2D�� �̿��� �÷��̾ �̵�
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
    }
}