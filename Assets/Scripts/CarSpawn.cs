using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawn : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;

    private void Awake()
    {
        Instantiate(_prefab);
    }
}
