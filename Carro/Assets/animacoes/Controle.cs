using UnityEngine;

public class Controle : MonoBehaviour
{
    private Animator animator;
    public float velocidade;
    
    private bool correndo = false;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    
    void Update()
    {
        correndo = false;
        
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-velocidade * Time.deltaTime, 0, 0);
            correndo = true;
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(velocidade * Time.deltaTime, 0, 0);
            correndo = true;
        }
        
        animator.SetBool("Correndo", correndo);
    }
}
