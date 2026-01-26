using UnityEditorInternal;
using UnityEngine;

public class Carro : MonoBehaviour
{
    public float velocidadeMaxima = 10f;

    public ConstantForce2D forca;
    
    public bool capotado = false;

    public enum Direcao
    {
        Frente, Traz
    }

    public Direcao direcao = Direcao.Frente;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            direcao = Direcao.Frente;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            direcao = Direcao.Traz;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            if (direcao == Direcao.Frente)
            {
                forca.force = Vector2.right * velocidadeMaxima;
            }
            else if (direcao == Direcao.Traz)
            {
                forca.force = Vector2.left * velocidadeMaxima;
            }
            
        }
        else
        {
            forca.force = Vector2.zero;
        }
    }
}
