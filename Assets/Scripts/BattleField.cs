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

    /// <summary>战场上武器的二维列表</summary>
    [HideInInspector] protected List<IWeapon> weapons;

    /// <summary>生成武器的蓝图</summary>
    [HideInInspector] protected List<IBluePrint> bluePrints;


    /// <summary>获取战场宽度</summary>
    public uint Width { get => configuration.width; }

    /// <summary>获取战场高度</summary>
    public uint Height { get => configuration.width; }

    /// <summary>获取当前能量值</summary>
    public uint Energy { get => energy; }

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update() { }

    void CreateWeapon(IBluePrint bluePrint, Vector2 position)
    {
        // 判断战场上是否已经存在武器。
        //      NoticeWeaponOccupied();
        // 判断能量是否充足
        //      NoticeEnergyNotEnough();
        //
        //      weapons.Add(bluePrint.CreateWeapon(this, position));

        throw new System.NotImplementedException();
    }

    /// <summary>提示当前位置已被占用</summary>
    void NoticeWeaponOccupied()
    {
        throw new System.NotImplementedException();
    }

    /// <summary>提示能量不足</summary>
    void NoticeEnergyNotEnough()
    {
        throw new System.NotImplementedException();
    }
}