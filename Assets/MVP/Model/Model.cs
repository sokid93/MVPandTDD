
using System;

public class Model
{
    public int vidas = 1;

    public void IncrementarVida(int incremento)
    {
        vidas += incremento;
    }

    public void PerderVida()
    {
        vidas -= 1;
    }
}
