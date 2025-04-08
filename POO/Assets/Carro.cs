using UnityEngine;

public class Carro

{
    private string nome;
    private int numero_de_rodas;
    private string cor;
    private string preco;

    public string getNome()
    {
        return nome;
    }

    public void setNome(string nome)
    {
        this.nome = nome;
    }

    public string getcor()
    {
        return this.cor;
    }

    public void setcor(string cor)
    {
        this.cor = cor;
    }
}
