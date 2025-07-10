using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GeneralChanger : MonoBehaviour, IHittable

{

    public abstract void WhenPlayerHit();

    public void Hit() => WhenPlayerHit();
 
}
