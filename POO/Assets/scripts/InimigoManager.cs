using UnityEngine;

public class InimigoManager : MonoBehaviour
{
    public Animator animator;
    private MovimentoInimigo movimentoInimigo;
    public float velocidadeDaAnimacao = 1;

    void Start()
    {
        movimentoInimigo = GetComponent<MovimentoInimigo>();
    }

    void Update()
    {
        animator.SetBool("Andando", movimentoInimigo.andando);
        animator.speed = velocidadeDaAnimacao;

        if (movimentoInimigo.ataque == true)
        {
            animator.SetTrigger("Ataque");
        }
    }
}