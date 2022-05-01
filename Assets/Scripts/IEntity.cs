using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IEntity : MonoBehaviour
{
    /// <summary>占有半径</summary>
    [HideInInspector] protected double radius;

    /// <summary>实体的生命值</summary>
    [SerializeField] protected double health;

    /// <summary>获取实体的生命值</summary>
    public double Health { get => health; }

    /// <summary>获取占有半径</summary>
    public double Radius { get => radius; }

    public void Construct(double radius, double health)
    {
        this.radius = radius;
        this.health = health;
    }

    /// <summary>判断实体是否生存</summary>
    public virtual bool IsAlive() => health > 0;

    /// <summary>对实体造成 hp 伤害</summary>
    public virtual void UpdateHealth(double hp) => health -= hp;

    /// <summary>当实体生成时被调用</summary>
    public abstract void OnEntityCreate(BattleField field);

    /// <summary>每帧调用一次</summary>
    public abstract void OnEntityFrameUpdate(BattleField field);

    /// <summary>每秒调用一次</summary>
    public abstract void OnEntitySecondsUpdate(BattleField field);

    /// <summary>当实体生成时被销毁</summary>
    public abstract void OnEntityDestroy(BattleField field);
}
