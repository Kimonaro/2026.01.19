using UnityEngine;

public class PararCarro : Carro
{
    public Carro carro;

    void Start()
    {

    }

    void Update()
    {

    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Chao"))
        {
            carro.capotado = true;
        }
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Chao"))
        {
            carro.capotado = false;
        }
    }
}