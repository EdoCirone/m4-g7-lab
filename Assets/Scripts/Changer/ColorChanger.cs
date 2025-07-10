using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : GeneralChanger, IHittable
{
    Renderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();

    }
    public override void WhenPlayerHit()
    {

        _renderer.material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }



}
