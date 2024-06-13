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
}
