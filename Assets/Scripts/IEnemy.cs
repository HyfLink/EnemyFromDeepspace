using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IEnemy : MonoBehaviour
{
    /// <summary>敌方在战场上的位置</summary>
    [HideInInspector] protected Vector2 position;

    /// <summary>敌方的生命值</summary>
    [HideInInspector] protected double health;

    /// <summary>获取敌方在战场上的横坐标</summary>
    public double X { get => position.x; }

    /// <summary>获取敌方在战场上的纵坐标</summary>
    public double Y { get => position.y; }

    /// <summary>获取敌方的生命值</summary>
    public double Health { get => health; }

    public IEnemy(Vector2 pos) { position = pos; }

    /// <summary>判断敌方是否生存</summary>
    public virtual bool IsAlive() => health > 0;

    /// <summary>对敌方造成 damage 伤害</summary>
    public virtual void UpdateHealth(double hp) => health -= hp;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update() { }
}
