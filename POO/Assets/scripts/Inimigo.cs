using UnityEngine;

public class Inimigo : MonoBehaviour
{
    private string armadura;
    private string arma;
    private int forcaAtaque = 10; // valor padrão (pode ser mudado depois)

    // Atribui a armadura
    public void AtribuirArmadura(string novaArmadura)
    {
        armadura = novaArmadura;
    }

    public string GetArmadura()
    {
        return armadura;
    }

    // Atribui a arma
    public void AtribuirArma(string novaArma)
    {
        arma = novaArma;
    }

    public string GetArma()
    {
        return arma;
    }

    // Define a força de ataque do inimigo
    public void SetForcaAtaque(int novaForca)
    {
        forcaAtaque = novaForca;
    }

    public int GetForcaAtaque()
    {
        return forcaAtaque;
    }

    // Calcula o dano baseado na arma
    public int DanoDoInimigo()
    {
        int dano = 0;

        switch (arma.ToUpper())
        {
            case "ESPADA":
                dano = forcaAtaque + 10;
                break;
            case "MACHADO":
                dano = forcaAtaque + 18;
                break;
            case "ADAGA":
                dano = forcaAtaque + 5;
                break;
            default:
                dano = forcaAtaque; // caso nenhuma arma seja atribuída
                break;
        }

        return dano;
    }
}