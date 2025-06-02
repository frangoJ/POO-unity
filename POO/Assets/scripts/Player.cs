using UnityEngine;

public class Player : MonoBehaviour
{

    private Rigidbody _rigidbody;
    public float speed = 10;
    
    void Start()
    {
        speed = gameObject.GetComponent<Personagem>().Velocidade();
        _rigidbody = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        Vector3 posicao = transform.position;
            
        //esquerda Y-
        if (Input.GetKey(KeyCode.A))
        {
            posicao.x = transform.position.x - speed * Time.deltaTime;
        } 
        
        
        //direita Y+
        if (Input.GetKey(KeyCode.D))
        {
            posicao.x = transform.position.x + speed * Time.deltaTime;
        } 
        
        
        //cima Z+
        if (Input.GetKey(KeyCode.W))
        {
            posicao.z = transform.position.z + speed * Time.deltaTime;
        } 
        
        
        //baixo Z-
        if (Input.GetKey(KeyCode.S))
        {
            posicao.z = transform.position.z - speed * Time.deltaTime;
        } 
        
        transform.position = posicao;
        
    }
}


