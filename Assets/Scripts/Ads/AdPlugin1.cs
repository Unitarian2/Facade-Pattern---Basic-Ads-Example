using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdPlugin1 : IAdPlugin
{
    Plugin1InitResult initResult = Plugin1InitResult.Failed;

   public AdPlugin1()
    {
        Initialize();
    }

    
    private void Initialize()
    {
        OnInitialized(Plugin1InitResult.Success);
    }

    private void OnInitialized(Plugin1InitResult result)
    {
        initResult = result;
    }

    public bool IsInitialized()
    {
        if(initResult == Plugin1InitResult.Success)
        {
            return true;
        }
        else return false;
    }

    public float GetCPM()
    {
        throw new NotImplementedException();
    }

    public void ShowAd()
    {
        throw new NotImplementedException();
    }

    public void HideAd()
    {
        throw new NotImplementedException();
    }
}

public enum Plugin1InitResult{
    Success,
    Failed
}
