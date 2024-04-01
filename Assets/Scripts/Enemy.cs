using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed;
    public int hp;

    void Update()
    {
        transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "PlayerBullet")
        {
            if(hp <= 0)
            {
                Destroy(gameObject);
                EnemySpawnManager.Instance.enemies.Remove(gameObject);
                return;
            }

            hp = hp - collision.gameObject.GetComponent<Weapon>().damage;
            Destroy(collision.gameObject);
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
        EnemySpawnManager.Instance.enemies.Remove(gameObject);
    }
}
