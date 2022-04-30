using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 武器：电磁炮，
///     基础武器
///     当附近有敌人时，每秒钟发射子弹
/// </summary>
public class ElectromagneticWeapon : IWeapon
{
    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update() { }

    /// <summary>子弹的预制体</summary>
    [SerializeField] private GameObject bulletPrefab;

    /// <summary>攻击半径</summary>
    private const double kAttackDistance = 50;

    /// <summary>当武器生成时被调用</summary>
    public override void OnEntityCreate(BattleField field) { }

    /// <summary>每帧调用一次</summary>
    public override void OnEntityFrameUpdate(BattleField field) { }

    /// <summary>每秒调用一次</summary>
    public override void OnEntitySecondsUpdate(BattleField field)
    {
        foreach (var enemy in field.EnemyList)
        {
            var enemyPos = enemy.GetComponent<Transform>().localPosition;
            var weaponPos = this.GetComponentInParent<Transform>().localPosition;

            var distance = Math.Abs((enemyPos - weaponPos).magnitude);

            if (distance < kAttackDistance)
            {
                Instantiate(bulletPrefab)
                    .GetComponent<DirectBullet>()
                    .SetEnemy(enemy);
                break;
            }
        }
    }

    /// <summary>当武器生成时被销毁</summary>
    public override void OnEntityDestroy(BattleField field) { }
}
