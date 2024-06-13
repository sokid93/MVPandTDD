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
    public void aslñdjfalsdkfj()
    {
        Model sut = new Model();
        sut.IncrementarVida(1);
        Assert.AreEqual(2, sut.vidas);
    }

    [Test]
    public void dfdadsffalsdkfj()
    {
        Model sut = new Model();
        sut.IncrementarVida(2);
        Assert.AreEqual(3, sut.vidas);
    }
}
