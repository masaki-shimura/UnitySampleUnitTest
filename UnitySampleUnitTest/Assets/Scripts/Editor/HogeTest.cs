using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class HogeTest
{
    [Test,Category("正常系テスト"),Description("サンプルテストコード Debug.Logでもログを残せる！")]
    public void HogeTestSimplePasses()
    {
        var hoge = new Hoge();
        var equalToValue = 2;
        var result = hoge.Add(1, 1);
        
        Assert.That(result,Is.EqualTo(equalToValue),"失敗しました");
        
        Debug.Log($"result:{result}/equalToValue:{equalToValue}");
    }

    [Test,Category("正常系テスト")]
    [Ignore("メソッド内でエラーが発生した時にどのような挙動がされるのか確認する為のテストコード")]
    public void HogeTestForceExceptionTest()
    {
        var hoge = new Hoge();
        hoge.ForceException();
    }
    
    [Test,Category("異常系テスト"),Description("Exceptionが呼ばれたら成功するサンプルコード")]
    public void HogeTestForceExceptionSuccessTest()
    {
        var hoge = new Hoge();
        Assert.That(()=>
        {
            hoge.ForceException();
        }, Throws.TypeOf<Exception>(),"Exceptionが呼ばれてないよー");
    }
    [Test,Category("正常系テスト"),Description("色んなパターンで実行")]
    [TestCase(0,1,1)]
    [TestCase(0,1,2)]
    [TestCase(0,2,1)]
    public void HogeTestSimpleVariousSuccessPasses(int greaterValue,int a,int b)
    {
        var hoge = new Hoge();
        var result = hoge.Add(a, b);
        
        Assert.That(result,Is.GreaterThan(greaterValue),"失敗しました");
        
        Debug.Log($"result:{result}/equalToValue:{greaterValue}");
    }
    
    [Test,Category("失敗例"),Description("色んなパターンで実行 失敗例"),Ignore("失敗例")]
    [TestCase(0,1,1)]
    [TestCase(0,1,-2)]
    [TestCase(0,2,1)]
    public void HogeTestSimplePassesFailure(int greaterValue,int a,int b)
    {
        var hoge = new Hoge();
        var result = hoge.Add(a, b);
        
        Assert.That(result,Is.GreaterThan(greaterValue),"失敗しました");
        
        Debug.Log($"result:{result}/equalToValue:{greaterValue}");
    }
}
