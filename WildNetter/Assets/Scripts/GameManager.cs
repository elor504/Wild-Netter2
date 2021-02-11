﻿
public class GameManager : MonoSingleton<GameManager>
{
    public ISingleton[] singletons;
    private void Start()
    {
        Init();
     //   PlayerInventory.GetInstance.AddToInventory(ItemFactory._Instance.GenerateItem(40000));
     
    }

    public override void Init()
    {
        singletons = new ISingleton[15] {
            SceneHandler._Instance,
            ItemFactory._Instance,
            MyCamera._Instance,
            PlayerManager._Instance,
            PlayerStats._Instance,
            TotemManager._Instance,
            UiManager._Instance,
            InventoryUIManager._Instance,
            InputManager._Instance,
            PlayerCombat._Instance,
            PlayerMovement._Instance,
            SoundManager._Instance,
            EnemySpawner._Instance,
            EnemyManager._Instance,
            TextPopUpHandler._Instance
        };

        for (int i = 0; i < singletons.Length; i++)
        {
            if (singletons[i] != null)
                singletons[i].Init();
        }
    }

}
