using UnityEngine;
public class Teste : MonoBehaviour
{ 
    Carro fusca = new Carro();
    Carro gol = new Carro();
    
    Caminhao caminhao = new Caminhao();
    
    //=========================
    
    Personagem joao = new Personagem();
    Inimigo ork = new Inimigo();
    
    void Start()
    {
        fusca.AtribuirNome("Fusca de Pai");
        fusca.AtribuirCor("Amarelo");
        fusca.AtribuirNumero_de_rodas(4);
        fusca.AtribuirPreco(2050.90f);
        Debug.Log("O "+ fusca.NomeDoCarro() +" é "+ fusca.CorDoCarro() + " tem " + fusca.Numero_de_rodas()+
                  " e custa R$"+fusca.Preco());
        
        gol.AtribuirNome("Gol do Falstão");
        gol.AtribuirCor("Verde");
        gol.AtribuirNumero_de_rodas(4);
        gol.AtribuirPreco(3000.00f);
        Debug.Log("O "+ gol.NomeDoCarro());

        if (fusca.ComparePreco(gol))
        {
            Debug.Log("O Carro " + fusca.NomeDoCarro() + " é mais caro do que o carro " + gol.NomeDoCarro());
        }
        else
        {
            Debug.Log("O Carro " + fusca.NomeDoCarro() + " é mais barato do que o carro " + gol.NomeDoCarro());
        }

        caminhao.AtribuirTipoDeCarroceria("Larga");
        caminhao.AtribuirNumero_de_rodas(8);
        caminhao.AtribuirPreco(6000.00f);
        caminhao.AtribuirCor("Azul");
        caminhao.AtribuirNome("Caminhão do Falstão");
        
        //fusca.AtribuirTipoDeCarroceria("Larga");

        if (fusca.ComparePreco(caminhao))
        {
            Debug.Log("O Carro " + fusca.NomeDoCarro() + " é mais caro do que o " + caminhao.NomeDoCarro());
        }
        else
        {
            Debug.Log("O Carro " + fusca.NomeDoCarro() + " é mais barato do que o " + caminhao.NomeDoCarro());
        }

        
        //============================================
        
        joao.AtribuirNome("João Roberto II");
        joao.AtribuirEnergia(10);
        joao.AtribuirForca_Ataque(12);
        joao.AtribuirForca_do_pulo(6);
        joao.AtribuirVelocidade(8);
        joao.AtribuitNumero_de_pes(2);
        joao.AtribuitNumero_de_maos(2);
        
        ork.AtribuirNome("Ork Gob");
        ork.AtribuirEnergia(23);
        ork.AtribuirForca_Ataque(15);
        ork.AtribuirForca_do_pulo(8);
        ork.AtribuirVelocidade(6);
        ork.AtribuitNumero_de_pes(2);
        ork.AtribuitNumero_de_maos(4);
        ork.AtribuirArma(Inimigo.ArmaDoInimigo.MACHADO);
        ork.AtribuirArmadura(Inimigo.ArmaduraDoInimigo.COURO);

        if (ork.DanoDoInimigo() >= joao.Energia())
        {
            Debug.Log("O " + joao.Nome() + " ficou sem energia");
        }
        else
        {
            Debug.Log("O " + joao.Nome() + " aonda tem "+ joao.Energia() + "energia");
        }

    }
    void Update()
    {
        
    }
}