using System;
using System.Diagnostics;
using UnityEngine;

public class MovimentoInimigo : MonoBehaviour
{

    private GameObject player;

    private Rigidbody rigidBody;
    private float velocidade;

    public float Raiovisao = 3;
    private bool naVisao = false;

    private SphereCollider _sphereCollider;

    public float distanciaminima;
    void Start()
    {
        velocidade = gameObject.GetComponent<Inimigo>().Velocidade();
        rigidBody = GetComponent<Rigidbody>();
        _sphereCollider = gameObject.GetComponent<SphereCollider>();
        player = GameObject.FindWithTag("Player");
    }


    void Update()
    {
        _sphereCollider.radius = Raiovisao;
        
        if (Vector3.Distance(transform.position, player.transform.position) > 2f)
        if (naVisao == true)
        {
                transform.LookAt(player.transform.position);
                transform.position = Vector3.MoveTowards(transform.position, player.transform.position,
                    velocidade * Time.deltaTime);
            
           //  Debug.Drawline(transform.position, player.transform.position, Color.red);
        }
    }
    
    void OnTriggerStay(Collider colisao)
    {
        if (colisao.CompareTag("Player"))
        {
            naVisao = true;
        }
    }

    void OnTriggerExit(Collider colisao)
    {
        if (colisao.CompareTag("Player"))
        {
            naVisao = false;
        }
    }
}


