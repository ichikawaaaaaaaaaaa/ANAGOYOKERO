using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject shellPrefab;
    public AudioClip sound;
    private int count;

    void Update()
    {
        count += 1;

        // �i�|�C���g�j
        // �t���[�����ƂɖC�e�𔭎˂���
        if (count % 60 == 0)
        {
            GameObject shell = Instantiate(shellPrefab, transform.position, Quaternion.identity);
            Rigidbody2D shellRb = shell.GetComponent<Rigidbody2D>();

            // �e���͎��R�ɐݒ�
            shellRb.AddForce(Vector2.left * 500000);

            // �b��ɖC�e��j�󂷂�
            Destroy(shell, 0.5f);
        }
    }
}