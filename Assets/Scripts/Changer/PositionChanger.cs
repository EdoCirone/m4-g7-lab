using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionChanger : GeneralChanger, IHittable
{

    public override void WhenPlayerHit()
    {
        this.transform.position = new Vector3(Random.Range(-100, 100), 0, Random.Range(-100, 100));
    }
   
}
