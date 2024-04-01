using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private new Rigidbody2D rigidbody;
    private float h;
    public float speed = 3.0f;
 
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");
    }

    // physics
    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        rigidbody.MovePosition(rigidbody.transform.position + (new Vector3(h, 0) * speed * Time.deltaTime));
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "EnemyBullet")
        {
            Debug.Log("hit");
            Destroy(collision.gameObject);
        }

        if (collision.tag == "Enemy")
        {
            // 데미지 추가 및 체력 관리 관련 스크립트 추가 예정
            Destroy(collision.gameObject);
            EnemySpawnManager.Instance.enemies.Remove(collision.gameObject);
        }
    }
}
