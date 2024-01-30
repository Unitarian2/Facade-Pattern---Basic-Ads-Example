using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdPlugin2 : IAdPlugin
{
    Plugin2InitResult initResult = Plugin2InitResult.Failed;

    public AdPlugin2()
    {
        Initialize();
    }


    private void Initialize()
    {
        OnInitialized(Plugin2InitResult.Success);
    }

    private void OnInitialized(Plugin2InitResult result)
    {
        initResult = result;
    }

    public bool IsInitialized()
    {
        if (initResult == Plugin2InitResult.Success)
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

public enum Plugin2InitResult
{
    Success,
    Failed
}
