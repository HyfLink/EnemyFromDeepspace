using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempEnemy : IEnemy
{
    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update() { }

    /// <summary>当实体生成时被调用</summary>
    public override void OnEntityCreate(BattleField field) { }

    /// <summary>每帧调用一次</summary>
    public override void OnEntityFrameUpdate(BattleField field) { }

    /// <summary>每秒调用一次</summary>
    public override void OnEntitySecondsUpdate(BattleField field) { }

    /// <summary>当实体生成时被销毁</summary>
    public override void OnEntityDestroy(BattleField field) { }
}
