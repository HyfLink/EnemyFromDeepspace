using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 直线攻击的子弹
/// </summary>
public class DirectBullet : MonoBehaviour
{
    /// <summary>目标敌人</summary>
    [HideInInspector] private GameObject targetEnemy;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        throw new System.NotImplementedException();
    }

    public void SetEnemy(GameObject enemy) => targetEnemy = enemy;
}
