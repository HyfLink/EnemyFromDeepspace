using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IBluePrint : MonoBehaviour
{
    /// <summary>生成武器的预制体，在Editor中设置</summary>
    [SerializeField] protected readonly GameObject prefab;

    /// <summary>
    /// 尝试消耗蓝图，生成武器。
    /// 若失败，返回 null。
    /// </summary>
    /// <param name="field">战场信息</param>
    /// <param name="position">武器在战场上的位置</param>
    /// <returns>武器</returns>
    public abstract IWeapon CreateWeapon(BattleField field, Vector2 position);

    /// <summary>获取能量消耗</summary>
    public abstract uint GetEnergyCosts();

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update() { }
}
