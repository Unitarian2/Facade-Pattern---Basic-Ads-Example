using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdPlugin3 : IAdPlugin
{
    Plugin3InitResult initResult = Plugin3InitResult.Failed;

    public AdPlugin3()
    {
        Initialize();
    }

    private void Initialize()
    {
        OnInitialized(Plugin3InitResult.Success);
    }

    private void OnInitialized(Plugin3InitResult result)
    {
        initResult = result;
    }

    public bool IsInitialized()
    {
        if (initResult == Plugin3InitResult.Success)
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

public enum Plugin3InitResult
{
    Success,
    Failed
}
