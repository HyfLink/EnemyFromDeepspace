using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1 : BattleField
{
    /// <summary>
    /// 关卡1的设置，由Editor设置
    /// </summary>
    [SerializeField] private readonly Configuration level1Configuration;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update() { }

    void OnEnable()
    {
        configuration = level1Configuration;

        MusicMngr.PlayMusic(this.configuration.bgm);
    }

    void OnDisable()
    {
        MusicMngr.StopMusic(this.configuration.bgm);
    }
}
