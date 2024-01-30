using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacadeAdsManager : MonoBehaviour
{
    AdPlugin1 plugin1;
    AdPlugin2 plugin2;
    AdPlugin3 plugin3;

    // Start is called before the first frame update
    void Start()
    {
        InitPlugin1();
        InitPlugin2();
        InitPlugin3();
    }

    private void InitPlugin3()
    {
        AdPlugin1 plugin3 = new();
    }

    private void InitPlugin2()
    {
        AdPlugin1 plugin2 = new();
    }

    private void InitPlugin1()
    {
        AdPlugin1 plugin1 = new();
    }

    
}
