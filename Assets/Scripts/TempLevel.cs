using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempLevel : BattleField
{
    [SerializeField] public GameObject weaponPrefab;
    [SerializeField] public GameObject enemyPrefab;

    // Start is called before the first frame update
    void Start()
    {
        configuration.initialEnergy = 500;
        configuration.width = 9;
        configuration.height = 5;
        configuration.bgm = MusicMngr.MusicID.Level1;

        weaponList = new List<GameObject>();
        enemyList = new List<GameObject>();

        var weapon = Instantiate(weaponPrefab, new Vector3(-5, 0, 0), Quaternion.identity);
        weapon.GetComponent<IWeapon>().Construct(3, 100);
        weaponList.Add(weapon);

        var enemy1 = Instantiate(enemyPrefab, new Vector3(5, 0, +2), Quaternion.identity);
        enemy1.GetComponent<IEnemy>().Construct(3, 100);
        enemyList.Add(enemy1);

        var enemy2 = Instantiate(enemyPrefab, new Vector3(5, 0, -2), Quaternion.identity);
        enemy2.GetComponent<IEnemy>().Construct(3, 100);
        enemyList.Add(enemy2);
    }

    // Update is called once per frame
    void Update() => EntityFrameUpdate();

    void SecondsUpdate() => EntitySecondsUpdate();

    void OnEnable() => InvokeRepeating("SecondsUpdate", 1, 1);
    void OnDisable() => CancelInvoke("SecondsUpdate");

}
