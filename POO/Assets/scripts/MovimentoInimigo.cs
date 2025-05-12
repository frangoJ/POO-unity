using UnityEngine;

public class MovimentoInimigo : MonoBehaviour
{
    
    private GameObject player;
    
    private Rigidbody rigidBody;
    private float velocidade;

    public float Raiovisao = 3;
    void Start()
    {
        velocidade = gameObject.GetComponent<Inimigo>().Velocidade();
        rigidBody = GetComponent<Rigidbody>();
        
        player = GameObject.FindWithTag("Player");
    }

   
    void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) < Raiovisao)
        {
            transform.LookAt(player.transform.position);
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, velocidade * Time.deltaTime);
        }
    }
}
