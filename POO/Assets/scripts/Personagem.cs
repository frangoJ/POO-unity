using UnityEngine;

public class Player : MonoBehaviour
{
    
    public string nome = "JogadorN1";
    public float energia = 100f;
    public float forcaDoPulo = 5f;
    public float velocidade = 10f;
    public int numeroDePes = 2;
    public int numeroDeMaos = 2;
    public float forcaDeAtaque = 20f;

    private Rigidbody rb;
    private bool podePular = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogWarning("");
        }
    }

    void Update()
    {
        
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movimento = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.Translate(movimento * velocidade * Time.deltaTime);

        
        if (Input.GetKeyDown(KeyCode.Space) && podePular && rb != null)
        {
            rb.AddForce(Vector3.up * forcaDoPulo, ForceMode.Impulse);
            podePular = false; 
        }

        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Chao"))
        {
            podePular = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Chao"))
        {
            podePular = false;
        }
    }

}
 