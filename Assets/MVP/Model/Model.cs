
using System;

public class Model
{
    public int vidas = 1;

    public Model()
    {
    }

    public Model(int vidaInicial)
    {
        vidas = vidaInicial;
    }

    public void IncrementarVida(int incremento)
    {
        vidas += incremento;
    }

    public void PerderVida()
    {
        vidas -= 1;
    }
}
