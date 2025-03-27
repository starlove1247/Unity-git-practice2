using NUnit.Framework;
using UnityEngine;

public class CharacterTests
{
    [Test(Description = "玩家角色攻擊敵人")]
    public void Character_Attack_Enemy()
    {
        // arrange
        // 建立角色的元件
        var characterGo = new GameObject();
        characterGo.AddComponent<Character>();
        var character = characterGo.GetComponent<Character>();
        character.SetAtk(10);

        // 建立敵人的元件
        var enemyGo = new GameObject();
        enemyGo.AddComponent<Enemy>();
        var enemy = enemyGo.GetComponent<Enemy>();
        enemy.SetHp(100);

        // act
        // 角色攻擊敵人
        character.Attack(enemy);

        // assert
        // 驗證敵人血量是預期結果
        var enemyHp = enemy.GetHp();
        Assert.AreEqual(90 , enemyHp);
    }

    [Test(Description = "玩家角色攻擊死亡的敵人, 攻擊後敵人血量應為0")]
    [TestCase(30 , 20 , 0 , Description = "死亡但鎖血")]
    [TestCase(10 , 0 ,  0 , Description = "死亡")]
    public void Character_Attack_Dead_Enemy(int atkValue , int hpValue , int expected)
    {
        // arrange
        // 建立角色的元件
        var character = new GameObject().AddComponent<Character>();
        character.SetAtk(atkValue);

        // 建立敵人的元件
        var enemy = new GameObject().AddComponent<Enemy>();
        enemy.SetHp(hpValue);

        // act
        // 角色攻擊敵人
        character.Attack(enemy);

        // assert
        // 驗證敵人血量是預期結果
        var enemyHp = enemy.GetHp();
        Assert.AreEqual(expected , enemyHp);
    }
}