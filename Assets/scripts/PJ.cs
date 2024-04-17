using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PJ : MonoBehaviour
{
    private Rigidbody2D rb;
    public float Fsalto = 5f;
    public bool contacto = true;

    [SerializeField] deathscreen deathMenu;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && contacto)
        {
            rb.AddForce(Vector2.up * Fsalto, ForceMode2D.Impulse);

            contacto = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Kill"))
        {
            deathMenu.ActivateScreen();
        }
        if (collision.gameObject.CompareTag("piso"))
        {
            contacto = true;
        }
        
    }
}
