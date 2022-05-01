using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalBullet : IBullet
{
    /// <summary>获取子弹的伤害</summary>
    public override double GetDamage() => 50;

    /// <summary>获取每帧移动的向量</summary>
    public override Vector3 GetTranslation()
    {
        var dstPosition = target.GetComponent<Transform>().localPosition;
        var srcPosition = gameObject.GetComponent<Transform>().localPosition;
        return (dstPosition - srcPosition).normalized * Time.deltaTime * 3;
    }
}
