using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSystem : MonoBehaviour
{
    [SerializeField] BattleUnit playerUnit;
    [SerializeField] BattleHUD playerHud;

    [SerializeField] BattleUnit enemyUnit;
    [SerializeField] BattleHUD enemyHud;

    private void Start(){
        SetupBattle();
    }

    public void SetupBattle(){
        playerUnit.Setup();
        enemyUnit.Setup();
        playerHud.SetData(playerUnit.Pokemon);
        enemyHud.SetData(enemyUnit.Pokemon);
    }
}
