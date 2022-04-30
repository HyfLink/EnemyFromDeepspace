using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 战场类。
/// 存储一个关卡内的各类信息：
/// 我方单位、敌方单位、资源等
/// </summary>
public class BattleField : MonoBehaviour
{
    /// <summary>战场设置</summary>
    public struct Configuration
    {
        /// <summary>棋盘宽度</summary>
        [SerializeField] public uint width;

        /// <summary>棋盘高度</summary>
        [SerializeField] public uint height;

        /// <summary>初始能量值</summary>
        [SerializeField] public uint initialEnergy;

        /// <summary>关卡背景音乐</summary>
        [SerializeField] public MusicMngr.MusicID bgm;
    }

    /// <summary>战场设置</summary>
    [SerializeField] protected Configuration configuration;

    /// <summary>能量值</summary>
    [HideInInspector] protected uint energy;

    /// <summary>武器列表</summary>
    [HideInInspector] protected List<IWeapon> weaponList;

    /// <summary>敌人列表</summary>
    [HideInInspector] protected List<IEnemy> enemyList;

    /// <summary>生成武器的蓝图</summary>
    [HideInInspector] protected List<IBluePrint> bluePrints;


    /// <summary>获取战场宽度</summary>
    public uint Width { get => configuration.width; }

    /// <summary>获取战场高度</summary>
    public uint Height { get => configuration.width; }

    /// <summary>获取当前能量值</summary>
    public uint Energy { get => energy; }

    /// <summary>武器、敌人帧更新</summary>
    public void EntityFrameUpdate()
    {
        // 检测武器和敌人是否死亡
        // 死亡则移除，存活则更新。

        bool update(IEntity entity)
        {
            if (entity.IsAlive())
            {
                entity.OnEntityFrameUpdate(this);
                return true;
            }
            else
            {
                entity.OnEntityDestroy(this);
                return false;
            }
        }

        weaponList.RemoveAll(update);
        enemyList.RemoveAll(update);
    }

    /// <summary>武器、敌人秒更新</summary>
    public void EntitySecondsUpdate()
    {
        weaponList.ForEach(weapon => weapon.OnEntitySecondsUpdate(this));
        enemyList.ForEach(enemy => enemy.OnEntitySecondsUpdate(this));
    }

    /// <summary>生产能量</summary>
    public void ProduceEnergy(uint produced)
    {
        this.energy += produced;

        throw new System.NotImplementedException();
    }

    /// <summary>
    /// 消耗能量，若能量不足，产生提示。
    /// </summary>
    public bool ConsumeEnergy(uint consumed)
    {
        if (energy < consumed)
        {
            NoticeEnergyNotEnough();
            return false;
        }
        else
        {
            energy -= consumed;
            return true;
        }

        throw new System.NotImplementedException();
    }

    /// <summary>
    /// 在position位置创建武器。
    /// </summary>
    /// <param name="bluePrint"></param>
    /// <param name="position"></param>
    public void CreateWeapon(IBluePrint bluePrint, Vector2 position)
    {
        var costs = bluePrint.GetEnergyCosts();
        var radius = bluePrint.GetAreaRadius();
        var collision = CheckCollisionWithWeapons(position, radius);

        if (costs > Energy)
        {
            // 判断能量是否充足
            NoticeEnergyNotEnough();
        }
        else if (collision != null)
        {
            // 判断当前位置上是否已经存在武器
            NoticeWeaponOccupied(collision);
        }
        else
        {
            // 创建武器
            var weapon = bluePrint.CreateWeapon(this, position);
            weapon.OnEntityCreate(this);
        }

        throw new System.NotImplementedException();
    }

    /// <summary>提示当前位置已被占用</summary>
    private void NoticeWeaponOccupied(IWeapon weapon)
    {
        throw new System.NotImplementedException();
    }

    /// <summary>提示能量不足</summary>
    private void NoticeEnergyNotEnough()
    {
        throw new System.NotImplementedException();
    }

    /// <summary>
    /// 判断以pos为圆心，radius为半径的圆是否与某个武器相交。
    /// 若相交，返回该武器的引用，否则返回null。
    /// </summary>
    private IWeapon CheckCollisionWithWeapons(Vector2 pos, double radius)
    {
        foreach (var weapon in weaponList)
        {
            // TODO optimize `sqrt`.
            double minDistance = radius + weapon.Radius;
            double realDistance = (pos - weapon.Position).magnitude;

            if (realDistance < minDistance) { return weapon; }
        }

        return null;
    }
}