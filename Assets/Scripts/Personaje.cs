using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidadMovimiento = 5.0f;
    public float velocidadRotacion = 200.0f;
    public Animator animator;
    public float x, y;

    // Update is called once per frame
    void Start()
{
    animator = GetComponent<Animator>();
}

// Update is called once per frame
void Update()
{
    x = Input.GetAxis("Horizontal");
    y = Input.GetAxis("Vertical");

    transform.Rotate(0, x * Time.deltaTime * velocidadRotacion, 0);
    transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimiento);

        animator.SetFloat("VerX", x);
        animator.SetFloat("VerY", y);
    }
}
