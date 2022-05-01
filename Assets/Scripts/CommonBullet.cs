using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>追踪敌人的子弹</summary>
public class CommonBullet : MonoBehaviour
{
    /// <summary>伤害值</summary>
    [HideInInspector] private double damage;

    /// <summary>子弹速度</summary>
    [HideInInspector] private float speed;

    /// <summary>目标敌人</summary>
    [HideInInspector] private GameObject target;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        if ((bool)target?.GetComponent<IEnemy>().IsAlive())
        {
            var dstPosition = target.GetComponent<Transform>().localPosition;
            var srcPosition = gameObject.GetComponent<Transform>().localPosition;
            var translation = ((dstPosition - srcPosition).normalized * speed * Time.deltaTime);

            gameObject.GetComponent<Transform>().Translate(translation);
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
            target.GetComponent<IEnemy>().UpdateHealth(damage);
        }

        GameObject.Destroy(gameObject);
    }

    /// <summary>设置敌人，初始化此类</summary>
    /// <param name="enemy">目标敌人</param>
    /// <param name="damage">伤害</param>
    public void Construct(GameObject enemy, double damage, float speed)
    {
        this.target = enemy;
        this.damage = damage;
        this.speed = speed;
    }
}
