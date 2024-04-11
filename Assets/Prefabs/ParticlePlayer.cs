using System;
using UnityEngine;

public class ParticlePlayer : MonoBehaviour
{
    private void OnEnable()
    {
        Invoke(nameof(DeactivateSelf), 10f);
    }

    private void DeactivateSelf()
    {
        gameObject.SetActive(false);
    }
}