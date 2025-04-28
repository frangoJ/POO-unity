using UnityEngine;

public class Personagem : MonoBehaviour
{
    public string nome = "Afonso Padilha";
    public float energia = 100f;
    public float forcaAtaque = 15f;
    public float forcaDoPulo = 7f;
    public float velocidade = 5f;
    public int numeroDePes = 2;
    public int numeroDeMaos = 2;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        Debug.Log($"Personagem {nome} criado com {energia} de energia, {numeroDePes} pés e {numeroDeMaos} mãos!");
    }

    private void Update()
    {
        Mover();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Pular();
        }
    }

    private void Mover()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direcao = new Vector3(horizontal, 0, vertical).normalized;
        rb.MovePosition(transform.position + direcao * velocidade * Time.deltaTime);
    }

    private void Pular()
    {
        if (rb != null)
        {
            rb.AddForce(Vector3.up * forcaDoPulo, ForceMode.Impulse);
        }
    }

    public void Atacar(Inimigo inimigo)
    {
        if (inimigo != null)
        {
            int danoCausado = (int)forcaAtaque;
            Debug.Log($"{nome} atacou {inimigo.name} causando {danoCausado} de dano!");
        }
    }

    public void SofrerDano(int dano)
    {
        energia -= dano;
        Debug.Log($"{nome} sofreu {dano} de dano! Energia restante: {energia}");

        if (energia <= 0)
        {
            Morrer();
        }
    }

    private void Morrer()
    {
        Debug.Log($"{nome} morreu!");
        Destroy(gameObject);
    }
    
}