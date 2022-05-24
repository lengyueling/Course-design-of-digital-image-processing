using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectManager : MonoBehaviour
{
    public BrightnessSaturationAndContrast BSC;
    public EdgeDetection EdgeDetection;
    public MotionBlur MotionBlur;
    public GaussianBlur GaussianBlur;
    public Bloom Bloom;
    public Opposition Opposition;

    public void EnableBSC()
    {
        if (BSC.isActiveAndEnabled)
        {
            BSC.enabled = false;
        }
        else
        {
            BSC.enabled = true;
        }
    }

    public void OnBriValueChanged(float value)
    {
        BSC.brightness = value;
    }

    public void OnSatValueChanged(float value)
    {
        BSC.saturation = value;
    }

    public void OnConValueChanged(float value)
    {
        BSC.contrast = value;
    }

    public void EnableEdgeDetection()
    {
        if (EdgeDetection.isActiveAndEnabled)
        {
            EdgeDetection.enabled = false;
        }
        else
        {
            EdgeDetection.enabled = true;
        }
    }
    public void OnEdgeValueChanged(float value)
    {
        EdgeDetection.edgesOnly = value;
    }
    
    public void EnableGaussianBlur()
    {
        if (GaussianBlur.isActiveAndEnabled)
        {
            GaussianBlur.enabled = false;
        }
        else
        {
            GaussianBlur.enabled = true;
        }
    }

    public void OnGauIterationsValueChanged(float value)
    {
        GaussianBlur.iterations = (int)value;
    }

    public void OnGauBlurSpreadValueChanged(float value)
    {
        GaussianBlur.blurSpread = value;
    }

    public void OnGauDownSampleValueChanged(float value)
    {
        GaussianBlur.downSample = (int)value;
    }

    public void EnableBloom()
    {
        if (Bloom.isActiveAndEnabled)
        {
            Bloom.enabled = false;
        }
        else
        {
            Bloom.enabled = true;
        }
    }

    public void OnBloomIterationsValueChanged(float value)
    {
        Bloom.iterations = (int)value;
    }

    public void OnBloomBlurSpreadValueChanged(float value)
    {
        Bloom.blurSpread = value;
    }

    public void OnBloomDownSampleValueChanged(float value)
    {
        Bloom.downSample = (int)value;
    }

    public void OnBloomThresholdValueChanged(float value)
    {
        Bloom.luminanceThreshold = value;
    }

    public void EnableMotionBlur()
    {
        if (MotionBlur.isActiveAndEnabled)
        {
            MotionBlur.enabled = false;
        }
        else
        {
            MotionBlur.enabled = true;
        }
    }

    public void OnMotionBlurAmountValueChanged(float value)
    {
        MotionBlur.blurAmount = value;
    }

    public void EnableOpposition()
    {
        if (Opposition.isActiveAndEnabled)
        {
            Opposition.enabled = false;
        }
        else
        {
            Opposition.enabled = true;
        }
    }
}
