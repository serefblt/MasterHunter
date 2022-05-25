using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Arrow : MonoBehaviour
{
    bool isPinned = false;
    [SerializeField] float _speed = 20f;
    [SerializeField] Rigidbody2D _rb2D;


    private void Awake()
    {
        _rb2D = GetComponent<Rigidbody2D>();
        _rb2D.velocity = transform.right * _speed;
    }
 
    void Update()
    {
        float angle = Mathf.Atan2(_rb2D.velocity.y, _rb2D.velocity.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Target"))
        {
            transform.SetParent(collision.transform);
            FindObjectOfType<Score>().ScoreShot();
            isPinned = true;
        }
    }
}
