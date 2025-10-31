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

        // iƒ|ƒCƒ“ƒgj
        // ƒtƒŒ[ƒ€‚²‚Æ‚É–C’e‚ğ”­Ë‚·‚é
        if (count % 60 == 0)
        {
            GameObject shell = Instantiate(shellPrefab, transform.position, Quaternion.identity);
            Rigidbody2D shellRb = shell.GetComponent<Rigidbody2D>();

            // ’e‘¬‚Í©—R‚Éİ’è
            shellRb.AddForce(Vector2.left * 500000);

            // •bŒã‚É–C’e‚ğ”j‰ó‚·‚é
            Destroy(shell, 0.5f);
        }
    }
}