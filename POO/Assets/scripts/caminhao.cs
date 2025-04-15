using UnityEngine;

public class Caminhao : Carro
{
    private string tipoDeCarroceria;

    public void AtribuirTipoDeCarroceria(string tipo)
    {
        this.tipoDeCarroceria = tipo;
    }

    public string ObterTipoDeCarroceria()
    {
        return this.tipoDeCarroceria;
    }
}