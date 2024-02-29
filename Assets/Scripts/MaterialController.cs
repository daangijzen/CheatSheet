using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialController : MonoBehaviour
{
    [SerializeField] private string propertyName = "_FlipTrough";

    [Range(0, 24)]
    [SerializeField] private int slider;

    [SerializeField] private List<Material> materialz;

    private void Start()
    {
        var renderers = GetComponentsInChildren<Renderer>();
        foreach (var renderertje in renderers)
        {
            Material[] materials = renderertje.materials;
            materialz.AddRange(materials);
        }
    }

    private void Update()
    {
        foreach (var material in materialz)
        {
            material.SetFloat(propertyName, slider);
        }
    }
}
