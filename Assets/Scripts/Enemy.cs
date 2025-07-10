using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IHittable
{
    [SerializeField] int _enemyHp = 3;

    public void Hit()
    {
        if (_enemyHp > 0)
        {
            _enemyHp--;
        }

       _enemyHp =  Mathf.Max(_enemyHp, 0);

        if (_enemyHp == 0)
        {
            gameObject.SetActive(false);
        }

    }
}