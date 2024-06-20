
using System;

public class Model
{
    public int vidas;
    public int velocidad;

    public Model() : this(1) { }

    public Model(int vidaInicial)
    {
        vidas = vidaInicial;
        velocidad = 5;
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
