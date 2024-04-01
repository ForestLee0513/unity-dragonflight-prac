using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float speed = 2f;
    public bool invertYToEnemyDirection;
    public int damage = 1;

    // Update is called once per frame
    void Update()
    {
        if(invertYToEnemyDirection)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
    }

    // ȭ�� ������ ���� ��쿡 ���� ó��
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
