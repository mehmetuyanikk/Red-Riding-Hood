using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTimeK : MonoBehaviour
{
    [SerializeField] float _wolfLife;

    float _currentTime;

    private void FixedUpdate()
    {
        _currentTime += Time.deltaTime;

        if (_currentTime > _wolfLife)
        {
            Destroy(this.gameObject);
        }
    }

}
