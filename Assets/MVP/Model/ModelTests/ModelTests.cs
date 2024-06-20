using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class ModelTests
{
    [Test]
    public void NoGameOverPorDefecto()
    {
        Model sut = new Model();
        Assert.IsTrue(sut.vidas > 0);
    }

    [Test]
    public void IncrementoVida()
    {
        Model sut = new Model();
        sut.IncrementarVida(1);
        Assert.AreEqual(2, sut.vidas);
    }

    [Test]
    public void IncrementoDeVariasVidas()
    {
        Model sut = new Model();
        sut.IncrementarVida(2);
        Assert.AreEqual(3, sut.vidas);
    }

    [Test]
    public void PerderVida()
    {
        Model sut = new Model();
        sut.PerderVida();
        Assert.AreEqual(0, sut.vidas);
    }

    [Test]
    public void PerderVariasVidas()
    {
        Model sut = new Model(2);
        sut.PerderVida();
        sut.PerderVida();
        Assert.AreEqual(0, sut.vidas);
    }

    [Test]
    public void VelocidadInicialNoEsCero()
    {
        Model sut = new Model();
        Assert.Greater(sut.velocidad, 0);
    }
}
