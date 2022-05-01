using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IBluePrint : MonoBehaviour
{
    /// <summary>生成武器的预制体，在Editor中设置</summary>
    [SerializeField] public readonly GameObject prefab;

    /// <summary>获取能量消耗</summary>
    public abstract uint GetEnergyCosts();

    /// <summary>获取武器范围</summary>
    public abstract double GetAreaRadius();

    /// <summary>获取初始血量</summary>
    public abstract double GetInitialHealth();
}
