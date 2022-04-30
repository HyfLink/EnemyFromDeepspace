using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class SolarBatteryWeapon : IWeapon
{
    /// <summary>关卡引用</summary>
    private BattleField filed;

    /// <summary>当武器生成时被调用</summary>
    public override void OnEntityCreate(BattleField field) { }

    /// <summary>每帧调用一次</summary>
    public override void OnEntityFrameUpdate(BattleField field) { }

    /// <summary>每秒调用一次</summary>
    public override void OnEntitySecondsUpdate(BattleField field) { }

    /// <summary>当武器生成时被销毁</summary>
    public override void OnEntityDestroy(BattleField field) { }
}
