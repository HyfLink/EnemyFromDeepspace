using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IEnemy : MonoBehaviour
{
    /// <summary>敌方在战场上的位置</summary>
    [HideInInspector] protected Vector2 position;

    /// <summary>占有半径</summary>
    [HideInInspector] protected double radius;

    /// <summary>敌方的生命值</summary>
    [HideInInspector] protected double health;

    /// <summary>获取敌方在战场上的横坐标</summary>
    public double X { get => position.x; }

    /// <summary>获取敌方在战场上的纵坐标</summary>
    public double Y { get => position.y; }

    /// <summary>获取武器在战场上的坐标</summary>
    public Vector2 Position { get => position; }

    /// <summary>获取敌方的生命值</summary>
    public double Health { get => health; }

    /// <summary>获取占有半径</summary>
    public double Radius { get => radius; }

    /// <summary>判断敌方是否生存</summary>
    public virtual bool IsAlive() => health > 0;

    /// <summary>对敌方造成 damage 伤害</summary>
    public virtual void UpdateHealth(double hp) => health -= hp;

    /// <summary>在敌人生成时调用</summary>
    public abstract void OnEnemyCreate(BattleField filed);

    /// <summary>在敌人死亡时调用</summary>
    public abstract void OnEnemyDestroy(BattleField filed);
}
