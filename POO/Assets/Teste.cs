using UnityEngine;

public class Teste : MonoBehaviour
{
 Carro fusca = new Carro();
    
    void Start()
    {
        fusca.setNome("fusca do neyma");
        fusca.setcor("verde");
        
        Debug.Log("0 "+ fusca.getNome() + fusca.getcor()
        );
    }

    
    void Update()
    {
        
    }
}
