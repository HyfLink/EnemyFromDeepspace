using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MusicMngr : MonoBehaviour
{
    public enum MusicID
    {
        MainMenu,       // 主界面

        OnSucceed,      // 战斗胜利
        OnFailed,       // 战斗失败

        Level1,         // 关卡1
        Level2,         // 关卡2
        Level3,         // 关卡3

        // ...
    }

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update() { }

    static public void PlayMusic(MusicID id)
    {
        throw new System.NotImplementedException();
    }

    static public void StopMusic(MusicID id)
    {
        throw new System.NotImplementedException();
    }
}
