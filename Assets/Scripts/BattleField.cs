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
    [HideInInspector] protected List<List<IWeapon>> weapons;

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

    /// <summary>将屏幕坐标转换为战场坐标</summary>
    Vector2Int ConvertScreenPosToFieldPos(Vector2 screenPos)
    {
        throw new System.NotImplementedException();
    }

    /// <summary>将战场坐标转换为实际坐标</summary>
    Vector3 ConvertFieldPosToWorldPos(Vector2Int fieldPos)
    {
        throw new System.NotImplementedException();
    }

    /// <summary>根据战场坐标获取武器</summary>
    IWeapon GetWeapon(Vector2Int pos) => weapons[pos.y][pos.x];

    /// <summary>根据战场坐标获取武器</summary>
    IWeapon GetWeapon(int x, int y) => weapons[y][x];

    void CreateWeapon(IBluePrint bluePrint, Vector2 screenPos)
    {
        // 获取战场坐标，判断战场上是否已经存在武器。
        Vector2Int fieldPos = ConvertScreenPosToFieldPos(screenPos);
        uint costs = bluePrint.GetEnergyCosts();

        if (GetWeapon(fieldPos) != null) // 位置占用
        {
            NoticeWeaponOccupied(fieldPos);
        }
        else if (costs < Energy) // 能量不足
        {
            NoticeEnergyNotEnough(costs);
        }
        else
        {
            weapons[fieldPos.y][fieldPos.x] =
                bluePrint.CreateWeapon(this, fieldPos);
        }
    }

    /// <summary>提示当前位置已被占用</summary>
    void NoticeWeaponOccupied(Vector2Int fieldPos)
    {
        throw new System.NotImplementedException();
    }

    /// <summary>提示能量不足</summary>
    void NoticeEnergyNotEnough(double costs)
    {
        throw new System.NotImplementedException();
    }
}