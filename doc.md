### 音乐

设置一个MusicMngr类。内有两个静态函数和一个枚举类

1. MusicID
    表示背景音乐的ID
2. PlayMusic
    根据 ID 播放若干次音乐。
    若次数为 0 则循环播放。
3. StopMusic
    根据 ID 停止播放音乐。

代码接口:

```C#
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

    static public void PlayMusic(MusicID id, uint n)
    {
        throw new System.NotImplementedException();
    }

    static public void StopMusic(MusicID id)
    {
        throw new System.NotImplementedException();
    }
}
```