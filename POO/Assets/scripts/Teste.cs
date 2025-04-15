using UnityEngine;

public class Teste : MonoBehaviour
{
    Carro fusca = new Carro();
    Carro gol = new Carro();
    Caminhao caminhao = new Caminhao();

    void Start()
    {
        fusca.AtribuirNome("Fusca do Pai");
        fusca.AtribuirCor("Verde");
        fusca.AtribuirNumero_de_rodas(4);
        fusca.AtribuirPreco(2050.90f);
        Debug.Log("O " + fusca.NomeDoCarro() + " é " + fusca.CorDoCarro() + ", tem " + fusca.Numero_de_rodas() + " rodas e custa R$" + fusca.Preco());

        gol.AtribuirNome("Gol Azul");
        gol.AtribuirCor("Azul");
        gol.AtribuirNumero_de_rodas(4);
        gol.AtribuirPreco(3000.00f);
        Debug.Log("O " + gol.NomeDoCarro() + " é " + gol.CorDoCarro() + ", tem " + gol.Numero_de_rodas() + " rodas e custa R$" + gol.Preco());

        if (fusca.ComparaPreco(gol))
        {
            Debug.Log("O carro " + fusca.NomeDoCarro() + " é mais caro do que o carro " + gol.NomeDoCarro());
        }
        else
        {
            Debug.Log("O carro " + fusca.NomeDoCarro() + " é mais barato do que o carro " + gol.NomeDoCarro());
        }

        caminhao.AtribuirTipoDeCarroceria("Carga Pesada");
        caminhao.AtribuirNumero_de_rodas(8);
        caminhao.AtribuirPreco(6000.00f);
        caminhao.AtribuirCor("Azul");
        caminhao.AtribuirNome("Caminhão do Faltão");

        if (fusca.ComparaPreco(caminhao))
        {
            Debug.Log("O carro " + fusca.NomeDoCarro() + " é mais caro do que o " + caminhao.NomeDoCarro());
        }
        else
        {
            Debug.Log("O carro " + fusca.NomeDoCarro() + " é mais barato do que o " + caminhao.NomeDoCarro());
        }
    }

    void Update()
    {
        
    }
}