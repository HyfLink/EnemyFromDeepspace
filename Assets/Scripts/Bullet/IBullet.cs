using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>追踪敌人的子弹</summary>
public abstract class IBullet : MonoBehaviour
{
    /// <summary>目标敌人</summary>
    [HideInInspector] protected GameObject target;

    // Update is called once per frame
    void Update()
    {
        if ((bool)target?.GetComponent<IEnemy>().IsAlive())
        {
            gameObject.GetComponent<Transform>().Translate(GetTranslation());
        }
        else // 若目标不存在则销毁自身
        {
            GameObject.Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if ((bool)target.GetComponent<IEnemy>()?.IsAlive())
        {
            target.GetComponent<IEnemy>().UpdateHealth(GetDamage());
        }

        GameObject.Destroy(gameObject);
    }

    /// <summary>设置目标敌人</summary>
    public void SetEnemy(GameObject enemy) => target = enemy;

    /// <summary>获取子弹的伤害</summary>
    public abstract double GetDamage();

    /// <summary>获取每帧移动的向量</summary>
    public abstract Vector3 GetTranslation();
}
